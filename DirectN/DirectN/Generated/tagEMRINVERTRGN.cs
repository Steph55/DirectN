﻿// c:\program files (x86)\windows kits\10\include\10.0.22000.0\um\wingdi.h(5799,9)
using System;
using System.Runtime.InteropServices;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential)]
    public partial struct tagEMRINVERTRGN
    {
        public tagEMR emr;
        public _RECTL rclBounds;
        public uint cbRgnData;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 1)] 
        public byte[] RgnData;
    }
}
