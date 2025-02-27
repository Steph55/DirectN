﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(390,9)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12DDI_RESOURCE_STATES
    {
        D3D12DDI_RESOURCE_STATE_COMMON = 0x00000000,
        D3D12DDI_RESOURCE_STATE_VERTEX_AND_CONSTANT_BUFFER = 0x00000001,
        D3D12DDI_RESOURCE_STATE_INDEX_BUFFER = 0x00000002,
        D3D12DDI_RESOURCE_STATE_RENDER_TARGET = 0x00000004,
        D3D12DDI_RESOURCE_STATE_UNORDERED_ACCESS = 0x00000008,
        D3D12DDI_RESOURCE_STATE_DEPTH_WRITE = 0x00000010,
        D3D12DDI_RESOURCE_STATE_DEPTH_READ = 0x00000020,
        D3D12DDI_RESOURCE_STATE_NON_PIXEL_SHADER_RESOURCE = 0x00000040,
        D3D12DDI_RESOURCE_STATE_PIXEL_SHADER_RESOURCE = 0x00000080,
        D3D12DDI_RESOURCE_STATE_STREAM_OUT = 0x00000100,
        D3D12DDI_RESOURCE_STATE_INDIRECT_ARGUMENT = 0x00000200,
        D3D12DDI_RESOURCE_STATE_COPY_DEST = 0x00000400,
        D3D12DDI_RESOURCE_STATE_COPY_SOURCE = 0x00000800,
        D3D12DDI_RESOURCE_STATE_RESOLVE_DEST = 0x00001000,
        D3D12DDI_RESOURCE_STATE_RESOLVE_SOURCE = 0x00002000,
        D3D12DDI_RESOURCE_STATE_0020_VIDEO_DECODE_READ = 0x00010000,
        D3D12DDI_RESOURCE_STATE_0020_VIDEO_DECODE_WRITE = 0x00020000,
        D3D12DDI_RESOURCE_STATE_0020_VIDEO_PROCESS_READ = 0x00040000,
        D3D12DDI_RESOURCE_STATE_0020_VIDEO_PROCESS_WRITE = 0x00080000,
        D3D12DDI_RESOURCE_STATE_0060_VIDEO_ENCODE_READ = 0x00200000,
        D3D12DDI_RESOURCE_STATE_0060_VIDEO_ENCODE_WRITE = 0x00800000,
        D3D12DDI_RESOURCE_STATE_0062_SHADING_RATE_SOURCE = 0x01000000,
        D3D12DDI_RESOURCE_STATE_RAYTRACING_ACCELERATION_STRUCTURE = 0x00400000,
    }
}
