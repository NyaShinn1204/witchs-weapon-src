using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Activitymod
{
	public sealed class CampInfo : IMessage<CampInfo>, IMessage, IEquatable<CampInfo>, IDeepCloneable<CampInfo>
	{
		private static readonly MessageParser<CampInfo> _parser;

		public const int CampInfo_FieldNumber = 1;

		private static readonly MapField<long, long>.Codec _map_campInfo_codec;

		private readonly MapField<long, long> campInfo_;

		public const int IsLockFieldNumber = 3;

		private bool isLock_;

		public const int CampSetIDFieldNumber = 2;

		private string campSetID_;

		public const int CloseTimeFieldNumber = 4;

		private long closeTime_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<CampInfo> Parser
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
		public MapField<long, long> CampInfo_
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public bool IsLock
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
		public string CampSetID
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
		public long CloseTime
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public CampInfo()
		{
		}

		[DebuggerNonUserCode]
		public CampInfo(CampInfo other)
		{
		}

		[DebuggerNonUserCode]
		public CampInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(CampInfo other)
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
		public void MergeFrom(CampInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
