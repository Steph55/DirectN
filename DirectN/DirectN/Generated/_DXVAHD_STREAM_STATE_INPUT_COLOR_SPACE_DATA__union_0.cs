﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxvahd.h(392,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DXVAHD_STREAM_STATE_INPUT_COLOR_SPACE_DATA__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 4)]
        public byte[] __bits;
        public _DXVAHD_STREAM_STATE_INPUT_COLOR_SPACE_DATA__union_0__struct_0 __field_0 => InteropRuntime.Get<_DXVAHD_STREAM_STATE_INPUT_COLOR_SPACE_DATA__union_0__struct_0>(__bits, 0, 32);
        public uint Value => InteropRuntime.GetUInt32(__bits, 0, 32);
    }
}
