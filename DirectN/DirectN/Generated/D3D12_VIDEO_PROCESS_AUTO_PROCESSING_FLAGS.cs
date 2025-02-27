﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(1284,1)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAGS
    {
        D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_NONE = 0x00000000,
        D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_DENOISE = 0x00000001,
        D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_DERINGING = 0x00000002,
        D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_EDGE_ENHANCEMENT = 0x00000004,
        D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_COLOR_CORRECTION = 0x00000008,
        D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_FLESH_TONE_MAPPING = 0x00000010,
        D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_IMAGE_STABILIZATION = 0x00000020,
        D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_SUPER_RESOLUTION = 0x00000040,
        D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_ANAMORPHIC_SCALING = 0x00000080,
        D3D12_VIDEO_PROCESS_AUTO_PROCESSING_FLAG_CUSTOM = unchecked((int)0x80000000),
    }
}
