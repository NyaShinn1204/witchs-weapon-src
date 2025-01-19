using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Core.Internal
{
	internal class QCloudCosFileController : AVFileController
	{
		private object mutex;

		private FileState fileState;

		private Stream data;

		private string bucket;

		private string token;

		private string uploadUrl;

		private bool done;

		private long sliceSize;

		public QCloudCosFileController(IAVCommandRunner commandRunner)
			: base(null)
		{
		}

		public new Task<FileState> SaveAsync(FileState state, Stream dataStream, string sessionToken, IProgress<AVUploadProgressEventArgs> progress, CancellationToken cancellationToken)
		{
			return null;
		}

		private Task<FileState> UploadSlice(string sessionId, long offset, Stream dataStream, IProgress<AVUploadProgressEventArgs> progress, CancellationToken cancellationToken)
		{
			return null;
		}

		private Task<Tuple<HttpStatusCode, IDictionary<string, object>>> ExcuteUpload(string sessionId, long offset, byte[] sliceFile, CancellationToken cancellationToken)
		{
			return null;
		}

		private Task<Tuple<HttpStatusCode, IDictionary<string, object>>> FileSlice(CancellationToken cancellationToken)
		{
			return null;
		}

		public static string HexStringFromBytes(byte[] bytes)
		{
			return null;
		}

		public static string SHA1HashStringForUTF8String(string s)
		{
			return null;
		}

		private Task<Tuple<HttpStatusCode, IDictionary<string, object>>> PostToQCloud(Dictionary<string, object> body, byte[] sliceFile, CancellationToken cancellationToken)
		{
			return null;
		}

		public static Stream HttpUploadFile(byte[] file, string fileName, out string contentType, out long contentLength, IDictionary<string, object> nvc)
		{
			contentType = null;
			contentLength = default(long);
			return null;
		}

		public static byte[] StringToAscii(string s)
		{
			return null;
		}

		private byte[] GetNextBinary(long completed, Stream dataStream)
		{
			return null;
		}
	}
}
