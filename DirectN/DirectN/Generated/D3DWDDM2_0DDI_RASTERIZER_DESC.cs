﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10umddi.h(5249,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3DWDDM2_0DDI_RASTERIZER_DESC
    {
        public D3D10_DDI_FILL_MODE FillMode;
        public D3D10_DDI_CULL_MODE CullMode;
        public bool FrontCounterClockwise;
        public int DepthBias;
        public float DepthBiasClamp;
        public float SlopeScaledDepthBias;
        public bool DepthClipEnable;
        public bool ScissorEnable;
        public bool MultisampleEnable;
        public bool AntialiasedLineEnable;
        public uint ForcedSampleCount;
        public D3DWDDM2_0DDI_CONSERVATIVE_RASTERIZATION_MODE ConservativeRasterizationMode;
    }
}
