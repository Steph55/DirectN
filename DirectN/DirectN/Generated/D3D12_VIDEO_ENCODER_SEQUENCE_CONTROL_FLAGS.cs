﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(6972,1)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAGS
    {
        D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_NONE = 0x00000000,
        D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_RESOLUTION_CHANGE = 0x00000001,
        D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_RATE_CONTROL_CHANGE = 0x00000002,
        D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_SUBREGION_LAYOUT_CHANGE = 0x00000004,
        D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_REQUEST_INTRA_REFRESH = 0x00000008,
        D3D12_VIDEO_ENCODER_SEQUENCE_CONTROL_FLAG_GOP_SEQUENCE_CHANGE = 0x00000010,
    }
}
