using System;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class Api : IMessage<Api>, IMessage, IEquatable<Api>, IDeepCloneable<Api>
	{
		private static readonly MessageParser<Api> _parser;

		public const int NameFieldNumber = 1;

		private string name_;

		public const int MethodsFieldNumber = 2;

		private static readonly FieldCodec<Method> _repeated_methods_codec;

		private readonly RepeatedField<Method> methods_;

		public const int OptionsFieldNumber = 3;

		private static readonly FieldCodec<Option> _repeated_options_codec;

		private readonly RepeatedField<Option> options_;

		public const int VersionFieldNumber = 4;

		private string version_;

		public const int SourceContextFieldNumber = 5;

		private SourceContext sourceContext_;

		public const int MixinsFieldNumber = 6;

		private static readonly FieldCodec<Mixin> _repeated_mixins_codec;

		private readonly RepeatedField<Mixin> mixins_;

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
		public static MessageParser<Api> Parser
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
		public RepeatedField<Method> Methods
		{
			get
			{
				return null;
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
		public string Version
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
		public SourceContext SourceContext
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
		public RepeatedField<Mixin> Mixins
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
		public Api()
		{
		}

		[DebuggerNonUserCode]
		public Api(Api other)
		{
		}

		[DebuggerNonUserCode]
		public Api Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Api other)
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
		public void MergeFrom(Api other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
