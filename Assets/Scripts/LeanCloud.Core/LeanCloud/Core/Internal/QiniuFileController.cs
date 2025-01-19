using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Core.Internal
{
	internal class QiniuFileController : AVFileController
	{
		private static int BLOCKSIZE;

		private const int blockMashk = 4194303;

		private const int blockBits = 22;

		internal static string UP_HOST;

		private object mutex;

		private int CalcBlockCount(long fsize)
		{
			return 0;
		}

		public QiniuFileController(IAVCommandRunner commandRunner)
			: base(null)
		{
		}

		public override Task<FileState> SaveAsync(FileState state, Stream dataStream, string sessionToken, IProgress<AVUploadProgressEventArgs> progress, CancellationToken cancellationToken)
		{
			return null;
		}

		private Task UploadNextChunk(FileState state, Stream dataStream, string context, long offset, IProgress<AVUploadProgressEventArgs> progress)
		{
			return null;
		}

		private byte[] GetChunkBinary(long completed, Stream dataStream)
		{
			return null;
		}

		internal new string GetUniqueName(FileState state)
		{
			return null;
		}

		internal Task<Tuple<HttpStatusCode, IDictionary<string, object>>> GetQiniuToken(FileState state, CancellationToken cancellationToken)
		{
			return null;
		}

		private IList<KeyValuePair<string, string>> GetQiniuRequestHeaders(FileState state)
		{
			return null;
		}

		private Task<Tuple<HttpStatusCode, string>> MakeBlock(FileState state, byte[] firstChunkBinary, long blcokSize = 4194304L)
		{
			return null;
		}

		private Task<Tuple<HttpStatusCode, string>> PutChunk(FileState state, byte[] chunkBinary, string LastChunkctx, long currentChunkOffsetInBlock)
		{
			return null;
		}

		internal Task<Tuple<HttpStatusCode, string>> QiniuMakeFile(FileState state, Stream dataStream, string upToken, string key, long fsize, string[] ctxes, CancellationToken cancellationToken)
		{
			return null;
		}

		internal void MergeFromJSON(FileState state, IDictionary<string, object> jsonData)
		{
		}

		private string FetchBucketId(string url)
		{
			return null;
		}

		public static byte[] StringToAscii(string s)
		{
			return null;
		}

		public static string ToBase64URLSafe(string str)
		{
			return null;
		}

		public static string Encode(byte[] bs)
		{
			return null;
		}

		public static string Encode(string text)
		{
			return null;
		}

		internal static string GetMD5Code(Stream data)
		{
			return null;
		}

		internal IDictionary<string, object> GetMetaData(FileState state, Stream data)
		{
			return null;
		}

		internal void MergeDic(IDictionary<string, object> dic, string key, object value)
		{
		}
	}
}
