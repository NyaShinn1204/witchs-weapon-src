using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Svmod;

namespace Apmod
{
	public sealed class OtherInfo : IMessage<OtherInfo>, IMessage, IEquatable<OtherInfo>, IDeepCloneable<OtherInfo>
	{
		private static readonly MessageParser<OtherInfo> _parser;

		public const int ServantInstanceProtoFieldNumber = 1;

		private static readonly FieldCodec<ServantInstanceProto> _repeated_servantInstanceProto_codec;

		private readonly RepeatedField<ServantInstanceProto> servantInstanceProto_;

		public const int WeaponInstanceFieldNumber = 2;

		private static readonly FieldCodec<WeaponInstance> _repeated_weaponInstance_codec;

		private readonly RepeatedField<WeaponInstance> weaponInstance_;

		public const int HPFieldNumber = 3;

		private float hP_;

		public const int BattleTimeFieldNumber = 4;

		private int battleTime_;

		public const int CEFieldNumber = 5;

		private double cE_;

		public const int IsMercenaryFieldNumber = 6;

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
		public static MessageParser<OtherInfo> Parser
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
		public OtherInfo()
		{
		}

		[DebuggerNonUserCode]
		public OtherInfo(OtherInfo other)
		{
		}

		[DebuggerNonUserCode]
		public OtherInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(OtherInfo other)
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
		public void MergeFrom(OtherInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
