using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Bpobjmod
{
	public sealed class RuneInfo : IMessage<RuneInfo>, IMessage, IEquatable<RuneInfo>, IDeepCloneable<RuneInfo>
	{
		private static readonly MessageParser<RuneInfo> _parser;

		public const int RuneIDFieldNumber = 1;

		private int runeID_;

		public const int TypeFieldNumber = 2;

		private int type_;

		public const int ColorFieldNumber = 3;

		private int color_;

		public const int PositionFieldNumber = 4;

		private int position_;

		public const int LevelFieldNumber = 5;

		private int level_;

		public const int ExpFieldNumber = 6;

		private long exp_;

		public const int AttrTypeFieldNumber = 7;

		private static readonly FieldCodec<int> _repeated_attrType_codec;

		private readonly RepeatedField<int> attrType_;

		public const int AttrValueFieldNumber = 8;

		private static readonly FieldCodec<int> _repeated_attrValue_codec;

		private readonly RepeatedField<int> attrValue_;

		public const int FloatModulusFieldNumber = 9;

		private double floatModulus_;

		public const int LockedFieldNumber = 10;

		private bool locked_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<RuneInfo> Parser
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
		public int RuneID
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
		public int Type
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
		public int Color
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
		public int Position
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
		public int Level
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
		public long Exp
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
		public RepeatedField<int> AttrType
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> AttrValue
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public double FloatModulus
		{
			get
			{
				return 0.0;
			}
			set
			{
			}
		}

		[DebuggerNonUserCode]
		public bool Locked
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
		public RuneInfo()
		{
		}

		[DebuggerNonUserCode]
		public RuneInfo(RuneInfo other)
		{
		}

		[DebuggerNonUserCode]
		public RuneInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(RuneInfo other)
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
		public void MergeFrom(RuneInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
