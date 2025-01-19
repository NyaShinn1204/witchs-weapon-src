using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Combatmod
{
	public sealed class ServantCombatInfo : IMessage<ServantCombatInfo>, IMessage, IEquatable<ServantCombatInfo>, IDeepCloneable<ServantCombatInfo>
	{
		private static readonly MessageParser<ServantCombatInfo> _parser;

		public const int SvCardIDFieldNumber = 1;

		private long svCardID_;

		public const int SpaNeedCurTargetFieldNumber = 2;

		private bool spaNeedCurTarget_;

		public const int WeaponPAtkFieldNumber = 3;

		private int weaponPAtk_;

		public const int WeaponMAtkFieldNumber = 4;

		private int weaponMAtk_;

		public const int SvCtrlFieldNumber = 5;

		private string svCtrl_;

		public const int TriggerListFieldNumber = 6;

		private static readonly FieldCodec<long> _repeated_triggerList_codec;

		private readonly RepeatedField<long> triggerList_;

		public const int RoleDashAtkIDFieldNumber = 7;

		private long roleDashAtkID_;

		public const int RoleNormalAtkIDsFieldNumber = 8;

		private static readonly FieldCodec<long> _repeated_roleNormalAtkIDs_codec;

		private readonly RepeatedField<long> roleNormalAtkIDs_;

		public const int EnergyComboFieldNumber = 9;

		private static readonly FieldCodec<int> _repeated_energyCombo_codec;

		private readonly RepeatedField<int> energyCombo_;

		public const int ActiveSpellIDFieldNumber = 10;

		private long activeSpellID_;

		public const int WeaponSharpInfoFieldNumber = 12;

		private WeaponSharpInfo weaponSharpInfo_;

		public const int WeaponAttackFrequencyFieldNumber = 13;

		private double weaponAttackFrequency_;

		public const int SvWeaponCardIDFieldNumber = 14;

		private long svWeaponCardID_;

		public const int WeaponPromoteLevelFieldNumber = 15;

		private int weaponPromoteLevel_;

		public const int CurSkinFieldNumber = 16;

		private int curSkin_;

		public const int SpellEnegyTypeFieldNumber = 17;

		private int spellEnegyType_;

		public const int SpellEnegyArgu1FieldNumber = 18;

		private int spellEnegyArgu1_;

		public const int SpellEnegyArgu2FieldNumber = 19;

		private int spellEnegyArgu2_;

		public const int SpellEnegyArgu3FieldNumber = 20;

		private long spellEnegyArgu3_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<ServantCombatInfo> Parser
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
		public long SvCardID
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
		public bool SpaNeedCurTarget
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int WeaponPAtk
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
		public int WeaponMAtk
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
		public string SvCtrl
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
		public RepeatedField<long> TriggerList
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public long RoleDashAtkID
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
		public RepeatedField<long> RoleNormalAtkIDs
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> EnergyCombo
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public long ActiveSpellID
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
		public WeaponSharpInfo WeaponSharpInfo
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
		public double WeaponAttackFrequency
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
		public long SvWeaponCardID
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
		public int WeaponPromoteLevel
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
		public int CurSkin
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
		public int SpellEnegyType
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
		public int SpellEnegyArgu1
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
		public int SpellEnegyArgu2
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
		public long SpellEnegyArgu3
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
		public ServantCombatInfo()
		{
		}

		[DebuggerNonUserCode]
		public ServantCombatInfo(ServantCombatInfo other)
		{
		}

		[DebuggerNonUserCode]
		public ServantCombatInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ServantCombatInfo other)
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
		public void MergeFrom(ServantCombatInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
