using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	internal sealed class GeneratedCodeInfo : IMessage<GeneratedCodeInfo>, IMessage, IEquatable<GeneratedCodeInfo>, IDeepCloneable<GeneratedCodeInfo>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal sealed class Annotation : IMessage<Annotation>, IMessage, IEquatable<Annotation>, IDeepCloneable<Annotation>
			{
				private static readonly MessageParser<Annotation> _parser;

				public const int PathFieldNumber = 1;

				private static readonly FieldCodec<int> _repeated_path_codec;

				private readonly RepeatedField<int> path_;

				public const int SourceFileFieldNumber = 2;

				private string sourceFile_;

				public const int BeginFieldNumber = 3;

				private int begin_;

				public const int EndFieldNumber = 4;

				private int end_;

				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return null;
					}
				}

				[DebuggerNonUserCode]
				public static MessageParser<Annotation> Parser
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
				public RepeatedField<int> Path
				{
					get
					{
						return null;
					}
				}

				[DebuggerNonUserCode]
				public string SourceFile
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
				public int Begin
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
				public int End
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
				public Annotation()
				{
				}

				[DebuggerNonUserCode]
				public Annotation(Annotation other)
				{
				}

				[DebuggerNonUserCode]
				public Annotation Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return false;
				}

				[DebuggerNonUserCode]
				public bool Equals(Annotation other)
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
				public void MergeFrom(Annotation other)
				{
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}
			}
		}

		private static readonly MessageParser<GeneratedCodeInfo> _parser;

		public const int AnnotationFieldNumber = 1;

		private static readonly FieldCodec<Types.Annotation> _repeated_annotation_codec;

		private readonly RepeatedField<Types.Annotation> annotation_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<GeneratedCodeInfo> Parser
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
		public RepeatedField<Types.Annotation> Annotation
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public GeneratedCodeInfo()
		{
		}

		[DebuggerNonUserCode]
		public GeneratedCodeInfo(GeneratedCodeInfo other)
		{
		}

		[DebuggerNonUserCode]
		public GeneratedCodeInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GeneratedCodeInfo other)
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
		public void MergeFrom(GeneratedCodeInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
