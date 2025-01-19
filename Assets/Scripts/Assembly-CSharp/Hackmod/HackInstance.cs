using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Hackmod
{
	public sealed class HackInstance : IMessage<HackInstance>, IMessage, IEquatable<HackInstance>, IDeepCloneable<HackInstance>
	{
		private static readonly MessageParser<HackInstance> _parser;

		public const int TotalCombatFieldNumber = 1;

		private static readonly FieldCodec<int> _repeated_totalCombat_codec;

		private readonly RepeatedField<int> totalCombat_;

		public const int DamageHackFieldNumber = 2;

		private static readonly FieldCodec<DamageHack> _repeated_damageHack_codec;

		private readonly RepeatedField<DamageHack> damageHack_;

		public const int AttackNumHackFieldNumber = 3;

		private static readonly FieldCodec<AttackNumHack> _repeated_attackNumHack_codec;

		private readonly RepeatedField<AttackNumHack> attackNumHack_;

		public const int DeadHackFieldNumber = 4;

		private static readonly FieldCodec<DeadHack> _repeated_deadHack_codec;

		private readonly RepeatedField<DeadHack> deadHack_;

		public const int AttackSpeedHackFieldNumber = 5;

		private static readonly FieldCodec<AttackSpeedHack> _repeated_attackSpeedHack_codec;

		private readonly RepeatedField<AttackSpeedHack> attackSpeedHack_;

		public const int TotalCombat2FieldNumber = 6;

		private static readonly FieldCodec<int> _repeated_totalCombat2_codec;

		private readonly RepeatedField<int> totalCombat2_;

		public const int InstanceIDByWayFieldNumber = 7;

		private static readonly FieldCodec<string> _repeated_instanceIDByWay_codec;

		private readonly RepeatedField<string> instanceIDByWay_;

		public const int InstanceIDByTypeFieldNumber = 8;

		private static readonly FieldCodec<string> _repeated_instanceIDByType_codec;

		private readonly RepeatedField<string> instanceIDByType_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<HackInstance> Parser
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
		public RepeatedField<int> TotalCombat
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<DamageHack> DamageHack
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<AttackNumHack> AttackNumHack
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<DeadHack> DeadHack
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<AttackSpeedHack> AttackSpeedHack
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> TotalCombat2
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<string> InstanceIDByWay
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<string> InstanceIDByType
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public HackInstance()
		{
		}

		[DebuggerNonUserCode]
		public HackInstance(HackInstance other)
		{
		}

		[DebuggerNonUserCode]
		public HackInstance Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(HackInstance other)
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
		public void MergeFrom(HackInstance other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
