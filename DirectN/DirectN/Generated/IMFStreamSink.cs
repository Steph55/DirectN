﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(2484,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("0a97b3cf-8e7c-4a3d-8f8c-0c843dc247fb"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFStreamSink
    {
        [PreserveSig]
        HRESULT GetMediaSink(/* [out] __RPC__deref_out_opt */ out IMFMediaSink ppMediaSink);
        
        [PreserveSig]
        HRESULT GetIdentifier(/* [out] __RPC__out */ out uint pdwIdentifier);
        
        [PreserveSig]
        HRESULT GetMediaTypeHandler(/* [out] __RPC__deref_out_opt */ out IMFMediaTypeHandler ppHandler);
        
        [PreserveSig]
        HRESULT ProcessSample(/* optional(IMFSample) */ IntPtr pSample);
        
        [PreserveSig]
        HRESULT PlaceMarker(/* [in] */ _MFSTREAMSINK_MARKER_TYPE eMarkerType, /* [in] __RPC__in */ PropVariant pvarMarkerValue, /* [in] __RPC__in */ PropVariant pvarContextValue);
        
        [PreserveSig]
        HRESULT Flush();
    }
}
