using System.Runtime.InteropServices;
using Pathfinding.Ionic.Zlib;

namespace Pathfinding.Ionic.Zip
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate CompressionLevel SetCompressionCallback(string localFileName, string fileNameInArchive);
}
