using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Apmod
{
	public sealed class RankData : IMessage<RankData>, IMessage, IEquatable<RankData>, IDeepCloneable<RankData>
	{
		private static readonly MessageParser<RankData> _parser;

		public const int TopFieldNumber = 1;

		private static readonly FieldCodec<RankInfo> _repeated_top_codec;

		private readonly RepeatedField<RankInfo> top_;

		public const int DataFieldNumber = 2;

		private long data_;

		public const int RankFieldNumber = 3;

		private int rank_;

		public const int NextRankTimeFieldNumber = 4;

		private long nextRankTime_;

		public const int RankTypeFieldNumber = 5;

		private int rankType_;

		public const int SectionFieldNumber = 6;

		private int section_;

		public const int ArrDataFieldNumber = 7;

		private static readonly FieldCodec<int> _repeated_arrData_codec;

		private readonly RepeatedField<int> arrData_;

		public const int RankLevelInfoFieldNumber = 8;

		private static readonly FieldCodec<RankLevelInfo> _repeated_rankLevelInfo_codec;

		private readonly RepeatedField<RankLevelInfo> rankLevelInfo_;

		public const int BestScoreFieldNumber = 9;

		private long bestScore_;

		public const int RankPageFieldNumber = 10;

		private int rankPage_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<RankData> Parser
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
		public RepeatedField<RankInfo> Top
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public long Data
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
		public int Rank
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
		public long NextRankTime
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
		public int RankType
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
		public int Section
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
		public RepeatedField<int> ArrData
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<RankLevelInfo> RankLevelInfo
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public long BestScore
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
		public int RankPage
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
		public RankData()
		{
		}

		[DebuggerNonUserCode]
		public RankData(RankData other)
		{
		}

		[DebuggerNonUserCode]
		public RankData Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(RankData other)
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
		public void MergeFrom(RankData other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
