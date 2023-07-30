using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace riftMAN
{

    // Methods to access the windows API for reading/writing memory to other applications.
    public static partial class WindowsAPI
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer,
        UIntPtr nSize, out UIntPtr lpNumberOfBytesRead);

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        public static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer,
        UIntPtr nSize, out UIntPtr lpNumberOfBytesWritten);

        [DllImport("kernel32.dll")]
        [return: MarshalAs(UnmanagedType.U4)]
        public static extern uint GetLastError();
    }
}
