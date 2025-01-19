using System.Runtime.InteropServices;
using Pathfinding;
using UnityEngine;

[StructLayout(LayoutKind.Auto, Size = 8)]
public delegate Vector3[] GetNextTargetDelegate(Path p, Vector3 currentPosition);
