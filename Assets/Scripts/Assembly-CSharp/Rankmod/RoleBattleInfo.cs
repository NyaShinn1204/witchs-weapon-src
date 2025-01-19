using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Rolemod;
using Svmod;

namespace Rankmod
{
	public sealed class RoleBattleInfo : IMessage<RoleBattleInfo>, IMessage, IEquatable<RoleBattleInfo>, IDeepCloneable<RoleBattleInfo>
	{
		private static readonly MessageParser<RoleBattleInfo> _parser;

		public const int CEFieldNumber = 1;

		private double cE_;

		public const int RoleInfoFieldNumber = 2;

		private RoleInstanceProto roleInfo_;

		public const int ServantsInfoFieldNumber = 3;

		private static readonly FieldCodec<ServantInstanceProto> _repeated_servantsInfo_codec;

		private readonly RepeatedField<ServantInstanceProto> servantsInfo_;

		public const int WeaponsInfoFieldNumber = 4;

		private static readonly FieldCodec<WeaponInstance> _repeated_weaponsInfo_codec;

		private readonly RepeatedField<WeaponInstance> weaponsInfo_;

		public const int HPFieldNumber = 5;

		private float hP_;

		public const int BattleTimeFieldNumber = 6;

		private int battleTime_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<RoleBattleInfo> Parser
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
		public double CE
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
		public RoleInstanceProto RoleInfo
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
		public RepeatedField<ServantInstanceProto> ServantsInfo
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<WeaponInstance> WeaponsInfo
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public float HP
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public int BattleTime
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
		public RoleBattleInfo()
		{
		}

		[DebuggerNonUserCode]
		public RoleBattleInfo(RoleBattleInfo other)
		{
		}

		[DebuggerNonUserCode]
		public RoleBattleInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(RoleBattleInfo other)
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
		public void MergeFrom(RoleBattleInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
