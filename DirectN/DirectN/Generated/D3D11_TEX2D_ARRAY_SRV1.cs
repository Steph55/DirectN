﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11_3.h(915,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_TEX2D_ARRAY_SRV1
    {
        public uint MostDetailedMip;
        public uint MipLevels;
        public uint FirstArraySlice;
        public uint ArraySize;
        public uint PlaneSlice;
    }
}
