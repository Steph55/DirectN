﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\um\d3d11.h(3390,5)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D11_SHADER_RESOURCE_VIEW_DESC__union_0
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 16)]
        public byte[] __bits;
        public D3D11_BUFFER_SRV Buffer => InteropRuntime.Get<D3D11_BUFFER_SRV>(__bits, 0, 64);
        public D3D11_TEX1D_SRV Texture1D => InteropRuntime.Get<D3D11_TEX1D_SRV>(__bits, 0, 64);
        public D3D11_TEX1D_ARRAY_SRV Texture1DArray => InteropRuntime.Get<D3D11_TEX1D_ARRAY_SRV>(__bits, 0, 128);
        public D3D11_TEX2D_SRV Texture2D => InteropRuntime.Get<D3D11_TEX2D_SRV>(__bits, 0, 64);
        public D3D11_TEX2D_ARRAY_SRV Texture2DArray => InteropRuntime.Get<D3D11_TEX2D_ARRAY_SRV>(__bits, 0, 128);
        public D3D11_TEX2DMS_SRV Texture2DMS => InteropRuntime.Get<D3D11_TEX2DMS_SRV>(__bits, 0, 32);
        public D3D11_TEX2DMS_ARRAY_SRV Texture2DMSArray => InteropRuntime.Get<D3D11_TEX2DMS_ARRAY_SRV>(__bits, 0, 64);
        public D3D11_TEX3D_SRV Texture3D => InteropRuntime.Get<D3D11_TEX3D_SRV>(__bits, 0, 64);
        public D3D11_TEXCUBE_SRV TextureCube => InteropRuntime.Get<D3D11_TEXCUBE_SRV>(__bits, 0, 64);
        public D3D11_TEXCUBE_ARRAY_SRV TextureCubeArray => InteropRuntime.Get<D3D11_TEXCUBE_ARRAY_SRV>(__bits, 0, 128);
        public D3D11_BUFFEREX_SRV BufferEx => InteropRuntime.Get<D3D11_BUFFEREX_SRV>(__bits, 0, 96);
    }
}
