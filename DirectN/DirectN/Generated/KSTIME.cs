﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ks.h(2052,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSTIME
    {
        public long Time;
        public uint Numerator;
        public uint Denominator;
    }
}
