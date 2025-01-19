using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Core.Internal
{
	public interface IAVCommandRunner
	{
		Task<Tuple<HttpStatusCode, IDictionary<string, object>>> RunCommandAsync(AVCommand command, IProgress<AVUploadProgressEventArgs> uploadProgress = null, IProgress<AVDownloadProgressEventArgs> downloadProgress = null, CancellationToken cancellationToken = default(CancellationToken));
	}
}
