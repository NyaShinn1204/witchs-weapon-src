using System.Runtime.InteropServices;
using Pathfinding;

[StructLayout(LayoutKind.Auto, Size = 8)]
public delegate void OnScanStatus(Progress progress);
