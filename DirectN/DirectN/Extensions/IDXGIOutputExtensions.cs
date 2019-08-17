﻿using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

#pragma warning disable CA2010 // Always consume the value returned by methods marked with PreserveSigAttribute

namespace DirectN
{
    public static class IDXGIOutputExtensions
    {
        public static DXGI_OUTPUT_DESC GetDesc(this ComObject<IDXGIOutput> output) => GetDesc(output?.Object);
        public static DXGI_OUTPUT_DESC GetDesc(this ComObject<IDXGIOutput1> output) => GetDesc(output?.Object);
        public static DXGI_OUTPUT_DESC GetDesc(this IDXGIOutput output)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            output.GetDesc(out var desc).ThrowOnError();
            return desc;
        }

        public static DXGI_GAMMA_CONTROL_CAPABILITIES? GetGammaControlCapabilities(this ComObject<IDXGIOutput> output) => GetGammaControlCapabilities(output?.Object);
        public static DXGI_GAMMA_CONTROL_CAPABILITIES? GetGammaControlCapabilities(this ComObject<IDXGIOutput1> output) => GetGammaControlCapabilities(output?.Object);
        public static DXGI_GAMMA_CONTROL_CAPABILITIES? GetGammaControlCapabilities(this IDXGIOutput output)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            if (output.GetGammaControlCapabilities(out var desc).IsError)
                return null;

            return desc;
        }

        public static DXGI_GAMMA_CONTROL? GetGammaControl(this ComObject<IDXGIOutput> output) => GetGammaControl(output?.Object);
        public static DXGI_GAMMA_CONTROL? GetGammaControl(this ComObject<IDXGIOutput1> output) => GetGammaControl(output?.Object);
        public static DXGI_GAMMA_CONTROL? GetGammaControl(this IDXGIOutput output)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            if (output.GetGammaControl(out var control).IsError)
                return null;

            return control;
        }

        public static DXGI_FRAME_STATISTICS? GetFrameStatistics(this ComObject<IDXGIOutput> output) => GetFrameStatistics(output?.Object);
        public static DXGI_FRAME_STATISTICS? GetFrameStatistics(this ComObject<IDXGIOutput1> output) => GetFrameStatistics(output?.Object);
        public static DXGI_FRAME_STATISTICS? GetFrameStatistics(this IDXGIOutput output)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            if (output.GetFrameStatistics(out var stats).IsError)
                return null;

            return stats;
        }

        public static IReadOnlyList<DXGI_MODE_DESC> GetDisplayModeList(this ComObject<IDXGIOutput> output, DXGI_FORMAT format, DXGI_ENUM_MODES modes) => GetDisplayModeList(output?.Object, format, modes);
        public static IReadOnlyList<DXGI_MODE_DESC> GetDisplayModeList(this ComObject<IDXGIOutput1> output, DXGI_FORMAT format, DXGI_ENUM_MODES modes) => GetDisplayModeList(output?.Object, format, modes);
        public static IReadOnlyList<DXGI_MODE_DESC> GetDisplayModeList(this IDXGIOutput output, DXGI_FORMAT format, DXGI_ENUM_MODES modes)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            // DXGI_FORMAT_R16G16B16A16_FLOAT
            // DXGI_FORMAT_R10G10B10A2_UNORM
            // DXGI_FORMAT_R8G8B8A8_UNORM
            // DXGI_FORMAT_R8G8B8A8_UNORM_SRGB
            // DXGI_FORMAT_B8G8R8A8_UNORM
            // DXGI_FORMAT_R10G10B10_XR_BIAS_A2_UNORM
            // DXGI_FORMAT_B8G8R8A8_UNORM_SRGB

            var list = new List<DXGI_MODE_DESC>();
            int num = 0;
            output.GetDisplayModeList(format, (uint)modes, ref num, null);
            if (num > 0)
            {
                var array = new DXGI_MODE_DESC[num];
                output.GetDisplayModeList(format, (uint)modes, ref num, array);
                list.AddRange(array);
            }
            return list;
        }

        public static IReadOnlyList<DXGI_MODE_DESC1> GetDisplayModeList1(this ComObject<IDXGIOutput1> output, DXGI_FORMAT format, DXGI_ENUM_MODES modes) => GetDisplayModeList1(output?.Object, format, modes);
        public static IReadOnlyList<DXGI_MODE_DESC1> GetDisplayModeList1(this IDXGIOutput1 output, DXGI_FORMAT format, DXGI_ENUM_MODES modes)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            var list = new List<DXGI_MODE_DESC1>();
            int num = 0;
            output.GetDisplayModeList(format, (uint)modes, ref num, null);
            if (num > 0)
            {
                var array = new DXGI_MODE_DESC1[num];
                output.GetDisplayModeList1(format, (uint)modes, ref num, array);
                list.AddRange(array);
            }
            return list;
        }

        public static DXGI_MODE_DESC? FindClosestMatchingMode(this ComObject<IDXGIOutput> output, DXGI_MODE_DESC modeToMatch, object concernedDevice) => FindClosestMatchingMode(output?.Object, modeToMatch, concernedDevice);
        public static DXGI_MODE_DESC? FindClosestMatchingMode(this ComObject<IDXGIOutput1> output, DXGI_MODE_DESC modeToMatch, object concernedDevice) => FindClosestMatchingMode(output?.Object, modeToMatch, concernedDevice);
        public static DXGI_MODE_DESC? FindClosestMatchingMode(this IDXGIOutput output, DXGI_MODE_DESC modeToMatch, object concernedDevice)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            if (output.FindClosestMatchingMode(ref modeToMatch, out var closest, ComObject.Unwrap(concernedDevice)).IsError)
                return null;

            return closest;
        }

        public static DXGI_MODE_DESC1? FindClosestMatchingMode1(this ComObject<IDXGIOutput1> output, DXGI_MODE_DESC1 modeToMatch, object concernedDevice) => FindClosestMatchingMode1(output?.Object, modeToMatch, concernedDevice);
        public static DXGI_MODE_DESC1? FindClosestMatchingMode1(this IDXGIOutput1 output, DXGI_MODE_DESC1 modeToMatch, object concernedDevice)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            if (output.FindClosestMatchingMode1(ref modeToMatch, out var closest, ComObject.Unwrap(concernedDevice)).IsError)
                return null;

            return closest;
        }

        public static ComObject<IDXGIOutputDuplication> DuplicateOutput(this ComObject<IDXGIOutput1> output, object device, bool throwOnError = true) => DuplicateOutput(output?.Object, device, throwOnError);
        public static ComObject<IDXGIOutputDuplication> DuplicateOutput(this IDXGIOutput1 output, object device, bool throwOnError = true)
        {
            if (output == null)
                throw new ArgumentNullException(nameof(output));

            if (device == null)
                throw new ArgumentNullException(nameof(device));

            device = ComObject.Unwrap(device);

            // this wonderful magic (mess) is because of a horrible bug in DXGI
            // https://social.msdn.microsoft.com/Forums/windowsdesktop/en-US/0c28328a-100a-4d6f-9a08-44a452d3ca6a/idxgioutputduplication-implementation-bug?forum=windowssdk#0c28328a-100a-4d6f-9a08-44a452d3ca6a
            output.DuplicateOutput(device, out var unk).ThrowOnError(throwOnError);
            if (unk == IntPtr.Zero)
                return null;

            // we copy the original COM's vtable to our process
            var vtablePtr = Marshal.ReadIntPtr(unk);
            var vtable = new IDXGIOutputDuplicationVTable();
            Marshal.PtrToStructure(vtablePtr, vtable);

            // patch QueryInterface so it works (route to our code)
            var wrapper = new Wrapper(unk);
            vtable.QueryInterfacePtr = Marshal.GetFunctionPointerForDelegate<QueryInterfaceFn>(wrapper.QueryInterface);
            using (var newVtablePtr = new ComMemory(Marshal.SizeOf<IDXGIOutputDuplicationVTable>()))
            {
                Marshal.StructureToPtr(vtable, newVtablePtr.Pointer, false);

                // create a new vtable for the CLR
                using (var newUnk = new ComMemory(IntPtr.Size))
                {
                    Marshal.WriteIntPtr(newUnk.Pointer, newVtablePtr.Pointer);

                    var dup = (IDXGIOutputDuplication)Marshal.GetObjectForIUnknown(newUnk.Pointer);
                    return new ComObject<IDXGIOutputDuplication>(dup);
                }
            }
        }

        private class Wrapper
        {
            private readonly IntPtr _pthis;

            public Wrapper(IntPtr pthis)
            {
                _pthis = pthis;
            }

            private static readonly Guid IID_IUnknown = new Guid("00000000-0000-0000-c000-000000000046");

#pragma warning disable IDE0060 // Remove unused parameter
            public int QueryInterface(IntPtr pThis, ref Guid riid, ref IntPtr ppInterface)
#pragma warning restore IDE0060 // Remove unused parameter
            {
                // note this works because IDXGIOutputDuplication maps IDXGIObject and IUnknown
                // we just return the original COM pointer
                if (riid == IID_IUnknown)
                {
                    ppInterface = _pthis;
                    return 0;
                }

                if (riid == typeof(IDXGIOutputDuplication).GUID)
                {
                    ppInterface = _pthis;
                    return 0;
                }

                // Note: debug shows we're queried for:
                // IAgileObject
                // IRpcOptions
                // IMarshal
                // INoMarshal
                // IInspectable
                // IProvideClassInfo
                // IManagedObject
                return (int)HRESULTS.E_NOINTERFACE;
            }
        }

        private delegate int QueryInterfaceFn(IntPtr pThis, ref Guid riid, ref IntPtr ppInterface);

        [StructLayout(LayoutKind.Sequential)]
        private class IDXGIOutputDuplicationVTable
        {
            // IUnknown
            public IntPtr QueryInterfacePtr;
        }
    }
}
