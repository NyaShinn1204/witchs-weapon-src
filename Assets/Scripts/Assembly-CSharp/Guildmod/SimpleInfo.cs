using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Guildmod
{
	public sealed class SimpleInfo : IMessage<SimpleInfo>, IMessage, IEquatable<SimpleInfo>, IDeepCloneable<SimpleInfo>
	{
		private static readonly MessageParser<SimpleInfo> _parser;

		public const int IDFieldNumber = 1;

		private long iD_;

		public const int NameFieldNumber = 2;

		private string name_;

		public const int HeadFieldNumber = 9;

		private int head_;

		public const int HeadBoxFieldNumber = 10;

		private int headBox_;

		public const int LevelFieldNumber = 3;

		private int level_;

		public const int CEFieldNumber = 4;

		private double cE_;

		public const int TimeFieldNumber = 5;

		private long time_;

		public const int EnterTimeFieldNumber = 6;

		private long enterTime_;

		public const int TotalVitalityFieldNumber = 7;

		private int totalVitality_;

		public const int DailyVitalityFieldNumber = 8;

		private int dailyVitality_;

		public const int ServantCountFieldNumber = 11;

		private int servantCount_;

		public const int WeaponCountFieldNumber = 12;

		private int weaponCount_;

		public const int TitleFieldNumber = 13;

		private int title_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<SimpleInfo> Parser
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
		public long ID
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
		public long Time
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
		public long EnterTime
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
		public int TotalVitality
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
		public int DailyVitality
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
		public int ServantCount
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
		public int WeaponCount
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
		public SimpleInfo()
		{
		}

		[DebuggerNonUserCode]
		public SimpleInfo(SimpleInfo other)
		{
		}

		[DebuggerNonUserCode]
		public SimpleInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(SimpleInfo other)
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
		public void MergeFrom(SimpleInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
