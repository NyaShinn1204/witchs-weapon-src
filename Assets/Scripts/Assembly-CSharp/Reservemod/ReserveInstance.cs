using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Reservemod
{
	public sealed class ReserveInstance : IMessage<ReserveInstance>, IMessage, IEquatable<ReserveInstance>, IDeepCloneable<ReserveInstance>
	{
		private static readonly MessageParser<ReserveInstance> _parser;

		public const int LoginCompensationTagFieldNumber = 1;

		private long loginCompensationTag_;

		public const int LoginCompensationArrayFieldNumber = 2;

		private static readonly FieldCodec<int> _repeated_loginCompensationArray_codec;

		private readonly RepeatedField<int> loginCompensationArray_;

		public const int ActCurrencyRecordFieldNumber = 3;

		private long actCurrencyRecord_;

		public const int ActCurrencyModifyRecordFieldNumber = 4;

		private string actCurrencyModifyRecord_;

		public const int CompensationTagFieldNumber = 5;

		private static readonly MapField<int, bool>.Codec _map_compensationTag_codec;

		private readonly MapField<int, bool> compensationTag_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<ReserveInstance> Parser
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
		public long LoginCompensationTag
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
		public RepeatedField<int> LoginCompensationArray
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public long ActCurrencyRecord
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
		public string ActCurrencyModifyRecord
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
		public MapField<int, bool> CompensationTag
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public ReserveInstance()
		{
		}

		[DebuggerNonUserCode]
		public ReserveInstance(ReserveInstance other)
		{
		}

		[DebuggerNonUserCode]
		public ReserveInstance Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ReserveInstance other)
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
		public void MergeFrom(ReserveInstance other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
