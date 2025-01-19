using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Svmod;

namespace Apmod
{
	public sealed class RankInfo : IMessage<RankInfo>, IMessage, IEquatable<RankInfo>, IDeepCloneable<RankInfo>
	{
		private static readonly MessageParser<RankInfo> _parser;

		public const int RoleIDFieldNumber = 1;

		private long roleID_;

		public const int DataFieldNumber = 2;

		private long data_;

		public const int NameFieldNumber = 3;

		private string name_;

		public const int LevelFieldNumber = 4;

		private int level_;

		public const int HeadFieldNumber = 5;

		private int head_;

		public const int HeadBoxFieldNumber = 6;

		private int headBox_;

		public const int TitleFieldNumber = 7;

		private int title_;

		public const int ServantInstanceProtoFieldNumber = 8;

		private static readonly FieldCodec<ServantInstanceProto> _repeated_servantInstanceProto_codec;

		private readonly RepeatedField<ServantInstanceProto> servantInstanceProto_;

		public const int WeaponInstanceFieldNumber = 9;

		private static readonly FieldCodec<WeaponInstance> _repeated_weaponInstance_codec;

		private readonly RepeatedField<WeaponInstance> weaponInstance_;

		public const int HPFieldNumber = 10;

		private float hP_;

		public const int BattleTimeFieldNumber = 11;

		private int battleTime_;

		public const int CEFieldNumber = 12;

		private double cE_;

		public const int IsMercenaryFieldNumber = 13;

		private static readonly FieldCodec<bool> _repeated_isMercenary_codec;

		private readonly RepeatedField<bool> isMercenary_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<RankInfo> Parser
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
		public long RoleID
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
		public long Data
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
		public string Name
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
		public int Level
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
		public int Head
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
		public int HeadBox
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
		public int Title
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
		public RepeatedField<ServantInstanceProto> ServantInstanceProto
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<WeaponInstance> WeaponInstance
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
		public RepeatedField<bool> IsMercenary
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RankInfo()
		{
		}

		[DebuggerNonUserCode]
		public RankInfo(RankInfo other)
		{
		}

		[DebuggerNonUserCode]
		public RankInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(RankInfo other)
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
		public void MergeFrom(RankInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
