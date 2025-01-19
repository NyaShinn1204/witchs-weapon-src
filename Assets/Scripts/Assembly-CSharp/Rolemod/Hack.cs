using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Rolemod
{
	public sealed class Hack : IMessage<Hack>, IMessage, IEquatable<Hack>, IDeepCloneable<Hack>
	{
		private static readonly MessageParser<Hack> _parser;

		public const int SuspicionFieldNumber = 1;

		private static readonly FieldCodec<int> _repeated_suspicion_codec;

		private readonly RepeatedField<int> suspicion_;

		public const int SuspicionForOneGameFieldNumber = 2;

		private static readonly FieldCodec<SuspicionForOneGame> _repeated_suspicionForOneGame_codec;

		private readonly RepeatedField<SuspicionForOneGame> suspicionForOneGame_;

		public const int TotalSuspicionFieldNumber = 100;

		private int totalSuspicion_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<Hack> Parser
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
		public RepeatedField<int> Suspicion
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<SuspicionForOneGame> SuspicionForOneGame
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int TotalSuspicion
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
		public Hack()
		{
		}

		[DebuggerNonUserCode]
		public Hack(Hack other)
		{
		}

		[DebuggerNonUserCode]
		public Hack Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Hack other)
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
		public void MergeFrom(Hack other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
