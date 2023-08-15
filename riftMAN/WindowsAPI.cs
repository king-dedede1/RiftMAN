using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace riftMAN;

// Methods to access the windows API for reading/writing memory to other applications.
internal static partial class WindowsAPI
{
    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool ReadProcessMemory(nint hProcess, nint lpBaseAddress, [Out] byte[] lpBuffer,
    nuint nSize, out nuint lpNumberOfBytesRead);

    [DllImport("kernel32.dll", SetLastError = true)]
    [return: MarshalAs(UnmanagedType.Bool)]
    public static extern bool WriteProcessMemory(nint hProcess, nint lpBaseAddress, byte[] lpBuffer,
    nuint nSize, out nuint lpNumberOfBytesWritten);

    [DllImport("kernel32.dll")]
    [return: MarshalAs(UnmanagedType.U4)]
    public static extern uint GetLastError();

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern nint VirtualAllocEx(nint hProcess, nint lpAddress, nuint dwSize, AllocationType flAllocationType, int flProtect);

    [Flags]
    public enum AllocationType : int
    {
        MEM_COMMIT = 0X00001000,
        MEM_RESERVE = 0X00002000,
        MEM_RESET = 0X00080000,
        MEM_RESET_UNDO = 0X10000000,
        MEM_LARGE_PAGES = 0X20000000,
        MEM_PHYSICAL = 0X00400000,
        MEM_TOP_DOWN = 0X00100000
    }
}
