using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Guidemod
{
	public sealed class GuidesProto : IMessage<GuidesProto>, IMessage, IEquatable<GuidesProto>, IDeepCloneable<GuidesProto>
	{
		private static readonly MessageParser<GuidesProto> _parser;

		public const int GuidePointInfoFieldNumber = 1;

		private static readonly FieldCodec<GuidePointInfo> _repeated_guidePointInfo_codec;

		private readonly RepeatedField<GuidePointInfo> guidePointInfo_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<GuidesProto> Parser
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
		public RepeatedField<GuidePointInfo> GuidePointInfo
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public GuidesProto()
		{
		}

		[DebuggerNonUserCode]
		public GuidesProto(GuidesProto other)
		{
		}

		[DebuggerNonUserCode]
		public GuidesProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GuidesProto other)
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
		public void MergeFrom(GuidesProto other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
