using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Levelmod
{
	public sealed class Chap : IMessage<Chap>, IMessage, IEquatable<Chap>, IDeepCloneable<Chap>
	{
		private static readonly MessageParser<Chap> _parser;

		public const int IDFieldNumber = 1;

		private long iD_;

		public const int LevelsFieldNumber = 2;

		private static readonly FieldCodec<Level> _repeated_levels_codec;

		private readonly RepeatedField<Level> levels_;

		public const int VersionFieldNumber = 3;

		private int version_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<Chap> Parser
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
		public RepeatedField<Level> Levels
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int Version
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
		public Chap()
		{
		}

		[DebuggerNonUserCode]
		public Chap(Chap other)
		{
		}

		[DebuggerNonUserCode]
		public Chap Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Chap other)
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
		public void MergeFrom(Chap other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
