using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using LeanCloud.Storage.Internal;

namespace LeanCloud.Core.Internal
{
	public class AVCommandRunner : IAVCommandRunner
	{
		private readonly IHttpClient httpClient;

		private readonly IInstallationIdController installationIdController;

		private const string revocableSessionTokenTrueValue = "1";

		public AVCommandRunner(IHttpClient httpClient, IInstallationIdController installationIdController)
		{
		}

		public Task<Tuple<HttpStatusCode, IDictionary<string, object>>> RunCommandAsync(AVCommand command, IProgress<AVUploadProgressEventArgs> uploadProgress = null, IProgress<AVDownloadProgressEventArgs> downloadProgress = null, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		private Task<AVCommand> PrepareCommand(AVCommand command)
		{
			return null;
		}
	}
}
