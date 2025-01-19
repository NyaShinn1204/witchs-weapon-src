using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Logmod
{
	public sealed class DrawResult : IMessage<DrawResult>, IMessage, IEquatable<DrawResult>, IDeepCloneable<DrawResult>
	{
		private static readonly MessageParser<DrawResult> _parser;

		public const int DrawResultByVersionFieldNumber = 1;

		private static readonly MapField<int, DrawResultByVersion>.Codec _map_drawResultByVersion_codec;

		private readonly MapField<int, DrawResultByVersion> drawResultByVersion_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<DrawResult> Parser
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
		public MapField<int, DrawResultByVersion> DrawResultByVersion
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public DrawResult()
		{
		}

		[DebuggerNonUserCode]
		public DrawResult(DrawResult other)
		{
		}

		[DebuggerNonUserCode]
		public DrawResult Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(DrawResult other)
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
		public void MergeFrom(DrawResult other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
