using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Combatmod
{
	public sealed class WeaponSharpInfo : IMessage<WeaponSharpInfo>, IMessage, IEquatable<WeaponSharpInfo>, IDeepCloneable<WeaponSharpInfo>
	{
		private static readonly MessageParser<WeaponSharpInfo> _parser;

		public const int SharpMaxFieldNumber = 1;

		private int sharpMax_;

		public const int SharpRecoveryFieldNumber = 2;

		private int sharpRecovery_;

		public const int SharpReduceSecondFieldNumber = 3;

		private int sharpReduceSecond_;

		public const int SharpReduceAttackFieldNumber = 4;

		private int sharpReduceAttack_;

		public const int SharpReduceHitFieldNumber = 5;

		private int sharpReduceHit_;

		public const int SharpConsumeInFieldNumber = 6;

		private int sharpConsumeIn_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<WeaponSharpInfo> Parser
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
		public int SharpMax
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
		public int SharpRecovery
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
		public int SharpReduceSecond
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
		public int SharpReduceAttack
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
		public int SharpReduceHit
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
		public int SharpConsumeIn
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
		public WeaponSharpInfo()
		{
		}

		[DebuggerNonUserCode]
		public WeaponSharpInfo(WeaponSharpInfo other)
		{
		}

		[DebuggerNonUserCode]
		public WeaponSharpInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(WeaponSharpInfo other)
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
		public void MergeFrom(WeaponSharpInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
