using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Shopmod
{
	public sealed class PendingData : IMessage<PendingData>, IMessage, IEquatable<PendingData>, IDeepCloneable<PendingData>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public sealed class Goods : IMessage<Goods>, IMessage, IEquatable<Goods>, IDeepCloneable<Goods>
			{
				private static readonly MessageParser<Goods> _parser;

				public const int SetIDFieldNumber = 1;

				private long setID_;

				public const int ShopIDFieldNumber = 2;

				private long shopID_;

				public const int GoodsIDFieldNumber = 3;

				private long goodsID_;

				public const int OrderFieldNumber = 4;

				private string order_;

				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return null;
					}
				}

				[DebuggerNonUserCode]
				public static MessageParser<Goods> Parser
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
				public long SetID
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
				public long ShopID
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
				public long GoodsID
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
				public string Order
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
				public Goods()
				{
				}

				[DebuggerNonUserCode]
				public Goods(Goods other)
				{
				}

				[DebuggerNonUserCode]
				public Goods Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return false;
				}

				[DebuggerNonUserCode]
				public bool Equals(Goods other)
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
				public void MergeFrom(Goods other)
				{
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}
			}
		}

		private static readonly MessageParser<PendingData> _parser;

		public const int DataFieldNumber = 1;

		private static readonly FieldCodec<Types.Goods> _repeated_data_codec;

		private readonly RepeatedField<Types.Goods> data_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<PendingData> Parser
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
		public RepeatedField<Types.Goods> Data
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public PendingData()
		{
		}

		[DebuggerNonUserCode]
		public PendingData(PendingData other)
		{
		}

		[DebuggerNonUserCode]
		public PendingData Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(PendingData other)
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
		public void MergeFrom(PendingData other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
