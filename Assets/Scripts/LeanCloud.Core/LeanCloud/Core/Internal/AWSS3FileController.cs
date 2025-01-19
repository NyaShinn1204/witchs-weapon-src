using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Core.Internal
{
	internal class AWSS3FileController : AVFileController
	{
		private object mutex;

		public AWSS3FileController(IAVCommandRunner commandRunner)
			: base(null)
		{
		}

		public override Task<FileState> SaveAsync(FileState state, Stream dataStream, string sessionToken, IProgress<AVUploadProgressEventArgs> progress, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		internal Task<FileState> PutFile(FileState state, string uploadUrl, Stream dataStream)
		{
			return null;
		}
	}
}
