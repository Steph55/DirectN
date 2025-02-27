﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12video.h(7044,1)
using System;

namespace DirectN
{
    [Flags]
    public enum D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAGS
    {
        D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_NO_ERROR = 0x00000000,
        D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_CODEC_PICTURE_CONTROL_NOT_SUPPORTED = 0x00000001,
        D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_SUBREGION_LAYOUT_CONFIGURATION_NOT_SUPPORTED = 0x00000002,
        D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_INVALID_REFERENCE_PICTURES = 0x00000004,
        D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_RECONFIGURATION_REQUEST_NOT_SUPPORTED = 0x00000008,
        D3D12_VIDEO_ENCODER_ENCODE_ERROR_FLAG_INVALID_METADATA_BUFFER_SOURCE = 0x00000010,
    }
}
