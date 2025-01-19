using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	internal sealed class UninterpretedOption : IMessage<UninterpretedOption>, IMessage, IEquatable<UninterpretedOption>, IDeepCloneable<UninterpretedOption>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal sealed class NamePart : IMessage<NamePart>, IMessage, IEquatable<NamePart>, IDeepCloneable<NamePart>
			{
				private static readonly MessageParser<NamePart> _parser;

				public const int NamePart_FieldNumber = 1;

				private string namePart_;

				public const int IsExtensionFieldNumber = 2;

				private bool isExtension_;

				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return null;
					}
				}

				[DebuggerNonUserCode]
				public static MessageParser<NamePart> Parser
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
				public string NamePart_
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
				public bool IsExtension
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
				public NamePart()
				{
				}

				[DebuggerNonUserCode]
				public NamePart(NamePart other)
				{
				}

				[DebuggerNonUserCode]
				public NamePart Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return false;
				}

				[DebuggerNonUserCode]
				public bool Equals(NamePart other)
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
				public void MergeFrom(NamePart other)
				{
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}
			}
		}

		private static readonly MessageParser<UninterpretedOption> _parser;

		public const int NameFieldNumber = 2;

		private static readonly FieldCodec<Types.NamePart> _repeated_name_codec;

		private readonly RepeatedField<Types.NamePart> name_;

		public const int IdentifierValueFieldNumber = 3;

		private string identifierValue_;

		public const int PositiveIntValueFieldNumber = 4;

		private ulong positiveIntValue_;

		public const int NegativeIntValueFieldNumber = 5;

		private long negativeIntValue_;

		public const int DoubleValueFieldNumber = 6;

		private double doubleValue_;

		public const int StringValueFieldNumber = 7;

		private ByteString stringValue_;

		public const int AggregateValueFieldNumber = 8;

		private string aggregateValue_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<UninterpretedOption> Parser
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
		public RepeatedField<Types.NamePart> Name
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public string IdentifierValue
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
		public ulong PositiveIntValue
		{
			get
			{
				return 0uL;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public long NegativeIntValue
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
		public double DoubleValue
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public ByteString StringValue
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
		public string AggregateValue
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
		public UninterpretedOption()
		{
		}

		[DebuggerNonUserCode]
		public UninterpretedOption(UninterpretedOption other)
		{
		}

		[DebuggerNonUserCode]
		public UninterpretedOption Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(UninterpretedOption other)
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
		public void MergeFrom(UninterpretedOption other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
