﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10.h(3297,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D10_TEX1D_ARRAY_DSV
    {
        public uint MipSlice;
        public uint FirstArraySlice;
        public uint ArraySize;
    }
}
