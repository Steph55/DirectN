﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12umddi.h(7642,9)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12DDI_STATE_SUBOBJECT_TYPE
    {
        D3D12DDI_STATE_SUBOBJECT_TYPE_STATE_OBJECT_CONFIG = 0x00000000,
        D3D12DDI_STATE_SUBOBJECT_TYPE_GLOBAL_ROOT_SIGNATURE = 0x00000001,
        D3D12DDI_STATE_SUBOBJECT_TYPE_LOCAL_ROOT_SIGNATURE = 0x00000002,
        D3D12DDI_STATE_SUBOBJECT_TYPE_NODE_MASK = 0x00000003,
        D3D12DDI_STATE_SUBOBJECT_TYPE_DXIL_LIBRARY = 0x00000005,
        D3D12DDI_STATE_SUBOBJECT_TYPE_EXISTING_COLLECTION = 0x00000006,
        D3D12DDI_STATE_SUBOBJECT_TYPE_RAYTRACING_SHADER_CONFIG = 0x00000009,
        D3D12DDI_STATE_SUBOBJECT_TYPE_RAYTRACING_PIPELINE_CONFIG = 0x0000000A,
        D3D12DDI_STATE_SUBOBJECT_TYPE_HIT_GROUP = 0x0000000B,
        D3D12DDI_STATE_SUBOBJECT_TYPE_SHADER_EXPORT_SUMMARY = 0x00100000,
    }
}
