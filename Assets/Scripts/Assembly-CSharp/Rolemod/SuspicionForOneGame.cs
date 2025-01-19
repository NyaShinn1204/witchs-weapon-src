using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Rolemod
{
	public sealed class SuspicionForOneGame : IMessage<SuspicionForOneGame>, IMessage, IEquatable<SuspicionForOneGame>, IDeepCloneable<SuspicionForOneGame>
	{
		private static readonly MessageParser<SuspicionForOneGame> _parser;

		public const int SuspicionFieldNumber = 1;

		private static readonly FieldCodec<int> _repeated_suspicion_codec;

		private readonly RepeatedField<int> suspicion_;

		public const int SuspicionCombatFieldNumber = 2;

		private static readonly FieldCodec<int> _repeated_suspicionCombat_codec;

		private readonly RepeatedField<int> suspicionCombat_;

		public const int TotalCombatFieldNumber = 100;

		private int totalCombat_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<SuspicionForOneGame> Parser
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
		public RepeatedField<int> SuspicionCombat
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int TotalCombat
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
		public SuspicionForOneGame()
		{
		}

		[DebuggerNonUserCode]
		public SuspicionForOneGame(SuspicionForOneGame other)
		{
		}

		[DebuggerNonUserCode]
		public SuspicionForOneGame Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(SuspicionForOneGame other)
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
		public void MergeFrom(SuspicionForOneGame other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
