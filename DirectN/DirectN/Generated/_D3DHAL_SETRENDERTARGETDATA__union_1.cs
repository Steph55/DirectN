﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3dhal.h(662,5)
using System;
using System.Runtime.InteropServices;
using LPDDRAWI_DDRAWSURFACE_LCL = DirectN._DDRAWI_DDRAWSURFACE_LCL;
using LPDIRECTDRAWSURFACE = DirectN.IDirectDrawSurface;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct _D3DHAL_SETRENDERTARGETDATA__union_1
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2136)]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public byte[] __bits;
        public IntPtr lpDDSZ { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[2136]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
        public IntPtr lpDDSZLcl { get => InteropRuntime.Get<IntPtr>(__bits, 0, IntPtr.Size); set { if (__bits == null) __bits = new byte[2136]; InteropRuntime.Set<IntPtr>(value, __bits, 0, IntPtr.Size); } }
    }
}
