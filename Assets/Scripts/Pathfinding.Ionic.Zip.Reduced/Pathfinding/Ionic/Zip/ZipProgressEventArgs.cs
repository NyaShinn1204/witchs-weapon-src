using System;

namespace Pathfinding.Ionic.Zip
{
	public class ZipProgressEventArgs : EventArgs
	{
		private int _entriesTotal;

		private bool _cancel;

		private ZipEntry _latestEntry;

		private ZipProgressEventType _flavor;

		private string _archiveName;

		private long _bytesTransferred;

		private long _totalBytesToTransfer;

		public int EntriesTotal
		{
			set
			{
			}
		}

		public ZipEntry CurrentEntry
		{
			set
			{
			}
		}

		public bool Cancel
		{
			get
			{
				return false;
			}
		}

		public ZipProgressEventType EventType
		{
			set
			{
			}
		}

		public string ArchiveName
		{
			set
			{
			}
		}

		public long BytesTransferred
		{
			set
			{
			}
		}

		public long TotalBytesToTransfer
		{
			set
			{
			}
		}

		internal ZipProgressEventArgs()
		{
		}

		internal ZipProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		{
		}
	}
}
