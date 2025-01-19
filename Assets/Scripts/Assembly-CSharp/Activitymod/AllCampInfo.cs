using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Activitymod
{
	public sealed class AllCampInfo : IMessage<AllCampInfo>, IMessage, IEquatable<AllCampInfo>, IDeepCloneable<AllCampInfo>
	{
		private static readonly MessageParser<AllCampInfo> _parser;

		public const int CampsFieldNumber = 1;

		private static readonly FieldCodec<CampInfo> _repeated_camps_codec;

		private readonly RepeatedField<CampInfo> camps_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<AllCampInfo> Parser
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
		public RepeatedField<CampInfo> Camps
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public AllCampInfo()
		{
		}

		[DebuggerNonUserCode]
		public AllCampInfo(AllCampInfo other)
		{
		}

		[DebuggerNonUserCode]
		public AllCampInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(AllCampInfo other)
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
		public void MergeFrom(AllCampInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
