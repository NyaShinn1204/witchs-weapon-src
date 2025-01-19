using System;

namespace LeanCloud.Realtime
{
	public class AVIMMessagePatchEventArgs : EventArgs
	{
		public IAVIMMessage Message { get; internal set; }

		public AVIMMessagePatchEventArgs(IAVIMMessage message)
		{
		}
	}
}
