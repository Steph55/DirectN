﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ksmedia.h(1479,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSRTAUDIO_BUFFER
    {
        public IntPtr BufferAddress;
        public uint ActualBufferSize;
        public bool CallMemoryBarrier;
    }
}
