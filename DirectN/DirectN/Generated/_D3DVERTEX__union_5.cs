﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dtypes.h(476,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 4)]
    public partial struct _D3DVERTEX__union_5
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public float nz { get => InteropRuntime.GetSingle(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetSingle(value, __bits, 0, 32); } }
        public float dvNZ { get => InteropRuntime.GetSingle(__bits, 0, 32); set { if (__bits == null) __bits = new byte[4]; InteropRuntime.SetSingle(value, __bits, 0, 32); } }
    }
}
