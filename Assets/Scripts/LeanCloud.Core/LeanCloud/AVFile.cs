using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using LeanCloud.Core.Internal;
using LeanCloud.Storage.Internal;

namespace LeanCloud
{
	public class AVFile : IJsonConvertible
	{
		internal static int objectCounter;

		internal static readonly object Mutex;

		private FileState state;

		private readonly Stream dataStream;

		private readonly TaskQueue taskQueue;

		private static readonly Dictionary<string, string> MIMETypesDictionary;

		private object mutex;

		private bool isExternal;

		public bool IsDirty
		{
			get
			{
				return false;
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
		}

		public string MimeType
		{
			get
			{
				return null;
			}
		}

		public Uri Url
		{
			get
			{
				return null;
			}
		}

		internal static IAVFileController FileController
		{
			get
			{
				return null;
			}
		}

		public string ObjectId
		{
			get
			{
				return null;
			}
		}

		public IDictionary<string, object> MetaData
		{
			get
			{
				return null;
			}
		}

		public bool IsExternal
		{
			get
			{
				return false;
			}
		}

		public AVFile(string name, Stream data, string mimeType = null, IDictionary<string, object> metaData = null)
		{
		}

		public AVFile(string name, byte[] data, string mimeType = null)
		{
		}

		public AVFile(string name, Stream data, string mimeType = null)
		{
		}

		public AVFile(string name, byte[] data)
		{
		}

		public AVFile(string name, byte[] data, IDictionary<string, object> metaData)
		{
		}

		public AVFile(string name, Stream data, IDictionary<string, object> metaData)
		{
		}

		public AVFile(string name, Stream data)
		{
		}

		public AVFile(string name, Uri uri, string mimeType = null, IDictionary<string, object> metaData = null)
		{
		}

		public AVFile(string name, string url, string mimeType = null, IDictionary<string, object> metaData = null)
		{
		}

		public AVFile(string name, string url, IDictionary<string, object> metaData)
		{
		}

		public AVFile(string name, Uri uri, string mimeType = null)
		{
		}

		public AVFile(string name, Uri uri)
		{
		}

		public AVFile(string name, string url)
		{
		}

		internal AVFile(FileState filestate)
		{
		}

		internal AVFile(string objectId)
		{
		}

		IDictionary<string, object> IJsonConvertible.ToJSON()
		{
			return null;
		}

		public Task SaveAsync()
		{
			return null;
		}

		public Task SaveAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		public Task SaveAsync(IProgress<AVUploadProgressEventArgs> progress)
		{
			return null;
		}

		public Task SaveAsync(IProgress<AVUploadProgressEventArgs> progress, CancellationToken cancellationToken)
		{
			return null;
		}

		internal Task SaveExternal()
		{
			return null;
		}

		static AVFile()
		{
		}

		internal static string GetMIMEType(string fileName)
		{
			return null;
		}

		public static Task<AVFile> GetFileWithObjectIdAsync(string objectId, CancellationToken cancellationToken)
		{
			return null;
		}

		public static AVFile CreateWithoutData(string objectId)
		{
			return null;
		}

		public static AVFile CreateWithState(FileState state)
		{
			return null;
		}

		public static AVFile CreateWithData(string objectId, string name, string url, IDictionary<string, object> metaData)
		{
			return null;
		}

		public static Task<AVFile> GetFileWithObjectIdAsync(string objectId)
		{
			return null;
		}

		internal void MergeFromJSON(IDictionary<string, object> jsonData)
		{
		}

		public Task DeleteAsync()
		{
			return null;
		}

		internal Task DeleteAsync(CancellationToken cancellationToken)
		{
			return null;
		}

		internal Task DeleteAsync(Task toAwait, CancellationToken cancellationToken)
		{
			return null;
		}
	}
}
