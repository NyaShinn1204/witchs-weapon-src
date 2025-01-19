using System.IO;
using System.Runtime.InteropServices;

namespace Pathfinding.Ionic.Zip
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void WriteDelegate(string entryName, Stream stream);
}
