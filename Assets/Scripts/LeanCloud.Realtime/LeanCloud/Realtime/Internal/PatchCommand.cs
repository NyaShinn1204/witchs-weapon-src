using System.Collections.Generic;

namespace LeanCloud.Realtime.Internal
{
	internal class PatchCommand : AVIMCommand
	{
		internal struct Patch
		{
			public string MessageId { get; set; }

			public string ConvId { get; set; }

			public string From { get; set; }

			public long MetaTimestamp { get; set; }

			public long PatchTimestamp { get; set; }

			public string PatchData { get; set; }

			public bool Recall { get; set; }

			public byte[] BinaryData { get; set; }

			public bool MentionAll { get; set; }

			public IEnumerable<string> MentionIds { get; set; }

			public IDictionary<string, object> Encode()
			{
				return null;
			}
		}

		public ICollection<Patch> Patches { get; set; }

		public PatchCommand()
		{
		}

		public PatchCommand(AVIMCommand source, ICollection<Patch> sourcePatchs)
		{
		}

		public IList<IDictionary<string, object>> EncodePatches()
		{
			return null;
		}

		public PatchCommand Recall(IAVIMMessage message)
		{
			return null;
		}

		public PatchCommand Modify(IAVIMMessage oldMessage, IAVIMMessage newMessage)
		{
			return null;
		}
	}
}
