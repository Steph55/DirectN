﻿// c:\program files (x86)\windows kits\10\include\10.0.17763.0\shared\mmreg.h(2613,9)
using System;
using System.Runtime.InteropServices;
using WAVEFORMATEX = DirectN.tWAVEFORMATEX;

namespace DirectN
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct adpcmwaveformat_tag
    {
        public WAVEFORMATEX wfx;
        public ushort wSamplesPerBlock;
        public ushort wNumCoef;
        public ADPCMCOEFSET [] aCoef;
    }
}
