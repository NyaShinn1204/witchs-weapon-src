using System;
using System.Runtime.InteropServices;

[Serializable]
[StructLayout(LayoutKind.Sequential, Size = 16)]
public struct ShaderValue
{
	public string keyword;

	public float factor;
}
