﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10.h(6961,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("9b7e4e00-342c-4106-a19f-4f2704f689f0"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface ID3D10Multithread
    {
        [PreserveSig]
        void Enter();
        
        [PreserveSig]
        void Leave();
        
        [PreserveSig]
        bool SetMultithreadProtected(/* [annotation] _In_ */ bool bMTProtect);
        
        [PreserveSig]
        bool GetMultithreadProtected();
    }
}
