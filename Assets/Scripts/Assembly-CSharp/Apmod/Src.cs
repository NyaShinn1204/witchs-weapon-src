using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Apmod
{
	public sealed class Src : IMessage<Src>, IMessage, IEquatable<Src>, IDeepCloneable<Src>
	{
		private static readonly MessageParser<Src> _parser;

		public const int RoleIDFieldNumber = 100;

		private long roleID_;

		public const int Rank1FieldNumber = 101;

		private int rank1_;

		public const int Rank2FieldNumber = 102;

		private int rank2_;

		public const int Rank3FieldNumber = 103;

		private long rank3_;

		public const int Rank4FieldNumber = 104;

		private long rank4_;

		public const int Rank5FieldNumber = 105;

		private string rank5_;

		public const int Rank6FieldNumber = 106;

		private string rank6_;

		public const int TimeFieldNumber = 107;

		private long time_;

		public const int OtherInfoFieldNumber = 108;

		private OtherInfo otherInfo_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<Src> Parser
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
		public long RoleID
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
		public int Rank1
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
		public int Rank2
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
		public long Rank3
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
		public long Rank4
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
		public string Rank5
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
		public string Rank6
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
		public long Time
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
		public OtherInfo OtherInfo
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
		public Src()
		{
		}

		[DebuggerNonUserCode]
		public Src(Src other)
		{
		}

		[DebuggerNonUserCode]
		public Src Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Src other)
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
		public void MergeFrom(Src other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
