using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Combatmod
{
	public sealed class CharacterLevelInfoProto : IMessage<CharacterLevelInfoProto>, IMessage, IEquatable<CharacterLevelInfoProto>, IDeepCloneable<CharacterLevelInfoProto>
	{
		private static readonly MessageParser<CharacterLevelInfoProto> _parser;

		public const int AttrLevelConstFieldNumber = 1;

		private static readonly FieldCodec<int> _repeated_attrLevelConst_codec;

		private readonly RepeatedField<int> attrLevelConst_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<CharacterLevelInfoProto> Parser
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
		public RepeatedField<int> AttrLevelConst
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public CharacterLevelInfoProto()
		{
		}

		[DebuggerNonUserCode]
		public CharacterLevelInfoProto(CharacterLevelInfoProto other)
		{
		}

		[DebuggerNonUserCode]
		public CharacterLevelInfoProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(CharacterLevelInfoProto other)
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
		public void MergeFrom(CharacterLevelInfoProto other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
