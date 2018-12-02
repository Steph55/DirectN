﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\ddrawint.h(1181,9)
using System;
using System.Runtime.InteropServices;
using DDOVERLAYFX = DirectN._DDOVERLAYFX;
using PDD_DIRECTDRAW_GLOBAL = DirectN._DD_DIRECTDRAW_GLOBAL;
using PDD_SURFACE_LOCAL = DirectN._DD_SURFACE_LOCAL;
using RECTL = DirectN._RECTL;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _DD_UPDATEOVERLAYDATA
    {
        public IntPtr lpDD;
        public IntPtr lpDDDestSurface;
        public RECTL rDest;
        public IntPtr lpDDSrcSurface;
        public RECTL rSrc;
        public uint dwFlags;
        public DDOVERLAYFX overlayFX;
        public HRESULT ddRVal;
        public IntPtr UpdateOverlay;
    }
}
