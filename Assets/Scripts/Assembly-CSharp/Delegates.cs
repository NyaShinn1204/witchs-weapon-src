using System.Runtime.InteropServices;

public class Delegates
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void SouceDelegate(CharacterBase source);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void VoidDelegate();
}
