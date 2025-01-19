using System.Runtime.InteropServices;

namespace LitJson
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	internal delegate void ExporterFunc(object obj, JsonWriter writer);
	public delegate void ExporterFunc<T>(T obj, JsonWriter writer);
}
