﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(786,9)
using System;
using System.Runtime.InteropServices;
using DDSCAPS = DirectN._DDSCAPS;
using PDD_ATTACHLIST = DirectN._DD_ATTACHLIST;
using PDD_SURFACE_GLOBAL = DirectN._DD_SURFACE_GLOBAL;
using RECT = DirectN.tagRECT;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_SURFACE_LOCAL
    {
        public IntPtr lpGbl;
        public uint dwFlags;
        public DDSCAPS ddsCaps;
        public IntPtr dwReserved1;
        public _DD_SURFACE_LOCAL__union_0 __union_4;
        public _DD_SURFACE_LOCAL__union_1 __union_5;
        public IntPtr lpSurfMore;
        public IntPtr lpAttachList;
        public IntPtr lpAttachListFrom;
        public RECT rcOverlaySrc;
    }
}
