using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Hackmod
{
	public sealed class AttackSpeedHack : IMessage<AttackSpeedHack>, IMessage, IEquatable<AttackSpeedHack>, IDeepCloneable<AttackSpeedHack>
	{
		private static readonly MessageParser<AttackSpeedHack> _parser;

		public const int OriginStrFieldNumber = 100;

		private string originStr_;

		public const int InstanceIDFieldNumber = 101;

		private long instanceID_;

		public const int InstanceTypeFieldNumber = 102;

		private int instanceType_;

		public const int CombatTimeFieldNumber = 103;

		private long combatTime_;

		public const int RoleLevelFieldNumber = 104;

		private int roleLevel_;

		public const int TimeFieldNumber = 105;

		private string time_;

		public const int ContinuousAttackNumFieldNumber = 200;

		private int continuousAttackNum_;

		public const int OtherValueFieldNumber = 300;

		private int otherValue_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<AttackSpeedHack> Parser
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
		public string OriginStr
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
		public long InstanceID
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
		public int InstanceType
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
		public long CombatTime
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
		public int RoleLevel
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
		public string Time
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
		public int ContinuousAttackNum
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
		public int OtherValue
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
		public AttackSpeedHack()
		{
		}

		[DebuggerNonUserCode]
		public AttackSpeedHack(AttackSpeedHack other)
		{
		}

		[DebuggerNonUserCode]
		public AttackSpeedHack Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(AttackSpeedHack other)
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
		public void MergeFrom(AttackSpeedHack other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
