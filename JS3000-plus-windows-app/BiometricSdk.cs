using System;
using System.Runtime.InteropServices;

namespace JS3000_plus_windows_app;

internal static class BiometricSdk
{
    internal const int Success = 1;
    internal const int ProtocolTcp = 0;
    internal const int ProtocolUdp = 1;

    [DllImport("FKAttend.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
    internal static extern int FK_ConnectNet(
        int machineNumber,
        string ipAddress,
        int port,
        int timeout,
        int protocolType,
        int networkPassword,
        int license);

    [DllImport("FKAttend.dll", CallingConvention = CallingConvention.StdCall)]
    internal static extern void FK_DisConnect(int handle);

    [DllImport("FKAttend.dll", CallingConvention = CallingConvention.StdCall)]
    internal static extern int FK_GetDeviceTime(int handle, ref DateTime deviceTime);

    [DllImport("FKAttend.dll", CallingConvention = CallingConvention.StdCall)]
    internal static extern int FK_GetLastError(int handle);
}
