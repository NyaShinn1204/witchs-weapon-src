using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Combatmod
{
	public sealed class EffectArgumentInfo : IMessage<EffectArgumentInfo>, IMessage, IEquatable<EffectArgumentInfo>, IDeepCloneable<EffectArgumentInfo>
	{
		private static readonly MessageParser<EffectArgumentInfo> _parser;

		public const int IDFieldNumber = 1;

		private long iD_;

		public const int PriorityFieldNumber = 2;

		private int priority_;

		public const int Argument0FieldNumber = 3;

		private string argument0_;

		public const int Argument1FieldNumber = 4;

		private long argument1_;

		public const int Argument2FieldNumber = 5;

		private long argument2_;

		public const int Argument3FieldNumber = 6;

		private long argument3_;

		public const int Argument4FieldNumber = 7;

		private int argument4_;

		public const int Argument5FieldNumber = 8;

		private int argument5_;

		public const int Argument6FieldNumber = 9;

		private int argument6_;

		public const int Argument7FieldNumber = 10;

		private int argument7_;

		public const int Argument8FieldNumber = 11;

		private int argument8_;

		public const int Argument9FieldNumber = 12;

		private int argument9_;

		public const int Argument10FieldNumber = 13;

		private int argument10_;

		public const int Argument11FieldNumber = 14;

		private int argument11_;

		public const int Argument12FieldNumber = 15;

		private int argument12_;

		public const int Argument13FieldNumber = 16;

		private int argument13_;

		public const int Argument14FieldNumber = 17;

		private int argument14_;

		public const int Argument15FieldNumber = 18;

		private int argument15_;

		public const int Argument16FieldNumber = 19;

		private int argument16_;

		public const int Argument17FieldNumber = 20;

		private int argument17_;

		public const int Argument18FieldNumber = 21;

		private int argument18_;

		public const int Argument19FieldNumber = 22;

		private int argument19_;

		public const int Argument20FieldNumber = 23;

		private int argument20_;

		public const int Argument21FieldNumber = 24;

		private int argument21_;

		public const int Argument22FieldNumber = 25;

		private int argument22_;

		public const int Argument23FieldNumber = 26;

		private int argument23_;

		public const int Argument24FieldNumber = 27;

		private int argument24_;

		public const int Argument25FieldNumber = 28;

		private int argument25_;

		public const int Argument26FieldNumber = 29;

		private int argument26_;

		public const int Argument27FieldNumber = 30;

		private int argument27_;

		public const int Argument28FieldNumber = 31;

		private int argument28_;

		public const int Argument29FieldNumber = 32;

		private int argument29_;

		public const int Argument30FieldNumber = 33;

		private int argument30_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<EffectArgumentInfo> Parser
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
		public long ID
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
		public int Priority
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
		public string Argument0
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
		public long Argument1
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
		public long Argument2
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
		public long Argument3
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
		public int Argument4
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
		public int Argument5
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
		public int Argument6
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
		public int Argument7
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
		public int Argument8
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
		public int Argument9
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
		public int Argument10
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
		public int Argument11
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
		public int Argument12
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
		public int Argument13
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
		public int Argument14
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
		public int Argument15
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
		public int Argument16
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
		public int Argument17
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
		public int Argument18
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
		public int Argument19
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
		public int Argument20
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
		public int Argument21
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
		public int Argument22
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
		public int Argument23
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
		public int Argument24
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
		public int Argument25
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
		public int Argument26
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
		public int Argument27
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
		public int Argument28
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
		public int Argument29
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
		public int Argument30
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
		public EffectArgumentInfo()
		{
		}

		[DebuggerNonUserCode]
		public EffectArgumentInfo(EffectArgumentInfo other)
		{
		}

		[DebuggerNonUserCode]
		public EffectArgumentInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(EffectArgumentInfo other)
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
		public void MergeFrom(EffectArgumentInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
