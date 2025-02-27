﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dhal.h(128,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DDeviceDesc_V1
    {
        public uint dwSize;
        public uint dwFlags;
        public uint dcmColorModel;
        public uint dwDevCaps;
        public _D3DTRANSFORMCAPS dtcTransformCaps;
        public bool bClipping;
        public _D3DLIGHTINGCAPS dlcLightingCaps;
        public _D3DPrimCaps dpcLineCaps;
        public _D3DPrimCaps dpcTriCaps;
        public uint dwDeviceRenderBitDepth;
        public uint dwDeviceZBufferBitDepth;
        public uint dwMaxBufferSize;
        public uint dwMaxVertexCount;
    }
}
