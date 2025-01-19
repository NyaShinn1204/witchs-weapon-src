using System;
using System.Diagnostics;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class Any : IMessage<Any>, IMessage, IEquatable<Any>, IDeepCloneable<Any>
	{
		private static readonly MessageParser<Any> _parser;

		public const int TypeUrlFieldNumber = 1;

		private string typeUrl_;

		public const int ValueFieldNumber = 2;

		private ByteString value_;

		private const string DefaultPrefix = "type.googleapis.com";

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<Any> Parser
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
		public string TypeUrl
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
		public ByteString Value
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
		public Any()
		{
		}

		[DebuggerNonUserCode]
		public Any(Any other)
		{
		}

		[DebuggerNonUserCode]
		public Any Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Any other)
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
		public void MergeFrom(Any other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		private static string GetTypeUrl(MessageDescriptor descriptor, string prefix)
		{
			return null;
		}

		internal static string GetTypeName(string typeUrl)
		{
			return null;
		}

		public T Unpack<T>() where T : IMessage, new()
		{
			return default(T);
		}

		public static Any Pack(IMessage message)
		{
			return null;
		}

		public static Any Pack(IMessage message, string typeUrlPrefix)
		{
			return null;
		}
	}
}
