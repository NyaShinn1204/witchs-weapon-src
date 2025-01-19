using System.Runtime.InteropServices;

namespace Spine.Unity
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void MeshGeneratorDelegate(MeshGenerator meshGenerator);
}
