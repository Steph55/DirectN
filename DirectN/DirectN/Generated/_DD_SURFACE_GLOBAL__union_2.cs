﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(755,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_SURFACE_GLOBAL__union_2
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public int lPitch => InteropRuntime.GetInt32(__bits, 0, 32);
        public uint dwLinearSize => InteropRuntime.GetUInt32(__bits, 0, 32);
    }
}
