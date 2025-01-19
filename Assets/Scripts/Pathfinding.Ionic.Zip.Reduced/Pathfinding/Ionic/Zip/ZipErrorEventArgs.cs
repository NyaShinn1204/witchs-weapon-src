using System;

namespace Pathfinding.Ionic.Zip
{
	public class ZipErrorEventArgs : ZipProgressEventArgs
	{
		private Exception _exc;

		private ZipErrorEventArgs()
		{
		}

		internal static ZipErrorEventArgs Saving(string archiveName, ZipEntry entry, Exception exception)
		{
			return null;
		}
	}
}
