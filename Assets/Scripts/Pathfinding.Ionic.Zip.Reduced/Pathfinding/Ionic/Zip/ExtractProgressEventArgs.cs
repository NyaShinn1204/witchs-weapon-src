namespace Pathfinding.Ionic.Zip
{
	public class ExtractProgressEventArgs : ZipProgressEventArgs
	{
		private string _target;

		internal ExtractProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		{
		}

		internal ExtractProgressEventArgs()
		{
		}

		internal static ExtractProgressEventArgs BeforeExtractEntry(string archiveName, ZipEntry entry, string extractLocation)
		{
			return null;
		}

		internal static ExtractProgressEventArgs ExtractExisting(string archiveName, ZipEntry entry, string extractLocation)
		{
			return null;
		}

		internal static ExtractProgressEventArgs AfterExtractEntry(string archiveName, ZipEntry entry, string extractLocation)
		{
			return null;
		}

		internal static ExtractProgressEventArgs ByteUpdate(string archiveName, ZipEntry entry, long bytesWritten, long totalBytes)
		{
			return null;
		}
	}
}
