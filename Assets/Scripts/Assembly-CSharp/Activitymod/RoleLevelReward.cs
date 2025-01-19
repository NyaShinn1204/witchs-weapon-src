using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Activitymod
{
	public sealed class RoleLevelReward : IMessage<RoleLevelReward>, IMessage, IEquatable<RoleLevelReward>, IDeepCloneable<RoleLevelReward>
	{
		private static readonly MessageParser<RoleLevelReward> _parser;

		public const int RoleLevelCanReceiveTagFieldNumber = 1;

		private int roleLevelCanReceiveTag_;

		public const int RoleLevelRewardTagFieldNumber = 2;

		private int roleLevelRewardTag_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<RoleLevelReward> Parser
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
		public int RoleLevelCanReceiveTag
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
		public int RoleLevelRewardTag
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
		public RoleLevelReward()
		{
		}

		[DebuggerNonUserCode]
		public RoleLevelReward(RoleLevelReward other)
		{
		}

		[DebuggerNonUserCode]
		public RoleLevelReward Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(RoleLevelReward other)
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
		public void MergeFrom(RoleLevelReward other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
