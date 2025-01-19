using System;
using System.Collections.Generic;
using System.Diagnostics;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Google.Protobuf.WellKnownTypes
{
	public sealed class FieldMask : IMessage<FieldMask>, ICustomDiagnosticMessage, IMessage, IEquatable<FieldMask>, IDeepCloneable<FieldMask>
	{
		private static readonly MessageParser<FieldMask> _parser;

		public const int PathsFieldNumber = 1;

		private static readonly FieldCodec<string> _repeated_paths_codec;

		private readonly RepeatedField<string> paths_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<FieldMask> Parser
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
		public RepeatedField<string> Paths
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public FieldMask()
		{
		}

		[DebuggerNonUserCode]
		public FieldMask(FieldMask other)
		{
		}

		[DebuggerNonUserCode]
		public FieldMask Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(FieldMask other)
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
		public void MergeFrom(FieldMask other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}

		internal static string ToJson(IList<string> paths, bool diagnosticOnly)
		{
			return null;
		}

		private static bool ValidatePath(string input)
		{
			return false;
		}

		public string ToDiagnosticString()
		{
			return null;
		}
	}
}
