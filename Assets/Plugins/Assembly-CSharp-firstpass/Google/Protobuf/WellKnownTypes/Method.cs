using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class Method : IMessage<Method>, IMessage, IEquatable<Method>, IDeepCloneable<Method>
	{
		private static readonly MessageParser<Method> _parser;

		public const int NameFieldNumber = 1;

		private string name_;

		public const int RequestTypeUrlFieldNumber = 2;

		private string requestTypeUrl_;

		public const int RequestStreamingFieldNumber = 3;

		private bool requestStreaming_;

		public const int ResponseTypeUrlFieldNumber = 4;

		private string responseTypeUrl_;

		public const int ResponseStreamingFieldNumber = 5;

		private bool responseStreaming_;

		public const int OptionsFieldNumber = 6;

		private static readonly FieldCodec<Option> _repeated_options_codec;

		private readonly RepeatedField<Option> options_;

		public const int SyntaxFieldNumber = 7;

		private Syntax syntax_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<Method> Parser
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
		public string Name
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
		public string RequestTypeUrl
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
		public bool RequestStreaming
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
		public string ResponseTypeUrl
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
		public bool ResponseStreaming
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
		public RepeatedField<Option> Options
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public Syntax Syntax
		{
			get
			{
				return default(Syntax);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public Method()
		{
		}

		[DebuggerNonUserCode]
		public Method(Method other)
		{
		}

		[DebuggerNonUserCode]
		public Method Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Method other)
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
		public void MergeFrom(Method other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
