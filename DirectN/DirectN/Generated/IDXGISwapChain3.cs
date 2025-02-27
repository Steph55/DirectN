﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\shared\dxgi1_4.h(115,5)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [ComImport, Guid("94d99bdb-f1f8-4ab0-b236-7da0170edab1"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public partial interface IDXGISwapChain3 : IDXGISwapChain2
    {
        // IDXGIObject
        [PreserveSig]
        new HRESULT SetPrivateData(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Name, /* [in] */ uint DataSize, /* [annotation][in] _In_reads_bytes_(DataSize) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT SetPrivateDataInterface(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Name, /* optional(IUnknown) */ IntPtr pUnknown);
        
        [PreserveSig]
        new HRESULT GetPrivateData(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid Name, /* [annotation][out][in] _Inout_ */ ref uint pDataSize, /* [annotation][out] _Out_writes_bytes_(*pDataSize) */ IntPtr pData);
        
        [PreserveSig]
        new HRESULT GetParent(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][retval][out] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppParent);
        
        // IDXGIDeviceSubObject
        [PreserveSig]
        new HRESULT GetDevice(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][retval][out] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppDevice);
        
        // IDXGISwapChain
        [PreserveSig]
        new HRESULT Present(/* [in] */ uint SyncInterval, /* [in] */ uint Flags);
        
        [PreserveSig]
        new HRESULT GetBuffer(/* [in] */ uint Buffer, /* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid riid, /* [annotation][out][in] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppSurface);
        
        [PreserveSig]
        new HRESULT SetFullscreenState(/* [in] */ bool Fullscreen, /* [annotation][in] _In_opt_ */ IDXGIOutput pTarget);
        
        [PreserveSig]
        new HRESULT GetFullscreenState(/* optional(BOOL) */ IntPtr pFullscreen, /* [annotation][out] _COM_Outptr_opt_result_maybenull_ */ out IDXGIOutput ppTarget);
        
        [PreserveSig]
        new HRESULT GetDesc(/* [annotation][out] _Out_ */ out DXGI_SWAP_CHAIN_DESC pDesc);
        
        [PreserveSig]
        new HRESULT ResizeBuffers(/* [in] */ uint BufferCount, /* [in] */ uint Width, /* [in] */ uint Height, /* [in] */ DXGI_FORMAT NewFormat, /* [in] */ uint SwapChainFlags);
        
        [PreserveSig]
        new HRESULT ResizeTarget(/* [annotation][in] _In_ */ ref DXGI_MODE_DESC pNewTargetParameters);
        
        [PreserveSig]
        new HRESULT GetContainingOutput(/* [annotation][out] _COM_Outptr_ */ out IDXGIOutput ppOutput);
        
        [PreserveSig]
        new HRESULT GetFrameStatistics(/* [annotation][out] _Out_ */ out DXGI_FRAME_STATISTICS pStats);
        
        [PreserveSig]
        new HRESULT GetLastPresentCount(/* [annotation][out] _Out_ */ out uint pLastPresentCount);
        
        // IDXGISwapChain1
        [PreserveSig]
        new HRESULT GetDesc1(/* [annotation][out] _Out_ */ out DXGI_SWAP_CHAIN_DESC1 pDesc);
        
        [PreserveSig]
        new HRESULT GetFullscreenDesc(/* [annotation][out] _Out_ */ out DXGI_SWAP_CHAIN_FULLSCREEN_DESC pDesc);
        
        [PreserveSig]
        new HRESULT GetHwnd(/* [annotation][out] _Out_ */ out IntPtr pHwnd);
        
        [PreserveSig]
        new HRESULT GetCoreWindow(/* [annotation][in] _In_ */ [MarshalAs(UnmanagedType.LPStruct)] Guid refiid, /* [annotation][out] _COM_Outptr_ */ [MarshalAs(UnmanagedType.IUnknown)] out object ppUnk);
        
        [PreserveSig]
        new HRESULT Present1(/* [in] */ uint SyncInterval, /* [in] */ uint PresentFlags, /* [annotation][in] _In_ */ ref DXGI_PRESENT_PARAMETERS pPresentParameters);
        
        [PreserveSig]
        new bool IsTemporaryMonoSupported();
        
        [PreserveSig]
        new HRESULT GetRestrictToOutput(/* [annotation][out] _Out_ */ out IDXGIOutput ppRestrictToOutput);
        
        [PreserveSig]
        new HRESULT SetBackgroundColor(/* [annotation][in] _In_ */ ref _D3DCOLORVALUE pColor);
        
        [PreserveSig]
        new HRESULT GetBackgroundColor(/* [annotation][out] _Out_ */ out _D3DCOLORVALUE pColor);
        
        [PreserveSig]
        new HRESULT SetRotation(/* [annotation][in] _In_ */ DXGI_MODE_ROTATION Rotation);
        
        [PreserveSig]
        new HRESULT GetRotation(/* [annotation][out] _Out_ */ out DXGI_MODE_ROTATION pRotation);
        
        // IDXGISwapChain2
        [PreserveSig]
        new HRESULT SetSourceSize(uint Width, uint Height);
        
        [PreserveSig]
        new HRESULT GetSourceSize(/* [annotation][out] _Out_ */ out uint pWidth, /* [annotation][out] _Out_ */ out uint pHeight);
        
        [PreserveSig]
        new HRESULT SetMaximumFrameLatency(uint MaxLatency);
        
        [PreserveSig]
        new HRESULT GetMaximumFrameLatency(/* [annotation][out] _Out_ */ out uint pMaxLatency);
        
        [PreserveSig]
        new IntPtr GetFrameLatencyWaitableObject();
        
        [PreserveSig]
        new HRESULT SetMatrixTransform(ref DXGI_MATRIX_3X2_F pMatrix);
        
        [PreserveSig]
        new HRESULT GetMatrixTransform(/* [annotation][out] _Out_ */ out DXGI_MATRIX_3X2_F pMatrix);
        
        // IDXGISwapChain3
        [PreserveSig]
        uint GetCurrentBackBufferIndex();
        
        [PreserveSig]
        HRESULT CheckColorSpaceSupport(/* [annotation][in] _In_ */ DXGI_COLOR_SPACE_TYPE ColorSpace, /* [annotation][out] _Out_ */ out uint pColorSpaceSupport);
        
        [PreserveSig]
        HRESULT SetColorSpace1(/* [annotation][in] _In_ */ DXGI_COLOR_SPACE_TYPE ColorSpace);
        
        [PreserveSig]
        HRESULT ResizeBuffers1(/* [annotation][in] _In_ */ int BufferCount, /* [annotation][in] _In_ */ uint Width, /* [annotation][in] _In_ */ uint Height, /* [annotation][in] _In_ */ DXGI_FORMAT Format, /* [annotation][in] _In_ */ uint SwapChainFlags, /* [annotation][in] _In_reads_(BufferCount) */ [MarshalAs(UnmanagedType.LPArray, SizeParamIndex = 0)] uint[] pCreationNodeMask, /* [annotation][in] _In_reads_(BufferCount) */ [MarshalAs(UnmanagedType.IUnknown)] object ppPresentQueue);
    }
}
