﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(3440,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DEPTH_STENCIL_VIEW_DESC
    {
        public DXGI_FORMAT Format;
        public D3D12_DSV_DIMENSION ViewDimension;
        public D3D12_DSV_FLAGS Flags;
        public D3D12_DEPTH_STENCIL_VIEW_DESC__union_0 __union_3;
    }
}
