﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\d3dukmdt.h(203,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXGK_PTE__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] __bits;
        public _DXGK_PTE__union_0__struct_0 __field_0 => InteropRuntime.Get<_DXGK_PTE__union_0__struct_0>(__bits, 0, 64);
        public ulong Flags => InteropRuntime.GetUInt6s(__bits, 0, 64);
    }
}
