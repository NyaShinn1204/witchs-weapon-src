using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Miscmod
{
	public sealed class CodeInfo : IMessage<CodeInfo>, IMessage, IEquatable<CodeInfo>, IDeepCloneable<CodeInfo>
	{
		private static readonly MessageParser<CodeInfo> _parser;

		public const int LevelFieldNumber = 1;

		private long level_;

		public const int ChapFieldNumber = 2;

		private long chap_;

		public const int ChargeFieldNumber = 3;

		private long charge_;

		public const int CodeFieldNumber = 4;

		private long code_;

		public const int CodeNameFieldNumber = 5;

		private string codeName_;

		public const int CanRewardTagFieldNumber = 6;

		private static readonly MapField<long, bool>.Codec _map_canRewardTag_codec;

		private readonly MapField<long, bool> canRewardTag_;

		public const int RewardTagFieldNumber = 7;

		private static readonly MapField<long, bool>.Codec _map_rewardTag_codec;

		private readonly MapField<long, bool> rewardTag_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<CodeInfo> Parser
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public long Level
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long Chap
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long Charge
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long Code
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public string CodeName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public MapField<long, bool> CanRewardTag
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public MapField<long, bool> RewardTag
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public CodeInfo()
		{
		}

		[DebuggerNonUserCode]
		public CodeInfo(CodeInfo other)
		{
		}

		[DebuggerNonUserCode]
		public CodeInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(CodeInfo other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public override int GetHashCode()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		public override string ToString()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public void WriteTo(CodedOutputStream output)
		{
		}

		[DebuggerNonUserCode]
		public int CalculateSize()
		{
			return 0;
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodeInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
