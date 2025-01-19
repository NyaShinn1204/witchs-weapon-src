using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Achievemod
{
	public sealed class MetaCM : IMessage<MetaCM>, IMessage, IEquatable<MetaCM>, IDeepCloneable<MetaCM>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public sealed class Obj : IMessage<Obj>, IMessage, IEquatable<Obj>, IDeepCloneable<Obj>
			{
				private static readonly MessageParser<Obj> _parser;

				public const int Arg1FieldNumber = 1;

				private int arg1_;

				public const int Arg2FieldNumber = 2;

				private long arg2_;

				public const int Arg3FieldNumber = 3;

				private long arg3_;

				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return null;
					}
				}

				[DebuggerNonUserCode]
				public static MessageParser<Obj> Parser
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
				public int Arg1
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
				public long Arg2
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
				public long Arg3
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
				public Obj()
				{
				}

				[DebuggerNonUserCode]
				public Obj(Obj other)
				{
				}

				[DebuggerNonUserCode]
				public Obj Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return false;
				}

				[DebuggerNonUserCode]
				public bool Equals(Obj other)
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
				public void MergeFrom(Obj other)
				{
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}
			}
		}

		private static readonly MessageParser<MetaCM> _parser;

		public const int DataFieldNumber = 1;

		private static readonly FieldCodec<Types.Obj> _repeated_data_codec;

		private readonly RepeatedField<Types.Obj> data_;

		public const int CountFieldNumber = 2;

		private int count_;

		public const int LastTimeFieldNumber = 3;

		private long lastTime_;

		public const int RepeatCountFieldNumber = 4;

		private int repeatCount_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<MetaCM> Parser
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
		public RepeatedField<Types.Obj> Data
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int Count
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
		public long LastTime
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
		public int RepeatCount
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
		public MetaCM()
		{
		}

		[DebuggerNonUserCode]
		public MetaCM(MetaCM other)
		{
		}

		[DebuggerNonUserCode]
		public MetaCM Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(MetaCM other)
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
		public void MergeFrom(MetaCM other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
