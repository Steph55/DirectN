﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfcaptureengine.h(330,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("52150b82-ab39-4467-980f-e48bf0822ecd"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFCaptureEngineOnSampleCallback
    {
        [PreserveSig]
        HRESULT OnSample(/* optional(IMFSample) */ IntPtr pSample);
    }
}
