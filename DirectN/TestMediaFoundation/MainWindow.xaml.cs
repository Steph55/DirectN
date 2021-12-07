using DirectN;
using System;
using System.Linq;
using System.Text;
using System.Windows;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace TestMediaFoundation
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Test();
        }

        public Guid __uuidof<T>()
        {
            var attribs = Attribute.GetCustomAttributes(typeof(T), typeof(GuidAttribute));
            foreach (GuidAttribute attrib in attribs)
            {
                if (attrib.GetType() == typeof(GuidAttribute))
                    return new Guid(attrib.Value);
            }
            return new Guid();
        }
        void Test()
        {
            //IMFMediaSource* pVideoSource = NULL;
            //UINT32 videoDeviceCount = 0;
            //IMFActivate** videoDevices = NULL;
            //IMFSourceReader* pVideoReader = NULL;
            //WCHAR* webcamFriendlyName;
            //IMFMediaType* pMJPEGOutputType = NULL;
            //IMFMediaType* pSourceOutputType = NULL;
            //IMFSinkWriter* pWriter = NULL;
            //IMFMediaType* pVideoOutType = NULL;
            //DWORD writerVideoStreamIndex = 0;
            //UINT webcamNameLength = 0;

            var s = __uuidof<ICodecAPI>();

            IMFAttributes videoConfig;

            Functions.MFStartup(Constants.MF_SDK_VERSION << 16 | Constants.MF_API_VERSION, Constants.MFSTARTUP_FULL);
            Functions.MFCreateAttributes(out videoConfig, 1).ThrowOnError();

            videoConfig.SetGUID(MFConstants.MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE,
                        MFConstants.MF_DEVSOURCE_ATTRIBUTE_SOURCE_TYPE_VIDCAP_GUID).ThrowOnError();

            //        MFEnumDeviceSources(videoConfig, &videoDevices, &videoDeviceCount),
            //            "Error enumerating video devices.");
            var deviceSources = videoConfig.EnumDeviceSources();
            IComObject<IMFMediaSource> pVideoSource;
            IMFActivate mFActivate = videoConfig.EnumDeviceSources().First();
            string cameraName = mFActivate.GetString(MFConstants.MF_DEVSOURCE_ATTRIBUTE_FRIENDLY_NAME);
            pVideoSource = mFActivate.ActivateObject<IMFMediaSource>();
            Functions.MFCreateSourceReaderFromMediaSource(pVideoSource.Object, videoConfig, out IMFSourceReader pVideoReader);
            HRESULT hr = HRESULTS.S_OK;
            uint dwStreamIndex = 0;
            uint dwMediaTypeIndex = 0;
            Functions.MFCreateMediaType(out IMFMediaType pSourceOutputType);
            while (hr == HRESULTS.S_OK)
            {
                hr = pVideoReader.GetNativeMediaType(dwStreamIndex, dwMediaTypeIndex, out IMFMediaType pType);
                if (hr == HRESULTS.MF_E_NO_MORE_TYPES)
                {
                    hr = HRESULTS.S_OK;
                    break;
                }
                else if (hr.IsSuccess)
                {
                    ulong ratioFrameRateMax = (ulong)pType.GetValue(MFConstants.MF_MT_FRAME_RATE_RANGE_MAX);
                    ulong ratioFrameSize = (ulong)pType.GetValue(MFConstants.MF_MT_FRAME_SIZE);
                    pType.GetGUID(MFConstants.MF_MT_SUBTYPE, out Guid subType).ThrowOnError();
                    if (ratioFrameRateMax >> 32 == 30 && ratioFrameSize >> 32 == 1920 && (ratioFrameSize & 0xFFFF) == 1080 && subType == MFConstants.MFVideoFormat_NV12)
                    {
                        pSourceOutputType = pType;
                        break;
                    }
                }
                ++dwMediaTypeIndex;
            }
            uint dummy = 0;
            unchecked
            {
                pVideoReader.SetCurrentMediaType((uint)__MIDL___MIDL_itf_mfreadwrite_0000_0001_0001.MF_SOURCE_READER_FIRST_VIDEO_STREAM,
                   IntPtr.Zero, pSourceOutputType).ThrowOnError();
            }

            // Create the MP4 sink writer.
            Functions.MFCreateSinkWriterFromURL(@"F:\Test.mp4", null, null, out IMFSinkWriter pWriter).ThrowOnError();
            //Functions.MFTRegisterLocalByCLSID(__uuidof(CColorConvertDMO),
            //    MFT_CATEGORY_VIDEO_PROCESSOR,
            //    L"",
            //    MFT_ENUM_FLAG_SYNCMFT,
            //    0,
            //    NULL,
            //    0,
            //    NULL
            //    ).ThrowOnError();
            // Configure the output video type on the sink writer.
            Functions.MFCreateMediaType(out IMFMediaType pVideoOutType).ThrowOnError();
            pSourceOutputType.CopyAllItems(pVideoOutType).ThrowOnError();
            // Only thing we want to change from source to sink is to get an mp4 output.
            pVideoOutType.SetGUID(MFConstants.MF_MT_SUBTYPE, MFConstants.MFVideoFormat_HEVC).ThrowOnError();
            pVideoOutType.SetUINT32(MFConstants.MF_MT_AVG_BITRATE, 2200000).ThrowOnError();
            pVideoOutType.SetUINT64(MFConstants.MF_MT_FRAME_RATE, 30L << 32 | 1L);
            pVideoOutType.SetUINT32(MFConstants.MF_MT_INTERLACE_MODE, 2).ThrowOnError();
            pVideoOutType.SetUINT32(MFConstants.MF_MT_MPEG2_PROFILE, (int)eAVEncH265VProfile.eAVEncH265VProfile_Main_420_8).ThrowOnError();
            pVideoOutType.SetUINT32(MFConstants.MF_MT_MPEG2_LEVEL, (int)eAVEncH265VLevel.eAVEncH265VLevel4).ThrowOnError();

            pWriter.AddStream(pVideoOutType, out uint writerVideoStreamIndex).ThrowOnError();

            pWriter.SetInputMediaType(writerVideoStreamIndex, pSourceOutputType, null).ThrowOnError();

            // Retrieve the ICodecAPI
            pWriter.GetServiceForStream(writerVideoStreamIndex, new Guid(), typeof(ICodecAPI).GUID, out object codecApi).ThrowOnError();

#if false
            VARIANT v;
            codecApi.GetValue(MFConstants.CODECAPI_AVEncCommonQuality, &v).ThrowOnError();
            v.uiVal = 98;
            codecApi.SetValue(&CODECAPI_AVEncCommonQuality, &v).ThrowOnError();
            v.uintVal = 30;
            codecApi.SetValue(&CODECAPI_AVEncMPVGOPSize, &v).ThrowOnError();
            //VARIANT e;
            //codecApi.GetValue(&CODECAPI_AVEncCommonQuality, &e), "");
            v.uintVal = eAVEncCommonRateControlMode.eAVEncCommonRateControlMode_CBR;
            codecApi.GetValue(&CODECAPI_AVEncCommonRateControlMode, &v).ThrowOnError();
            // codecApi.GetValue(&CODECAPI_AVEncCommonMeanBitRate, &v), "");

            v.ulVal = 8;
            codecApi.SetValue(&CODECAPI_AVEncNumWorkerThreads, &v).ThrowOnError();

            pWriter.BeginWriting().ThrowOnError();

            uint streamIndex, flags;
            long llVideoTimeStamp;
            IMFSample videoSample;
            long llVideoBaseTime = -1;
            int sampleCount = 0;

            printf("Recording...\n");

            while (sampleCount < SAMPLE_COUNT)
            {
                pVideoReader.ReadSample(
                    MFConstants.MF_SOURCE_READER_ANY_STREAM,                // Stream index.
                    0,                                                                  // Flags.
                    &streamIndex,                                               // Receives the actual stream index. 
                    &flags,                                                         // Receives status flags.
                    &llVideoTimeStamp,                                  // Receives the time stamp.
                    &videoSample)                                               // Receives the sample or NULL.
                    .ThrowOnError();

                printf("FRAME %d.\n", sampleCount);
                if (videoSample)
                {
                    if (llVideoBaseTime == -1) llVideoBaseTime = llVideoTimeStamp;
                    // Re-base the time stamp.
                    llVideoTimeStamp -= llVideoBaseTime;

                    videoSample.SetSampleTime(llVideoTimeStamp), "Set video sample time failed.");
                    pWriter.WriteSample(writerVideoStreamIndex, videoSample), "Write video sample failed.");

                    SAFE_RELEASE(&videoSample);
                }

                sampleCount++;
            }

            printf("Finalising the capture.\n");

            if (pWriter)
            {
                pWriter.Finalize(), "Error finalising H.264 sink writer.");
            }
#endif
        }
    }
}
