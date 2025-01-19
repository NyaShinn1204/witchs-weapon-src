using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Miscmod
{
	public sealed class Inviter : IMessage<Inviter>, IMessage, IEquatable<Inviter>, IDeepCloneable<Inviter>
	{
		private static readonly MessageParser<Inviter> _parser;

		public const int InviteRoleFieldNumber = 1;

		private static readonly FieldCodec<long> _repeated_inviteRole_codec;

		private readonly RepeatedField<long> inviteRole_;

		public const int CanRewardTagFieldNumber = 2;

		private static readonly MapField<long, bool>.Codec _map_canRewardTag_codec;

		private readonly MapField<long, bool> canRewardTag_;

		public const int RewardTagFieldNumber = 3;

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
		public static MessageParser<Inviter> Parser
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
		public Inviter()
		{
		}

		[DebuggerNonUserCode]
		public Inviter(Inviter other)
		{
		}

		[DebuggerNonUserCode]
		public Inviter Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Inviter other)
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
		public void MergeFrom(Inviter other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
