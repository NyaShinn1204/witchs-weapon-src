using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Ratemod
{
	public sealed class SingleRate : IMessage<SingleRate>, IMessage, IEquatable<SingleRate>, IDeepCloneable<SingleRate>
	{
		private static readonly MessageParser<SingleRate> _parser;

		public const int ContentIDFieldNumber = 1;

		private static readonly FieldCodec<long> _repeated_contentID_codec;

		private readonly RepeatedField<long> contentID_;

		public const int ContentNumFieldNumber = 2;

		private static readonly FieldCodec<int> _repeated_contentNum_codec;

		private readonly RepeatedField<int> contentNum_;

		public const int MainTargetFieldNumber = 3;

		private static readonly FieldCodec<long> _repeated_mainTarget_codec;

		private readonly RepeatedField<long> mainTarget_;

		public const int MainTargetNumFieldNumber = 4;

		private static readonly FieldCodec<int> _repeated_mainTargetNum_codec;

		private readonly RepeatedField<int> mainTargetNum_;

		public const int RateIDFieldNumber = 100;

		private long rateID_;

		public const int RateSerialFieldNumber = 101;

		private int rateSerial_;

		public const int CurIndexFieldNumber = 102;

		private int curIndex_;

		public const int RemainSpecialFieldNumber = 103;

		private int remainSpecial_;

		public const int SpecialDistanceFieldNumber = 104;

		private int specialDistance_;

		public const int NextMainTargetFieldNumber = 105;

		private int nextMainTarget_;

		public const int TotalTargetNumFieldNumber = 106;

		private int totalTargetNum_;

		public const int TotalMainTargetNumFieldNumber = 107;

		private int totalMainTargetNum_;

		public const int CurMainTargetDistanceFieldNumber = 108;

		private int curMainTargetDistance_;

		public const int VersionFieldNumber = 109;

		private int version_;

		public const int CurExtraTargetNumFieldNumber = 110;

		private int curExtraTargetNum_;

		public const int TotalNonMainTargetNumFieldNumber = 111;

		private int totalNonMainTargetNum_;

		public const int TotalAccumulateTargetNumFieldNumber = 112;

		private int totalAccumulateTargetNum_;

		public const int RateTimeFieldNumber = 113;

		private long rateTime_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<SingleRate> Parser
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
		public RepeatedField<long> ContentID
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> ContentNum
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<long> MainTarget
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> MainTargetNum
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public long RateID
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
		public int RateSerial
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
		public int CurIndex
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
		public int RemainSpecial
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
		public int SpecialDistance
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
		public int NextMainTarget
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
		public int TotalTargetNum
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
		public int TotalMainTargetNum
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
		public int CurMainTargetDistance
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
		public int Version
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
		public int CurExtraTargetNum
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
		public int TotalNonMainTargetNum
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
		public int TotalAccumulateTargetNum
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
		public long RateTime
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
		public SingleRate()
		{
		}

		[DebuggerNonUserCode]
		public SingleRate(SingleRate other)
		{
		}

		[DebuggerNonUserCode]
		public SingleRate Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(SingleRate other)
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
		public void MergeFrom(SingleRate other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
