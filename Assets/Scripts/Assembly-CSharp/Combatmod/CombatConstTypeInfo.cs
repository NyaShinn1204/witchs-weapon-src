using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Combatmod
{
	public sealed class CombatConstTypeInfo : IMessage<CombatConstTypeInfo>, IMessage, IEquatable<CombatConstTypeInfo>, IDeepCloneable<CombatConstTypeInfo>
	{
		private static readonly MessageParser<CombatConstTypeInfo> _parser;

		public const int ModulusTypeFieldNumber = 1;

		private int modulusType_;

		public const int PhysicalDamageModulusFieldNumber = 2;

		private double physicalDamageModulus_;

		public const int MagicalDamageModulusFieldNumber = 3;

		private double magicalDamageModulus_;

		public const int PhysicalDefenseModulusFieldNumber = 4;

		private double physicalDefenseModulus_;

		public const int MagicalDefenseModulusFieldNumber = 5;

		private double magicalDefenseModulus_;

		public const int HealModulusFieldNumber = 6;

		private double healModulus_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<CombatConstTypeInfo> Parser
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
		public int ModulusType
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
		public double PhysicalDamageModulus
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public double MagicalDamageModulus
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public double PhysicalDefenseModulus
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public double MagicalDefenseModulus
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public double HealModulus
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public CombatConstTypeInfo()
		{
		}

		[DebuggerNonUserCode]
		public CombatConstTypeInfo(CombatConstTypeInfo other)
		{
		}

		[DebuggerNonUserCode]
		public CombatConstTypeInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(CombatConstTypeInfo other)
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
		public void MergeFrom(CombatConstTypeInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
