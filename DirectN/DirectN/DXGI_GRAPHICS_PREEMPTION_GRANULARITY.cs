﻿namespace DirectN
{
    public enum DXGI_GRAPHICS_PREEMPTION_GRANULARITY
    {
        DXGI_GRAPHICS_PREEMPTION_DMA_BUFFER_BOUNDARY = 0,
        DXGI_GRAPHICS_PREEMPTION_PRIMITIVE_BOUNDARY = 1,
        DXGI_GRAPHICS_PREEMPTION_TRIANGLE_BOUNDARY = 2,
        DXGI_GRAPHICS_PREEMPTION_PIXEL_BOUNDARY = 3,
        DXGI_GRAPHICS_PREEMPTION_INSTRUCTION_BOUNDARY = 4
    }
}
