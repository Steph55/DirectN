﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dcaps.h(42,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DLIGHTINGCAPS
    {
        public uint dwSize;
        public uint dwCaps;
        public uint dwLightingModel;
        public uint dwNumLights;
    }
}
