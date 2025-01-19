using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Shopmod
{
	public sealed class SetInfo : IMessage<SetInfo>, IMessage, IEquatable<SetInfo>, IDeepCloneable<SetInfo>
	{
		private static readonly MessageParser<SetInfo> _parser;

		public const int SetIDFieldNumber = 1;

		private long setID_;

		public const int TimeLeftFieldNumber = 2;

		private long timeLeft_;

		public const int AutoRefreshFieldNumber = 3;

		private bool autoRefresh_;

		public const int ManualRefreshFieldNumber = 4;

		private bool manualRefresh_;

		public const int ShopsFieldNumber = 5;

		private static readonly FieldCodec<Shop> _repeated_shops_codec;

		private readonly RepeatedField<Shop> shops_;

		public const int StartTimeFieldNumber = 6;

		private long startTime_;

		public const int StopTimeFieldNumber = 7;

		private long stopTime_;

		public const int RefreshCountFieldNumber = 8;

		private int refreshCount_;

		public const int OpenFieldNumber = 9;

		private bool open_;

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
		public static MessageParser<SetInfo> Parser
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
		public long TimeLeft
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
		public bool AutoRefresh
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
		public bool ManualRefresh
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
		public RepeatedField<Shop> Shops
		{
			get
			{
				return null;
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
		public bool Open
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
		public SetInfo()
		{
		}

		[DebuggerNonUserCode]
		public SetInfo(SetInfo other)
		{
		}

		[DebuggerNonUserCode]
		public SetInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(SetInfo other)
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
		public void MergeFrom(SetInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
