using System.Collections.Generic;

namespace LeanCloud.Realtime.Internal
{
	internal class ReadCommand : AVIMCommand
	{
		internal class ConvRead
		{
			internal string ConvId { get; set; }

			internal string MessageId { get; set; }

			internal long Timestamp { get; set; }

			public override bool Equals(object obj)
			{
				return false;
			}

			public override int GetHashCode()
			{
				return 0;
			}
		}

		public ReadCommand()
		{
		}

		public ReadCommand(AVIMCommand source)
		{
		}

		public ReadCommand ConvId(string convId)
		{
			return null;
		}

		public ReadCommand ConvIds(IEnumerable<string> convIds)
		{
			return null;
		}

		public ReadCommand Conv(ConvRead conv)
		{
			return null;
		}

		public ReadCommand Convs(IEnumerable<ConvRead> convReads)
		{
			return null;
		}
	}
}
