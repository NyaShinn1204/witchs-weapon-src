using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Svmod
{
	public sealed class ServantInstancesProto : IMessage<ServantInstancesProto>, IMessage, IEquatable<ServantInstancesProto>, IDeepCloneable<ServantInstancesProto>
	{
		private static readonly MessageParser<ServantInstancesProto> _parser;

		public const int ServantInstanceProtoFieldNumber = 1;

		private static readonly FieldCodec<ServantInstanceProto> _repeated_servantInstanceProto_codec;

		private readonly RepeatedField<ServantInstanceProto> servantInstanceProto_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<ServantInstancesProto> Parser
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
		public RepeatedField<ServantInstanceProto> ServantInstanceProto
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public ServantInstancesProto()
		{
		}

		[DebuggerNonUserCode]
		public ServantInstancesProto(ServantInstancesProto other)
		{
		}

		[DebuggerNonUserCode]
		public ServantInstancesProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ServantInstancesProto other)
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
		public void MergeFrom(ServantInstancesProto other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
