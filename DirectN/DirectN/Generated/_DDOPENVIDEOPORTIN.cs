﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\ddkmapi.h(127,13)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DDOPENVIDEOPORTIN
    {
        public IntPtr hDirectDraw;
        public uint dwVideoPortHandle;
        public IntPtr pfnVideoPortClose;
        public IntPtr pContext;
    }
}
