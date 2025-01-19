using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Guildmod
{
	public sealed class UserEmployed : IMessage<UserEmployed>, IMessage, IEquatable<UserEmployed>, IDeepCloneable<UserEmployed>
	{
		private static readonly MessageParser<UserEmployed> _parser;

		public const int DataFieldNumber = 1;

		private static readonly FieldCodec<Employed> _repeated_data_codec;

		private readonly RepeatedField<Employed> data_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<UserEmployed> Parser
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
		public RepeatedField<Employed> Data
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public UserEmployed()
		{
		}

		[DebuggerNonUserCode]
		public UserEmployed(UserEmployed other)
		{
		}

		[DebuggerNonUserCode]
		public UserEmployed Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(UserEmployed other)
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
		public void MergeFrom(UserEmployed other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
