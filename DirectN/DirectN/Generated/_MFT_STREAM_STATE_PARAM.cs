﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\mftransform.h(1292,9)
using System;
using System.Runtime.InteropServices;
using MF_STREAM_STATE = DirectN._MF_STREAM_STATE;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _MFT_STREAM_STATE_PARAM
    {
        public uint StreamId;
        public MF_STREAM_STATE State;
    }
}
