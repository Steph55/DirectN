﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(3026,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("545b3a48-3283-4f62-866f-a62d8f598f9f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFVideoSampleAllocatorEx : IMFVideoSampleAllocator
    {
        // IMFVideoSampleAllocator
        [PreserveSig]
        new HRESULT SetDirectXManager(/* [unique][in] */ [MarshalAs(UnmanagedType.IUnknown)] object pManager);
        
        [PreserveSig]
        new HRESULT UninitializeSampleAllocator();
        
        [PreserveSig]
        new HRESULT InitializeSampleAllocator(/* [in] */ uint cRequestedFrames, /* [in] */ ref IMFMediaType pMediaType);
        
        [PreserveSig]
        new HRESULT AllocateSample(/* [out] */ out IntPtr ppSample);
        
        // IMFVideoSampleAllocatorEx
        [PreserveSig]
        HRESULT InitializeSampleAllocatorEx(/* [annotation] _In_ */ uint cInitialSamples, /* [annotation] _In_ */ uint cMaximumSamples, /* optional(IMFAttributes) */ IntPtr pAttributes, /* [annotation] _In_ */ ref IMFMediaType pMediaType);
    }
}
