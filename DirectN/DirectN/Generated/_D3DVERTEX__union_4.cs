﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3dtypes.h(472,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DVERTEX__union_4
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public float ny => InteropRuntime.GetSingle(__bits, 0, 32);
        public float dvNY => InteropRuntime.GetSingle(__bits, 0, 32);
    }
}
