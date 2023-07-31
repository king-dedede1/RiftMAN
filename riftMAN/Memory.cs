using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riftMAN
{
    internal static class Memory
    {
        public static void Write(byte[] bytes, ulong baseaddr, params ulong[] offsets)
        {
            if (offsets == null || offsets.Length == 0)
            {
                // Writing to a base address. Not a pointer path.
                writememory(baseaddr, bytes);
            }
            else
            {
                // Writing to a pointer path.
                writememory(TraversePointerPath(baseaddr, offsets), bytes);
            }
        }

        public static byte[] Read(uint size, ulong baseaddr, params ulong[] offsets)
        {
            if (offsets == null || offsets.Length == 0)
            {
                return readmemory(baseaddr, size);
            }
            else
            {
                return readmemory(TraversePointerPath(baseaddr, offsets), size);
            }
        }

        // Gets the address at the end of the given pointer path
        // TODO this does not have any error handling if it encounters a null pointer
        public static ulong TraversePointerPath(ulong baseaddr, params ulong[] offsets)
        {
            ulong ptr = baseaddr;
            for (int i = 0; i < offsets.Length; i++)
            {
                ptr = deref(ptr);
                ptr += offsets[i];
            }
            return ptr;

        }

        private static byte[] readmemory(ulong address, uint size)
        {
            byte[] array = new byte[size];

            if (!WindowsAPI.ReadProcessMemory(RiftMANState.Instance.ProcHandle, (nint)address, array, size, out nuint dontcare))
            {
                throw new IOException($"Unable to read memory. (Error code: 0x{WindowsAPI.GetLastError():X})");
            }
            else { return array; }
        }

        private static void writememory(ulong address, byte[] bytes)
        {
            if (!WindowsAPI.WriteProcessMemory(RiftMANState.Instance.ProcHandle, (nint)address, bytes, (nuint)bytes.Length, out nuint dontcare))
            {
                throw new IOException($"Unable to write memory. (Error code: 0x{WindowsAPI.GetLastError():X})");
            }
        }

        private static ulong deref(ulong address)
        {
            return BitConverter.ToUInt64(readmemory(address, 8));
        }
    }
}
