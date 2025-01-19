using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Activitymod
{
	public sealed class ChallengeInfo : IMessage<ChallengeInfo>, IMessage, IEquatable<ChallengeInfo>, IDeepCloneable<ChallengeInfo>
	{
		private static readonly MessageParser<ChallengeInfo> _parser;

		public const int ChallengeTimesFieldNumber = 1;

		private int challengeTimes_;

		public const int BuffsFieldNumber = 2;

		private static readonly FieldCodec<string> _repeated_buffs_codec;

		private readonly RepeatedField<string> buffs_;

		public const int OpenBuffsFieldNumber = 3;

		private static readonly MapField<long, long>.Codec _map_openBuffs_codec;

		private readonly MapField<long, long> openBuffs_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<ChallengeInfo> Parser
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
		public int ChallengeTimes
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
		public RepeatedField<string> Buffs
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public MapField<long, long> OpenBuffs
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public ChallengeInfo()
		{
		}

		[DebuggerNonUserCode]
		public ChallengeInfo(ChallengeInfo other)
		{
		}

		[DebuggerNonUserCode]
		public ChallengeInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ChallengeInfo other)
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
		public void MergeFrom(ChallengeInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
