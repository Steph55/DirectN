﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(1013,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagHANDLETABLE
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public IntPtr[] objectHandle;
    }
}
