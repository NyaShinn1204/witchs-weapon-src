using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Shopmod
{
	public sealed class ShopSet : IMessage<ShopSet>, IMessage, IEquatable<ShopSet>, IDeepCloneable<ShopSet>
	{
		private static readonly MessageParser<ShopSet> _parser;

		public const int SetIDFieldNumber = 1;

		private long setID_;

		public const int RefreshCountFieldNumber = 2;

		private int refreshCount_;

		public const int LastAutoRefTimeFieldNumber = 3;

		private long lastAutoRefTime_;

		public const int StartTimeFieldNumber = 6;

		private long startTime_;

		public const int StopTimeFieldNumber = 7;

		private long stopTime_;

		public const int SecretScoreFieldNumber = 8;

		private int secretScore_;

		public const int TriggerTimeFieldNumber = 9;

		private long triggerTime_;

		public const int VipExtraFieldNumber = 10;

		private int vipExtra_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<ShopSet> Parser
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
		public long SetID
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
		public int RefreshCount
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
		public long LastAutoRefTime
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
		public long StartTime
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
		public long StopTime
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
		public int SecretScore
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
		public long TriggerTime
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
		public int VipExtra
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
		public ShopSet()
		{
		}

		[DebuggerNonUserCode]
		public ShopSet(ShopSet other)
		{
		}

		[DebuggerNonUserCode]
		public ShopSet Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ShopSet other)
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
		public void MergeFrom(ShopSet other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
