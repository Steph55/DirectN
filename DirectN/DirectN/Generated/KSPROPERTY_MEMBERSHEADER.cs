﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\ks.h(252,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct KSPROPERTY_MEMBERSHEADER
    {
        public uint MembersFlags;
        public uint MembersSize;
        public uint MembersCount;
        public uint Flags;
    }
}
