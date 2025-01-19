using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Combatmod
{
	public sealed class CombatConstInfo : IMessage<CombatConstInfo>, IMessage, IEquatable<CombatConstInfo>, IDeepCloneable<CombatConstInfo>
	{
		private static readonly MessageParser<CombatConstInfo> _parser;

		public const int KillingCDFieldNumber = 1;

		private int killingCD_;

		public const int CharFieldNumber = 2;

		private static readonly FieldCodec<int> _repeated_char_codec;

		private readonly RepeatedField<int> char_;

		public const int WpMDLFieldNumber = 3;

		private static readonly FieldCodec<double> _repeated_wpMDL_codec;

		private readonly RepeatedField<double> wpMDL_;

		public const int DmgPkgMDLFieldNumber = 4;

		private static readonly FieldCodec<double> _repeated_dmgPkgMDL_codec;

		private readonly RepeatedField<double> dmgPkgMDL_;

		public const int TSPFieldNumber = 5;

		private static readonly FieldCodec<int> _repeated_tSP_codec;

		private readonly RepeatedField<int> tSP_;

		public const int MobExtraHealModulusFieldNumber = 6;

		private static readonly FieldCodec<double> _repeated_mobExtraHealModulus_codec;

		private readonly RepeatedField<double> mobExtraHealModulus_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<CombatConstInfo> Parser
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
		public int KillingCD
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
		public RepeatedField<int> Char
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<double> WpMDL
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<double> DmgPkgMDL
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> TSP
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<double> MobExtraHealModulus
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public CombatConstInfo()
		{
		}

		[DebuggerNonUserCode]
		public CombatConstInfo(CombatConstInfo other)
		{
		}

		[DebuggerNonUserCode]
		public CombatConstInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(CombatConstInfo other)
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
		public void MergeFrom(CombatConstInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
