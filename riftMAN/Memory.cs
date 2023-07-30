using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riftMAN
{
    internal static class Memory
    {
        public static byte[] ReadMemory(IntPtr procHandle, ulong address, uint size)
        {
            byte[] array = new byte[size];
            
            if (!WindowsAPI.ReadProcessMemory(procHandle, (nint)address, array, size, out nuint dontcare))
            {
                throw new IOException($"Unable to read memory. (Error code: 0x{WindowsAPI.GetLastError():X})");
            }
            else { return array; }
        }

        public static void WriteMemory(IntPtr procHandle, ulong address, byte[] bytes)
        {
            if (!WindowsAPI.WriteProcessMemory(procHandle, (nint)address, bytes, (nuint)bytes.Length, out nuint dontcare))
            {
                throw new IOException($"Unable to write memory. (Error code: 0x{WindowsAPI.GetLastError():X})");
            }
        }

        public static byte[] ReadGameMemory(ulong address, uint size)
        {
            return ReadMemory(RiftMANState.Instance.ProcHandle, address, size);
        }

        public static void WriteGameMemory(ulong address, byte[] bytes)
        {
            WriteMemory(RiftMANState.Instance.ProcHandle, address, bytes);
        }
    }
}
