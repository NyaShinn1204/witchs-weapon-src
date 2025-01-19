using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Apmod
{
	public sealed class RankLevelInfo : IMessage<RankLevelInfo>, IMessage, IEquatable<RankLevelInfo>, IDeepCloneable<RankLevelInfo>
	{
		private static readonly MessageParser<RankLevelInfo> _parser;

		public const int LevelTypeFieldNumber = 1;

		private long levelType_;

		public const int LtypeRankFieldNumber = 2;

		private int ltypeRank_;

		public const int LtypeDataFieldNumber = 3;

		private long ltypeData_;

		public const int LtypeSectionFieldNumber = 4;

		private int ltypeSection_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<RankLevelInfo> Parser
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
		public long LevelType
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
		public int LtypeRank
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long LtypeData
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
		public int LtypeSection
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public RankLevelInfo()
		{
		}

		[DebuggerNonUserCode]
		public RankLevelInfo(RankLevelInfo other)
		{
		}

		[DebuggerNonUserCode]
		public RankLevelInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(RankLevelInfo other)
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
		public void MergeFrom(RankLevelInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
