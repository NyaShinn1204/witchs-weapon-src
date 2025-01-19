using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Core.Internal
{
	public class AVFileController : IAVFileController
	{
		private readonly IAVCommandRunner commandRunner;

		public AVFileController(IAVCommandRunner commandRunner)
		{
		}

		public virtual Task<FileState> SaveAsync(FileState state, Stream dataStream, string sessionToken, IProgress<AVUploadProgressEventArgs> progress, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public Task DeleteAsync(FileState state, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		internal static Task<Tuple<HttpStatusCode, IDictionary<string, object>>> GetFileToken(FileState fileState, CancellationToken cancellationToken)
		{
			return null;
		}

		public Task<FileState> GetAsync(string objectId, string sessionToken, CancellationToken cancellationToken)
		{
			return null;
		}

		internal static string GetUniqueName(FileState fileState)
		{
			return null;
		}

		internal static string Random(int length)
		{
			return null;
		}

		internal static double CalcProgress(double already, double total)
		{
			return 0.0;
		}
	}
}
