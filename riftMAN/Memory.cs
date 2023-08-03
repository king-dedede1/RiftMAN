using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace riftMAN;

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

    public static int ReadInt(ulong baseaddr, params ulong[] offsets)
    {
        return BitConverter.ToInt32(Read(4, baseaddr, offsets), 0);
    }

    public static void WriteInt(int value, ulong baseaddr, params ulong[] offsets)
    {
        Write(BitConverter.GetBytes(value), baseaddr, offsets);
    }

    public static byte ReadByte(ulong baseaddr, params ulong[] offsets)
    {
        return Read(1, baseaddr, offsets)[0];
    }

    public static void WriteByte(byte value, ulong baseaddr, params ulong[] offsets)
    {
        Write(new byte[] { value }, baseaddr, offsets);
    }

    public static float ReadFloat(ulong baseaddr, params ulong[] offsets)
    {
        return BitConverter.ToSingle(Read(4, baseaddr, offsets), 0);
    }

    public static void WriteFloat(float value, ulong baseaddr, params ulong[] offsets)
    {
        Write(BitConverter.GetBytes(value), baseaddr, offsets);
    }

    public static double ReadDouble(ulong baseaddr, params ulong[] offsets)
    {
        return BitConverter.ToDouble(Read(8, baseaddr, offsets), 0);
    }

    public static void WriteDouble(double value, ulong baseaddr, params ulong[] offsets)
    {
        Write(BitConverter.GetBytes(value), baseaddr, offsets);
    }

    // Gets the address at the end of the given pointer path
    public static ulong TraversePointerPath(ulong baseaddr, params ulong[] offsets)
    {
        ulong ptr = baseaddr;
        for (int i = 0; i < offsets.Length; i++)
        {
            ptr = deref(ptr);
            if (ptr == 0)
            {
                throw new Exception("Encountered a null pointer on the pointer path.");
            }
            ptr += offsets[i];
        }
        return ptr;

    }

    private static byte[] readmemory(ulong address, uint size)
    {
        byte[] array = new byte[size];

        if (!WindowsAPI.ReadProcessMemory(RiftMANState.Instance.GameProcess.Handle, (nint)address, array, size, out nuint dontcare))
        {
            throw new IOException($"Unable to read memory. (Error code: 0x{WindowsAPI.GetLastError():X}, size = {size}, address = {address:X}, bytes written = {dontcare})");
        }
        else { return array; }
    }

    private static void writememory(ulong address, byte[] bytes)
    {
        if (!WindowsAPI.WriteProcessMemory(RiftMANState.Instance.GameProcess.Handle, (nint)address, bytes, (nuint)bytes.Length, out _))
        {
            throw new IOException($"Unable to write memory. (Error code: 0x{WindowsAPI.GetLastError():X})");
        }
    }

    private static ulong deref(ulong address)
    {
        if (address == 0)
        {
            throw new ArgumentException("ERROR: Tried to deref a nullptr");
        }
        return BitConverter.ToUInt64(readmemory(address, 8));
    }
}
