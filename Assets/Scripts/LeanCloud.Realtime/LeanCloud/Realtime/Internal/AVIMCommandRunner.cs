using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LeanCloud.Realtime.Internal
{
	public class AVIMCommandRunner : IAVIMCommandRunner
	{
		private readonly IWebSocketClient webSocketClient;

		public AVIMCommandRunner(IWebSocketClient webSocketClient)
		{
		}

		public void RunCommand(AVIMCommand command)
		{
		}

		public Task<Tuple<int, IDictionary<string, object>>> RunCommandAsync(AVIMCommand command, CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}
	}
}
