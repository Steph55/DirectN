﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(1404,9)
using System;
using System.Runtime.InteropServices;
using DDCOLORKEY = DirectN._DDCOLORKEY;
using PDD_SURFACE_LOCAL = DirectN._DD_SURFACE_LOCAL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_DRVSETCOLORKEYDATA
    {
        public IntPtr lpDDSurface;
        public uint dwFlags;
        public DDCOLORKEY ckNew;
        public HRESULT ddRVal;
        public IntPtr SetColorKey;
    }
}
