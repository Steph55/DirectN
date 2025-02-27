﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(7292,9)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12DDI_GRAPHICS_STATES
    {
        D3D12DDI_GRAPHICS_STATE_NONE = 0x00000000,
        D3D12DDI_GRAPHICS_STATE_IA_VERTEX_BUFFERS = 0x00000001,
        D3D12DDI_GRAPHICS_STATE_IA_INDEX_BUFFER = 0x00000002,
        D3D12DDI_GRAPHICS_STATE_IA_PRIMITIVE_TOPOLOGY = 0x00000004,
        D3D12DDI_GRAPHICS_STATE_DESCRIPTOR_HEAP = 0x00000008,
        D3D12DDI_GRAPHICS_STATE_GRAPHICS_ROOT_SIGNATURE = 0x00000010,
        D3D12DDI_GRAPHICS_STATE_COMPUTE_ROOT_SIGNATURE = 0x00000020,
        D3D12DDI_GRAPHICS_STATE_RS_VIEWPORTS = 0x00000040,
        D3D12DDI_GRAPHICS_STATE_RS_SCISSOR_RECTS = 0x00000080,
        D3D12DDI_GRAPHICS_STATE_PREDICATION = 0x00000100,
        D3D12DDI_GRAPHICS_STATE_OM_RENDER_TARGETS = 0x00000200,
        D3D12DDI_GRAPHICS_STATE_OM_STENCIL_REF = 0x00000400,
        D3D12DDI_GRAPHICS_STATE_OM_BLEND_FACTOR = 0x00000800,
        D3D12DDI_GRAPHICS_STATE_PIPELINE_STATE = 0x00001000,
        D3D12DDI_GRAPHICS_STATE_SO_TARGETS = 0x00002000,
        D3D12DDI_GRAPHICS_STATE_OM_DEPTH_BOUNDS = 0x00004000,
        D3D12DDI_GRAPHICS_STATE_SAMPLE_POSITIONS = 0x00008000,
        D3D12DDI_GRAPHICS_STATE_VIEW_INSTANCE_MASK = 0x00010000,
    }
}
