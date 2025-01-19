using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Svmod;

namespace Guildmod
{
	public sealed class Mercenary : IMessage<Mercenary>, IMessage, IEquatable<Mercenary>, IDeepCloneable<Mercenary>
	{
		private static readonly MessageParser<Mercenary> _parser;

		public const int RoleIDFieldNumber = 1;

		private long roleID_;

		public const int RoleNameFieldNumber = 13;

		private string roleName_;

		public const int ServantIDFieldNumber = 2;

		private long servantID_;

		public const int ServantInfoFieldNumber = 3;

		private ServantInstanceProto servantInfo_;

		public const int WeaponInfoFieldNumber = 4;

		private WeaponInstance weaponInfo_;

		public const int CurImageFieldNumber = 12;

		private int curImage_;

		public const int GarrisonTimeFieldNumber = 5;

		private long garrisonTime_;

		public const int EmployCountFieldNumber = 6;

		private int employCount_;

		public const int EmployDailyCountFieldNumber = 11;

		private int employDailyCount_;

		public const int TimeProfitFieldNumber = 7;

		private int timeProfit_;

		public const int EmployProfitFieldNumber = 8;

		private int employProfit_;

		public const int EmployDailyProfitFieldNumber = 9;

		private int employDailyProfit_;

		public const int LastEmployTimeFieldNumber = 10;

		private long lastEmployTime_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<Mercenary> Parser
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
		public string RoleName
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
		public long ServantID
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
		public ServantInstanceProto ServantInfo
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
		public WeaponInstance WeaponInfo
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
		public long GarrisonTime
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
		public int EmployCount
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
		public int EmployDailyCount
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
		public int TimeProfit
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
		public int EmployProfit
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
		public int EmployDailyProfit
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
		public long LastEmployTime
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
		public Mercenary()
		{
		}

		[DebuggerNonUserCode]
		public Mercenary(Mercenary other)
		{
		}

		[DebuggerNonUserCode]
		public Mercenary Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Mercenary other)
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
		public void MergeFrom(Mercenary other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
