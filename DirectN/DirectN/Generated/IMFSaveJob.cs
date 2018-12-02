﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mfidl.h(12266,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [Guid("e9931663-80bf-4c6e-98af-5dcf58747d1f"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IMFSaveJob
    {
        [PreserveSig]
        HRESULT BeginSave(/* [in] */ ref IMFByteStream pStream, /* [in] */ ref IMFAsyncCallback pCallback, /* [in] */ [MarshalAs(UnmanagedType.IUnknown)] object pState);
        
        [PreserveSig]
        HRESULT EndSave(/* [in] */ ref IMFAsyncResult pResult);
        
        [PreserveSig]
        HRESULT CancelSave();
        
        [PreserveSig]
        HRESULT GetProgress(/* [annotation][out] _Out_ */ out uint pdwPercentComplete);
    }
}
