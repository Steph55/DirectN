﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d10.h(7072,1)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D10_CREATE_DEVICE_FLAG
    {
        D3D10_CREATE_DEVICE_SINGLETHREADED = 0x00000001,
        D3D10_CREATE_DEVICE_DEBUG = 0x00000002,
        D3D10_CREATE_DEVICE_SWITCH_TO_REF = 0x00000004,
        D3D10_CREATE_DEVICE_PREVENT_INTERNAL_THREADING_OPTIMIZATIONS = 0x00000008,
        D3D10_CREATE_DEVICE_ALLOW_NULL_FROM_MAP = 0x00000010,
        D3D10_CREATE_DEVICE_BGRA_SUPPORT = 0x00000020,
        D3D10_CREATE_DEVICE_PREVENT_ALTERING_LAYER_SETTINGS_FROM_REGISTRY = 0x00000080,
        D3D10_CREATE_DEVICE_STRICT_VALIDATION = 0x00000200,
        D3D10_CREATE_DEVICE_DEBUGGABLE = 0x00000400,
    }
}
