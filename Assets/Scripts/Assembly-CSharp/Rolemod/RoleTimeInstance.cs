using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Rolemod
{
	public sealed class RoleTimeInstance : IMessage<RoleTimeInstance>, IMessage, IEquatable<RoleTimeInstance>, IDeepCloneable<RoleTimeInstance>
	{
		private static readonly MessageParser<RoleTimeInstance> _parser;

		public const int BuyStaminaTimesFieldNumber = 1;

		private int buyStaminaTimes_;

		public const int BuyGoldTimesFieldNumber = 2;

		private int buyGoldTimes_;

		public const int FreeGoldDrawTimesFieldNumber = 3;

		private int freeGoldDrawTimes_;

		public const int FreeGoldDrawTimeFieldNumber = 4;

		private long freeGoldDrawTime_;

		public const int FreeRMBDrawTimesFieldNumber = 5;

		private int freeRMBDrawTimes_;

		public const int TimePoint5FieldNumber = 6;

		private long timePoint5_;

		public const int StaminaTime8FieldNumber = 7;

		private long staminaTime8_;

		public const int StaminaTime12FieldNumber = 8;

		private long staminaTime12_;

		public const int StaminaTime18FieldNumber = 9;

		private long staminaTime18_;

		public const int TimePoint0FieldNumber = 10;

		private long timePoint0_;

		public const int DrawGuaranteeTimesFieldNumber = 11;

		private int drawGuaranteeTimes_;

		public const int TimeZoneFieldNumber = 12;

		private int timeZone_;

		public const int FreeContinusGoldDrawTimesFieldNumber = 13;

		private int freeContinusGoldDrawTimes_;

		public const int FreeContinusGoldDrawTimeFieldNumber = 14;

		private long freeContinusGoldDrawTime_;

		public const int GoldMiniGameTimesFieldNumber = 15;

		private int goldMiniGameTimes_;

		public const int FakeDrawMailTimesFieldNumber = 16;

		private int fakeDrawMailTimes_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<RoleTimeInstance> Parser
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
		public int BuyStaminaTimes
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
		public int BuyGoldTimes
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
		public int FreeGoldDrawTimes
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
		public long FreeGoldDrawTime
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
		public int FreeRMBDrawTimes
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
		public long TimePoint5
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
		public long StaminaTime8
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
		public long StaminaTime12
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
		public long StaminaTime18
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
		public long TimePoint0
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
		public int DrawGuaranteeTimes
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
		public int TimeZone
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
		public int FreeContinusGoldDrawTimes
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
		public long FreeContinusGoldDrawTime
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
		public int GoldMiniGameTimes
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
		public int FakeDrawMailTimes
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
		public RoleTimeInstance()
		{
		}

		[DebuggerNonUserCode]
		public RoleTimeInstance(RoleTimeInstance other)
		{
		}

		[DebuggerNonUserCode]
		public RoleTimeInstance Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(RoleTimeInstance other)
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
		public void MergeFrom(RoleTimeInstance other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
