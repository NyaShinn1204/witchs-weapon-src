namespace Pathfinding.Ionic.Zip
{
	public class AddProgressEventArgs : ZipProgressEventArgs
	{
		private AddProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		{
		}

		internal static AddProgressEventArgs AfterEntry(string archiveName, ZipEntry entry, int entriesTotal)
		{
			return null;
		}
	}
}
