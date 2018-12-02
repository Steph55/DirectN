﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(8966,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("35fe1bb8-a3a9-40fe-bbec-eb569c9ccca3"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFWorkQueueServices
    {
        [PreserveSig]
        HRESULT BeginRegisterTopologyWorkQueuesWithMMCSS(/* [in] */ ref IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [PreserveSig]
        HRESULT EndRegisterTopologyWorkQueuesWithMMCSS(/* [in] */ ref IMFAsyncResult pResult);
        
        [PreserveSig]
        HRESULT BeginUnregisterTopologyWorkQueuesWithMMCSS(/* [in] */ ref IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [PreserveSig]
        HRESULT EndUnregisterTopologyWorkQueuesWithMMCSS(/* [in] */ ref IMFAsyncResult pResult);
        
        [PreserveSig]
        HRESULT GetTopologyWorkQueueMMCSSClass(/* [in] */ uint dwTopologyWorkQueueId, /* [size_is][out] __RPC__out_ecount_full(*pcchClass) */ [MarshalAs(UnmanagedType.LPWStr)] string pwszClass, /* [out][in] __RPC__inout */ ref uint pcchClass);
        
        [PreserveSig]
        HRESULT GetTopologyWorkQueueMMCSSTaskId(/* [in] */ uint dwTopologyWorkQueueId, /* [out] __RPC__out */ out uint pdwTaskId);
        
        [PreserveSig]
        HRESULT BeginRegisterPlatformWorkQueueWithMMCSS(/* [in] */ uint dwPlatformWorkQueue, /* [in] */ [MarshalAs(UnmanagedType.LPWStr)] string wszClass, /* [in] */ uint dwTaskId, /* [in] */ ref IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [PreserveSig]
        HRESULT EndRegisterPlatformWorkQueueWithMMCSS(/* [in] */ ref IMFAsyncResult pResult, /* [annotation][out] _Out_ */ out uint pdwTaskId);
        
        [PreserveSig]
        HRESULT BeginUnregisterPlatformWorkQueueWithMMCSS(/* [in] */ uint dwPlatformWorkQueue, /* [in] */ ref IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [PreserveSig]
        HRESULT EndUnregisterPlatformWorkQueueWithMMCSS(/* [in] */ ref IMFAsyncResult pResult);
        
        [PreserveSig]
        HRESULT GetPlaftormWorkQueueMMCSSClass(/* [in] */ uint dwPlatformWorkQueueId, /* [size_is][out] __RPC__out_ecount_full(*pcchClass) */ [MarshalAs(UnmanagedType.LPWStr)] string pwszClass, /* [out][in] __RPC__inout */ ref uint pcchClass);
        
        [PreserveSig]
        HRESULT GetPlatformWorkQueueMMCSSTaskId(/* [in] */ uint dwPlatformWorkQueueId, /* [out] __RPC__out */ out uint pdwTaskId);
    }
}
