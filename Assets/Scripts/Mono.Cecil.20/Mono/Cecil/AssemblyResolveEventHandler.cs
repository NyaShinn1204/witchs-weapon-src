using System.Runtime.InteropServices;

namespace Mono.Cecil
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate AssemblyDefinition AssemblyResolveEventHandler(object sender, AssemblyNameReference reference);
}
