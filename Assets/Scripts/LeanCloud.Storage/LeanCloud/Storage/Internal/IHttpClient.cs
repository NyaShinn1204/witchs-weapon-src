using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Storage.Internal
{
	public interface IHttpClient
	{
		Task<Tuple<HttpStatusCode, string>> ExecuteAsync(HttpRequest httpRequest, IProgress<AVUploadProgressEventArgs> uploadProgress, IProgress<AVDownloadProgressEventArgs> downloadProgress, CancellationToken cancellationToken);
	}
}
