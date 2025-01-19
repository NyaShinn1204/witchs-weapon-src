using System.Runtime.InteropServices;

[StructLayout(LayoutKind.Sequential, Size = 24)]
public struct MetaValue
{
	public float value;

	public string valueString;

	public bool isValue;
}
