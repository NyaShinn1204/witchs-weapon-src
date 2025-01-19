using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Apmod
{
	public sealed class RankDatas : IMessage<RankDatas>, IMessage, IEquatable<RankDatas>, IDeepCloneable<RankDatas>
	{
		private static readonly MessageParser<RankDatas> _parser;

		public const int DatasFieldNumber = 1;

		private static readonly FieldCodec<RankData> _repeated_datas_codec;

		private readonly RepeatedField<RankData> datas_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<RankDatas> Parser
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
		public RepeatedField<RankData> Datas
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RankDatas()
		{
		}

		[DebuggerNonUserCode]
		public RankDatas(RankDatas other)
		{
		}

		[DebuggerNonUserCode]
		public RankDatas Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(RankDatas other)
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
		public void MergeFrom(RankDatas other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
