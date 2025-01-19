using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Miscmod
{
	public sealed class InviteCode : IMessage<InviteCode>, IMessage, IEquatable<InviteCode>, IDeepCloneable<InviteCode>
	{
		private static readonly MessageParser<InviteCode> _parser;

		public const int InviteRoleFieldNumber = 1;

		private static readonly FieldCodec<long> _repeated_inviteRole_codec;

		private readonly RepeatedField<long> inviteRole_;

		public const int CanRewardTagFieldNumber = 2;

		private static readonly MapField<long, bool>.Codec _map_canRewardTag_codec;

		private readonly MapField<long, bool> canRewardTag_;

		public const int RewardTagFieldNumber = 3;

		private static readonly MapField<long, bool>.Codec _map_rewardTag_codec;

		private readonly MapField<long, bool> rewardTag_;

		public const int CodeFieldNumber = 4;

		private static readonly MapField<long, Code>.Codec _map_code_codec;

		private readonly MapField<long, Code> code_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<InviteCode> Parser
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
		public RepeatedField<long> InviteRole
		{
			get
			{
				return null;
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
		public MapField<long, Code> Code
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public InviteCode()
		{
		}

		[DebuggerNonUserCode]
		public InviteCode(InviteCode other)
		{
		}

		[DebuggerNonUserCode]
		public InviteCode Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(InviteCode other)
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
		public void MergeFrom(InviteCode other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
