using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Apmod
{
	public sealed class RankSrcs : IMessage<RankSrcs>, IMessage, IEquatable<RankSrcs>, IDeepCloneable<RankSrcs>
	{
		private static readonly MessageParser<RankSrcs> _parser;

		public const int SrcsFieldNumber = 1;

		private static readonly FieldCodec<Src> _repeated_srcs_codec;

		private readonly RepeatedField<Src> srcs_;

		public const int BlackListFieldNumber = 2;

		private static readonly MapField<long, bool>.Codec _map_blackList_codec;

		private readonly MapField<long, bool> blackList_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<RankSrcs> Parser
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
		public RepeatedField<Src> Srcs
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public MapField<long, bool> BlackList
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RankSrcs()
		{
		}

		[DebuggerNonUserCode]
		public RankSrcs(RankSrcs other)
		{
		}

		[DebuggerNonUserCode]
		public RankSrcs Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(RankSrcs other)
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
		public void MergeFrom(RankSrcs other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
