using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Rolemod
{
	public sealed class RoleMirror : IMessage<RoleMirror>, IMessage, IEquatable<RoleMirror>, IDeepCloneable<RoleMirror>
	{
		private static readonly MessageParser<RoleMirror> _parser;

		public const int RoleMirrorIDsFieldNumber = 1;

		private static readonly FieldCodec<long> _repeated_roleMirrorIDs_codec;

		private readonly RepeatedField<long> roleMirrorIDs_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<RoleMirror> Parser
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
		public RepeatedField<long> RoleMirrorIDs
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RoleMirror()
		{
		}

		[DebuggerNonUserCode]
		public RoleMirror(RoleMirror other)
		{
		}

		[DebuggerNonUserCode]
		public RoleMirror Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(RoleMirror other)
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
		public void MergeFrom(RoleMirror other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
