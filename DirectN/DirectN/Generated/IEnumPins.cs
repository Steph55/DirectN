﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\strmif.h(1519,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("56a86892-0ad4-11ce-b03a-0020af0ba770"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IEnumPins
    {
        [PreserveSig]
        HRESULT Next(/* [in] */ uint cPins, /* [annotation][size_is][out] _Out_writes_to_(cPins, *pcFetched) */ out IntPtr ppPins, /* optional(ULONG) */ IntPtr pcFetched);
        
        [PreserveSig]
        HRESULT Skip(/* [in] */ uint cPins);
        
        [PreserveSig]
        HRESULT Reset();
        
        [PreserveSig]
        HRESULT Clone(/* [annotation][out] _Out_ */ out IEnumPins ppEnum);
    }
}
