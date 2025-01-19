using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bpobjmod
{
	public sealed class ServantEquipPackInfo : IMessage<ServantEquipPackInfo>, IMessage, IEquatable<ServantEquipPackInfo>, IDeepCloneable<ServantEquipPackInfo>
	{
		private static readonly MessageParser<ServantEquipPackInfo> _parser;

		public const int ServantEquipIDFieldNumber = 1;

		private static readonly FieldCodec<long> _repeated_servantEquipID_codec;

		private readonly RepeatedField<long> servantEquipID_;

		public const int ServantEquipNumFieldNumber = 2;

		private static readonly FieldCodec<int> _repeated_servantEquipNum_codec;

		private readonly RepeatedField<int> servantEquipNum_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<ServantEquipPackInfo> Parser
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
		public RepeatedField<long> ServantEquipID
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> ServantEquipNum
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public ServantEquipPackInfo()
		{
		}

		[DebuggerNonUserCode]
		public ServantEquipPackInfo(ServantEquipPackInfo other)
		{
		}

		[DebuggerNonUserCode]
		public ServantEquipPackInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ServantEquipPackInfo other)
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
		public void MergeFrom(ServantEquipPackInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
