using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Activitymod
{
	public sealed class PersonDraw : IMessage<PersonDraw>, IMessage, IEquatable<PersonDraw>, IDeepCloneable<PersonDraw>
	{
		private static readonly MessageParser<PersonDraw> _parser;

		public const int DrawListFieldNumber = 1;

		private static readonly FieldCodec<PersonDrawInfo> _repeated_drawList_codec;

		private readonly RepeatedField<PersonDrawInfo> drawList_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<PersonDraw> Parser
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
		public RepeatedField<PersonDrawInfo> DrawList
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public PersonDraw()
		{
		}

		[DebuggerNonUserCode]
		public PersonDraw(PersonDraw other)
		{
		}

		[DebuggerNonUserCode]
		public PersonDraw Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(PersonDraw other)
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
		public void MergeFrom(PersonDraw other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
