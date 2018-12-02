﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\dxva.h(1117,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct _DXVA_PicParams_MPEG4_PART2__union_1__struct_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] __bits;
        public ushort sprite_enable => InteropRuntime.GetUInt16(__bits, 0, 2);
        public ushort no_of_sprite_warping_points => InteropRuntime.GetUInt16(__bits, 2, 6);
        public ushort sprite_warping_accuracy => InteropRuntime.GetUInt16(__bits, 8, 2);
    }
}
