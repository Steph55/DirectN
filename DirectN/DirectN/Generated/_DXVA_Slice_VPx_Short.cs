﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\dxva.h(1471,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_Slice_VPx_Short
    {
        public uint BSNALunitDataLocation;
        public uint SliceBytesInBuffer;
        public ushort wBadSliceChopping;
    }
}
