using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Auto, Size = 8)]
public delegate void UpdateProgressDelegate(string message, float progress);
