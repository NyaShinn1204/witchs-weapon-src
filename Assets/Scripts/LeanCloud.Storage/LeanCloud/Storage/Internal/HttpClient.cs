using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine.Networking;

namespace LeanCloud.Storage.Internal
{
	public class HttpClient : IHttpClient
	{
		private static bool isCompiledByIL2CPP;

		public Task<Tuple<HttpStatusCode, string>> ExecuteAsync(HttpRequest httpRequest, IProgress<AVUploadProgressEventArgs> uploadProgress, IProgress<AVDownloadProgressEventArgs> downloadProgress, CancellationToken cancellationToken)
		{
			return null;
		}

		private static HttpStatusCode GetResponseStatusCode(UnityWebRequest request)
		{
			return default(HttpStatusCode);
		}

		private static UnityWebRequest GenerateRequest(HttpRequest request, byte[] bytes)
		{
			return null;
		}

		private static void WaitForWebRequest(UnityWebRequest request, Action<UnityWebRequest> action)
		{
		}
	}
}
