using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Svmod
{
	public sealed class ServantInstanceProto : IMessage<ServantInstanceProto>, IMessage, IEquatable<ServantInstanceProto>, IDeepCloneable<ServantInstanceProto>
	{
		private static readonly MessageParser<ServantInstanceProto> _parser;

		public const int ServantCardIDFieldNumber = 1;

		private long servantCardID_;

		public const int LevelFieldNumber = 2;

		private int level_;

		public const int ExpFieldNumber = 3;

		private long exp_;

		public const int RankFieldNumber = 4;

		private int rank_;

		public const int StarFieldNumber = 5;

		private int star_;

		public const int EquipsFieldNumber = 7;

		private int equips_;

		public const int SpellLvFieldNumber = 8;

		private static readonly FieldCodec<int> _repeated_spellLv_codec;

		private readonly RepeatedField<int> spellLv_;

		public const int FavorLevelFieldNumber = 9;

		private int favorLevel_;

		public const int FavorExpFieldNumber = 10;

		private int favorExp_;

		public const int ImagesFieldNumber = 11;

		private int images_;

		public const int WeaponLvFieldNumber = 12;

		private int weaponLv_;

		public const int WeaponsFieldNumber = 13;

		private static readonly FieldCodec<WeaponInstance> _repeated_weapons_codec;

		private readonly RepeatedField<WeaponInstance> weapons_;

		public const int GiftNumsFieldNumber = 14;

		private int giftNums_;

		public const int GiftTimeFieldNumber = 15;

		private long giftTime_;

		public const int WeaponExpFieldNumber = 16;

		private long weaponExp_;

		public const int RoleIDFieldNumber = 17;

		private long roleID_;

		public const int CurImageFieldNumber = 18;

		private int curImage_;

		public const int ImagesForFavorFieldNumber = 19;

		private int imagesForFavor_;

		public const int SkinsFieldNumber = 20;

		private int skins_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<ServantInstanceProto> Parser
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
		public long ServantCardID
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
		public long Exp
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
		public int Rank
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
		public int Star
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
		public int Equips
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
		public RepeatedField<int> SpellLv
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int FavorLevel
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
		public int FavorExp
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
		public int Images
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
		public int WeaponLv
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
		public RepeatedField<WeaponInstance> Weapons
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int GiftNums
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
		public long GiftTime
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
		public long WeaponExp
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
		public int CurImage
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
		public int ImagesForFavor
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
		public int Skins
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
		public ServantInstanceProto()
		{
		}

		[DebuggerNonUserCode]
		public ServantInstanceProto(ServantInstanceProto other)
		{
		}

		[DebuggerNonUserCode]
		public ServantInstanceProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ServantInstanceProto other)
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
		public void MergeFrom(ServantInstanceProto other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
