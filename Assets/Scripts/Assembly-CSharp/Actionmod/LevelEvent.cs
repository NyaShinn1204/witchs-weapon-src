using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Actionmod
{
	public sealed class LevelEvent : IMessage<LevelEvent>, IMessage, IEquatable<LevelEvent>, IDeepCloneable<LevelEvent>
	{
		private static readonly MessageParser<LevelEvent> _parser;

		public const int NameFieldNumber = 1;

		private string name_;

		public const int ValueFieldNumber = 2;

		private static readonly FieldCodec<string> _repeated_value_codec;

		private readonly RepeatedField<string> value_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<LevelEvent> Parser
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
		public string Name
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
		public RepeatedField<string> Value
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public LevelEvent()
		{
		}

		[DebuggerNonUserCode]
		public LevelEvent(LevelEvent other)
		{
		}

		[DebuggerNonUserCode]
		public LevelEvent Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(LevelEvent other)
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
		public void MergeFrom(LevelEvent other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
