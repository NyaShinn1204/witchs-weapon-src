using System.Runtime.InteropServices;

namespace LitJson
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate IJsonWrapper WrapperFactory();
}
