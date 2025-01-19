using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Guidemod
{
	public sealed class GuideDBProto : IMessage<GuideDBProto>, IMessage, IEquatable<GuideDBProto>, IDeepCloneable<GuideDBProto>
	{
		private static readonly MessageParser<GuideDBProto> _parser;

		public const int GuidesProtoFieldNumber = 1;

		private GuidesProto guidesProto_;

		public const int GuideDraw1FieldNumber = 2;

		private bool guideDraw1_;

		public const int GuideDraw2FieldNumber = 3;

		private bool guideDraw2_;

		public const int GuideDraw3FieldNumber = 4;

		private bool guideDraw3_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<GuideDBProto> Parser
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
		public GuidesProto GuidesProto
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
		public bool GuideDraw1
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool GuideDraw2
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool GuideDraw3
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public GuideDBProto()
		{
		}

		[DebuggerNonUserCode]
		public GuideDBProto(GuideDBProto other)
		{
		}

		[DebuggerNonUserCode]
		public GuideDBProto Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GuideDBProto other)
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
		public void MergeFrom(GuideDBProto other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
