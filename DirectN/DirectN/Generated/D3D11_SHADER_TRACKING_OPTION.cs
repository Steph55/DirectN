﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d11sdklayers.h(448,1)
namespace DirectN
{
    public enum D3D11_SHADER_TRACKING_OPTION
    {
        D3D11_SHADER_TRACKING_OPTION_IGNORE = 0,
        D3D11_SHADER_TRACKING_OPTION_TRACK_UNINITIALIZED = 1,
        D3D11_SHADER_TRACKING_OPTION_TRACK_RAW = 2,
        D3D11_SHADER_TRACKING_OPTION_TRACK_WAR = 4,
        D3D11_SHADER_TRACKING_OPTION_TRACK_WAW = 8,
        D3D11_SHADER_TRACKING_OPTION_ALLOW_SAME = 16,
        D3D11_SHADER_TRACKING_OPTION_TRACK_ATOMIC_CONSISTENCY = 32,
        D3D11_SHADER_TRACKING_OPTION_TRACK_RAW_ACROSS_THREADGROUPS = 64,
        D3D11_SHADER_TRACKING_OPTION_TRACK_WAR_ACROSS_THREADGROUPS = 128,
        D3D11_SHADER_TRACKING_OPTION_TRACK_WAW_ACROSS_THREADGROUPS = 256,
        D3D11_SHADER_TRACKING_OPTION_TRACK_ATOMIC_CONSISTENCY_ACROSS_THREADGROUPS = 512,
        D3D11_SHADER_TRACKING_OPTION_UAV_SPECIFIC_FLAGS = 960,
        D3D11_SHADER_TRACKING_OPTION_ALL_HAZARDS = 1006,
        D3D11_SHADER_TRACKING_OPTION_ALL_HAZARDS_ALLOWING_SAME = 1022,
        D3D11_SHADER_TRACKING_OPTION_ALL_OPTIONS = 1023,
    }
}
