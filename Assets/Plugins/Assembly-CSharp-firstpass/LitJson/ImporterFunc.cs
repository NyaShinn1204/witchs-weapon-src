using System.Runtime.InteropServices;

namespace LitJson
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	internal delegate object ImporterFunc(object input);
	public delegate TValue ImporterFunc<TJson, TValue>(TJson input);
}
