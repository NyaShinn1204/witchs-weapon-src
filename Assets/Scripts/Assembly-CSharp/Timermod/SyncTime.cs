using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Rolemod;

namespace Timermod
{
	public sealed class SyncTime : IMessage<SyncTime>, IMessage, IEquatable<SyncTime>, IDeepCloneable<SyncTime>
	{
		private static readonly MessageParser<SyncTime> _parser;

		public const int TimeFieldNumber = 1;

		private long time_;

		public const int TimePoint0FieldNumber = 2;

		private bool timePoint0_;

		public const int TimePoint5FieldNumber = 3;

		private bool timePoint5_;

		public const int StaminaFieldNumber = 4;

		private int stamina_;

		public const int StaminaTimeFieldNumber = 5;

		private long staminaTime_;

		public const int RoleTimeInstanceFieldNumber = 6;

		private RoleTimeInstance roleTimeInstance_;

		public const int ActivityStaminaFieldNumber = 7;

		private int activityStamina_;

		public const int ActivityStaminaTimeFieldNumber = 8;

		private long activityStaminaTime_;

		public const int TimeVersionFlagFieldNumber = 9;

		private int timeVersionFlag_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<SyncTime> Parser
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
		public bool TimePoint0
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
		public bool TimePoint5
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
		public int Stamina
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
		public long StaminaTime
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
		public RoleTimeInstance RoleTimeInstance
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
		public int ActivityStamina
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
		public long ActivityStaminaTime
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
		public int TimeVersionFlag
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
		public SyncTime()
		{
		}

		[DebuggerNonUserCode]
		public SyncTime(SyncTime other)
		{
		}

		[DebuggerNonUserCode]
		public SyncTime Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(SyncTime other)
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
		public void MergeFrom(SyncTime other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
