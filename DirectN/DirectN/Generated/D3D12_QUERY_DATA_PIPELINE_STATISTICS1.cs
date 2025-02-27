﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\d3d12.h(4006,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct D3D12_QUERY_DATA_PIPELINE_STATISTICS1
    {
        public ulong IAVertices;
        public ulong IAPrimitives;
        public ulong VSInvocations;
        public ulong GSInvocations;
        public ulong GSPrimitives;
        public ulong CInvocations;
        public ulong CPrimitives;
        public ulong PSInvocations;
        public ulong HSInvocations;
        public ulong DSInvocations;
        public ulong CSInvocations;
        public ulong ASInvocations;
        public ulong MSInvocations;
        public ulong MSPrimitives;
    }
}
