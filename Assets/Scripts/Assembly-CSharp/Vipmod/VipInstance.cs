using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Vipmod
{
	public sealed class VipInstance : IMessage<VipInstance>, IMessage, IEquatable<VipInstance>, IDeepCloneable<VipInstance>
	{
		private static readonly MessageParser<VipInstance> _parser;

		public const int VipExpsFieldNumber = 1;

		private static readonly FieldCodec<OneDayVipExp> _repeated_vipExps_codec;

		private readonly RepeatedField<OneDayVipExp> vipExps_;

		public const int Vip2GiftFieldNumber = 2;

		private bool vip2Gift_;

		public const int Vip5GiftFieldNumber = 3;

		private bool vip5Gift_;

		public const int RechargeVipExpFieldNumber = 4;

		private int rechargeVipExp_;

		public const int TotalExpireVipExpFieldNumber = 5;

		private int totalExpireVipExp_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<VipInstance> Parser
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
		public RepeatedField<OneDayVipExp> VipExps
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public bool Vip2Gift
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
		public bool Vip5Gift
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
		public int RechargeVipExp
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
		public int TotalExpireVipExp
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
		public VipInstance()
		{
		}

		[DebuggerNonUserCode]
		public VipInstance(VipInstance other)
		{
		}

		[DebuggerNonUserCode]
		public VipInstance Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(VipInstance other)
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
		public void MergeFrom(VipInstance other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
