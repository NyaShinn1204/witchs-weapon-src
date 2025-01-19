using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Achievemod
{
	public sealed class CurTypeNodes : IMessage<CurTypeNodes>, IMessage, IEquatable<CurTypeNodes>, IDeepCloneable<CurTypeNodes>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public sealed class CurNodes : IMessage<CurNodes>, IMessage, IEquatable<CurNodes>, IDeepCloneable<CurNodes>
			{
				[DebuggerNonUserCode]
				public static class Types
				{
					public sealed class Goal : IMessage<Goal>, IMessage, IEquatable<Goal>, IDeepCloneable<Goal>
					{
						private static readonly MessageParser<Goal> _parser;

						public const int IDFieldNumber = 1;

						private long iD_;

						public const int EndTimeFieldNumber = 2;

						private long endTime_;

						[DebuggerNonUserCode]
						MessageDescriptor IMessage.Descriptor
						{
							get
							{
								return null;
							}
						}

						[DebuggerNonUserCode]
						public static MessageParser<Goal> Parser
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
						public long ID
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
						public long EndTime
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
						public Goal()
						{
						}

						[DebuggerNonUserCode]
						public Goal(Goal other)
						{
						}

						[DebuggerNonUserCode]
						public Goal Clone()
						{
							return null;
						}

						[DebuggerNonUserCode]
						public override bool Equals(object other)
						{
							return false;
						}

						[DebuggerNonUserCode]
						public bool Equals(Goal other)
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
						public void MergeFrom(Goal other)
						{
						}

						[DebuggerNonUserCode]
						public void MergeFrom(CodedInputStream input)
						{
						}
					}
				}

				private static readonly MessageParser<CurNodes> _parser;

				public const int TypeFieldNumber = 1;

				private string type_;

				public const int NodesFieldNumber = 2;

				private static readonly FieldCodec<Types.Goal> _repeated_nodes_codec;

				private readonly RepeatedField<Types.Goal> nodes_;

				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return null;
					}
				}

				[DebuggerNonUserCode]
				public static MessageParser<CurNodes> Parser
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
				public string Type
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
				public RepeatedField<Types.Goal> Nodes
				{
					get
					{
						return null;
					}
				}

				[DebuggerNonUserCode]
				public CurNodes()
				{
				}

				[DebuggerNonUserCode]
				public CurNodes(CurNodes other)
				{
				}

				[DebuggerNonUserCode]
				public CurNodes Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return false;
				}

				[DebuggerNonUserCode]
				public bool Equals(CurNodes other)
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
				public void MergeFrom(CurNodes other)
				{
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}
			}
		}

		private static readonly MessageParser<CurTypeNodes> _parser;

		public const int DataFieldNumber = 1;

		private static readonly FieldCodec<Types.CurNodes> _repeated_data_codec;

		private readonly RepeatedField<Types.CurNodes> data_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<CurTypeNodes> Parser
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
		public RepeatedField<Types.CurNodes> Data
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public CurTypeNodes()
		{
		}

		[DebuggerNonUserCode]
		public CurTypeNodes(CurTypeNodes other)
		{
		}

		[DebuggerNonUserCode]
		public CurTypeNodes Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(CurTypeNodes other)
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
		public void MergeFrom(CurTypeNodes other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
