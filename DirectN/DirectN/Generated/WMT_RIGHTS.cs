﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wmsdkidl.h(1453,1)
using System;

namespace DirectN
{
    [Flags]
    public enum WMT_RIGHTS
    {
        WMT_RIGHT_PLAYBACK = 0x00000001,
        WMT_RIGHT_COPY_TO_NON_SDMI_DEVICE = 0x00000002,
        WMT_RIGHT_COPY_TO_CD = 0x00000008,
        WMT_RIGHT_COPY_TO_SDMI_DEVICE = 0x00000010,
        WMT_RIGHT_ONE_TIME = 0x00000020,
        WMT_RIGHT_SAVE_STREAM_PROTECTED = 0x00000040,
        WMT_RIGHT_COPY = 0x00000080,
        WMT_RIGHT_COLLABORATIVE_PLAY = 0x00000100,
        WMT_RIGHT_SDMI_TRIGGER = 0x00010000,
        WMT_RIGHT_SDMI_NOMORECOPIES = 0x00020000,
    }
}
