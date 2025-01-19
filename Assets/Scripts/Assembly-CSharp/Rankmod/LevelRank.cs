using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Rankmod
{
	public sealed class LevelRank : IMessage<LevelRank>, IMessage, IEquatable<LevelRank>, IDeepCloneable<LevelRank>
	{
		private static readonly MessageParser<LevelRank> _parser;

		public const int DataFieldNumber = 1;

		private static readonly FieldCodec<RoleBattleInfo> _repeated_data_codec;

		private readonly RepeatedField<RoleBattleInfo> data_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<LevelRank> Parser
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
		public RepeatedField<RoleBattleInfo> Data
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public LevelRank()
		{
		}

		[DebuggerNonUserCode]
		public LevelRank(LevelRank other)
		{
		}

		[DebuggerNonUserCode]
		public LevelRank Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(LevelRank other)
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
		public void MergeFrom(LevelRank other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
