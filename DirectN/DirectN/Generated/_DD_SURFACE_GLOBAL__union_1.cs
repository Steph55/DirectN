﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(747,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_SURFACE_GLOBAL__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public IntPtr lpVidMemHeap => InteropRuntime.Get<IntPtr>(__bits, 0, 64);
        public uint dwBlockSizeX => InteropRuntime.GetUInt32(__bits, 0, 32);
        public uint dwUserMemSize => InteropRuntime.GetUInt32(__bits, 0, 32);
    }
}
