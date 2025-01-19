using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	internal sealed class FieldOptions : IMessage<FieldOptions>, IMessage, IEquatable<FieldOptions>, IDeepCloneable<FieldOptions>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal enum CType
			{
				String = 0,
				Cord = 1,
				StringPiece = 2
			}

			internal enum JSType
			{
				JsNormal = 0,
				JsString = 1,
				JsNumber = 2
			}
		}

		private static readonly MessageParser<FieldOptions> _parser;

		public const int CtypeFieldNumber = 1;

		private Types.CType ctype_;

		public const int PackedFieldNumber = 2;

		private bool packed_;

		public const int JstypeFieldNumber = 6;

		private Types.JSType jstype_;

		public const int LazyFieldNumber = 5;

		private bool lazy_;

		public const int DeprecatedFieldNumber = 3;

		private bool deprecated_;

		public const int WeakFieldNumber = 10;

		private bool weak_;

		public const int UninterpretedOptionFieldNumber = 999;

		private static readonly FieldCodec<UninterpretedOption> _repeated_uninterpretedOption_codec;

		private readonly RepeatedField<UninterpretedOption> uninterpretedOption_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<FieldOptions> Parser
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
		public Types.CType Ctype
		{
			get
			{
				return default(Types.CType);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool Packed
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
		public Types.JSType Jstype
		{
			get
			{
				return default(Types.JSType);
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool Lazy
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
		public bool Deprecated
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
		public bool Weak
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
		public RepeatedField<UninterpretedOption> UninterpretedOption
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public FieldOptions()
		{
		}

		[DebuggerNonUserCode]
		public FieldOptions(FieldOptions other)
		{
		}

		[DebuggerNonUserCode]
		public FieldOptions Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(FieldOptions other)
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
		public void MergeFrom(FieldOptions other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		private void OnConstruction()
		{
		}
	}
}
