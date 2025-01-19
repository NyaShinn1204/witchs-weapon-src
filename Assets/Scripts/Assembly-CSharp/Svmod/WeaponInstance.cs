using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Svmod
{
	public sealed class WeaponInstance : IMessage<WeaponInstance>, IMessage, IEquatable<WeaponInstance>, IDeepCloneable<WeaponInstance>
	{
		private static readonly MessageParser<WeaponInstance> _parser;

		public const int WeaponCardIDFieldNumber = 1;

		private long weaponCardID_;

		public const int RoleIDFieldNumber = 2;

		private long roleID_;

		public const int WeaponPromoteLvFieldNumber = 3;

		private int weaponPromoteLv_;

		public const int WeaponSpellPromoteLvFieldNumber = 4;

		private int weaponSpellPromoteLv_;

		public const int SkinsFieldNumber = 5;

		private int skins_;

		public const int CurSkinFieldNumber = 6;

		private int curSkin_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<WeaponInstance> Parser
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
		public long WeaponCardID
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
		public int WeaponPromoteLv
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
		public int WeaponSpellPromoteLv
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
		public WeaponInstance()
		{
		}

		[DebuggerNonUserCode]
		public WeaponInstance(WeaponInstance other)
		{
		}

		[DebuggerNonUserCode]
		public WeaponInstance Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(WeaponInstance other)
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
		public void MergeFrom(WeaponInstance other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
