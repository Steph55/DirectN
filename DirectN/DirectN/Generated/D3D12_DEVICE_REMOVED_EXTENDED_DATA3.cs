﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(14372,9)
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_DEVICE_REMOVED_EXTENDED_DATA3
    {
        public HRESULT DeviceRemovedReason;
        public D3D12_DRED_AUTO_BREADCRUMBS_OUTPUT1 AutoBreadcrumbsOutput;
        public D3D12_DRED_PAGE_FAULT_OUTPUT2 PageFaultOutput;
        public D3D12_DRED_DEVICE_STATE DeviceState;
    }
}
