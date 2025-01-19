using System;
using System.Diagnostics;
using Google.Protobuf.Collections;

namespace Google.Protobuf.Reflection
{
	internal sealed class SourceCodeInfo : IMessage<SourceCodeInfo>, IMessage, IEquatable<SourceCodeInfo>, IDeepCloneable<SourceCodeInfo>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			internal sealed class Location : IMessage<Location>, IMessage, IEquatable<Location>, IDeepCloneable<Location>
			{
				private static readonly MessageParser<Location> _parser;

				public const int PathFieldNumber = 1;

				private static readonly FieldCodec<int> _repeated_path_codec;

				private readonly RepeatedField<int> path_;

				public const int SpanFieldNumber = 2;

				private static readonly FieldCodec<int> _repeated_span_codec;

				private readonly RepeatedField<int> span_;

				public const int LeadingCommentsFieldNumber = 3;

				private string leadingComments_;

				public const int TrailingCommentsFieldNumber = 4;

				private string trailingComments_;

				public const int LeadingDetachedCommentsFieldNumber = 6;

				private static readonly FieldCodec<string> _repeated_leadingDetachedComments_codec;

				private readonly RepeatedField<string> leadingDetachedComments_;

				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return null;
					}
				}

				[DebuggerNonUserCode]
				public static MessageParser<Location> Parser
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
				public RepeatedField<int> Span
				{
					get
					{
						return null;
					}
				}

				[DebuggerNonUserCode]
				public string LeadingComments
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
				public string TrailingComments
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
				public RepeatedField<string> LeadingDetachedComments
				{
					get
					{
						return null;
					}
				}

				[DebuggerNonUserCode]
				public Location()
				{
				}

				[DebuggerNonUserCode]
				public Location(Location other)
				{
				}

				[DebuggerNonUserCode]
				public Location Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return false;
				}

				[DebuggerNonUserCode]
				public bool Equals(Location other)
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
				public void MergeFrom(Location other)
				{
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}
			}
		}

		private static readonly MessageParser<SourceCodeInfo> _parser;

		public const int LocationFieldNumber = 1;

		private static readonly FieldCodec<Types.Location> _repeated_location_codec;

		private readonly RepeatedField<Types.Location> location_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<SourceCodeInfo> Parser
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
		public RepeatedField<Types.Location> Location
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public SourceCodeInfo()
		{
		}

		[DebuggerNonUserCode]
		public SourceCodeInfo(SourceCodeInfo other)
		{
		}

		[DebuggerNonUserCode]
		public SourceCodeInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(SourceCodeInfo other)
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
		public void MergeFrom(SourceCodeInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
