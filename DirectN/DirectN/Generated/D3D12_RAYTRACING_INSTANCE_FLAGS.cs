﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(13117,1)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12_RAYTRACING_INSTANCE_FLAGS
    {
        D3D12_RAYTRACING_INSTANCE_FLAG_NONE = 0x00000000,
        D3D12_RAYTRACING_INSTANCE_FLAG_TRIANGLE_CULL_DISABLE = 0x00000001,
        D3D12_RAYTRACING_INSTANCE_FLAG_TRIANGLE_FRONT_COUNTERCLOCKWISE = 0x00000002,
        D3D12_RAYTRACING_INSTANCE_FLAG_FORCE_OPAQUE = 0x00000004,
        D3D12_RAYTRACING_INSTANCE_FLAG_FORCE_NON_OPAQUE = 0x00000008,
    }
}
