using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Hackmod
{
	public sealed class AttackNumHack : IMessage<AttackNumHack>, IMessage, IEquatable<AttackNumHack>, IDeepCloneable<AttackNumHack>
	{
		private static readonly MessageParser<AttackNumHack> _parser;

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

		public const int AttackNumFieldNumber = 200;

		private int attackNum_;

		public const int MobkNumFieldNumber = 201;

		private int mobkNum_;

		public const int SpellNumFieldNumber = 202;

		private int spellNum_;

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
		public static MessageParser<AttackNumHack> Parser
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
		public int AttackNum
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
		public int MobkNum
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
		public int SpellNum
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
		public AttackNumHack()
		{
		}

		[DebuggerNonUserCode]
		public AttackNumHack(AttackNumHack other)
		{
		}

		[DebuggerNonUserCode]
		public AttackNumHack Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(AttackNumHack other)
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
		public void MergeFrom(AttackNumHack other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
