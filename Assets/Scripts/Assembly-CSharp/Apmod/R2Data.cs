using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Apmod
{
	public sealed class R2Data : IMessage<R2Data>, IMessage, IEquatable<R2Data>, IDeepCloneable<R2Data>
	{
		private static readonly MessageParser<R2Data> _parser;

		public const int MaxFloorFieldNumber = 8;

		private int maxFloor_;

		public const int FloorFieldNumber = 1;

		private int floor_;

		public const int BuffsFieldNumber = 2;

		private static readonly FieldCodec<long> _repeated_buffs_codec;

		private readonly RepeatedField<long> buffs_;

		public const int LevelsFieldNumber = 3;

		private static readonly FieldCodec<long> _repeated_levels_codec;

		private readonly RepeatedField<long> levels_;

		public const int NextBuffsFieldNumber = 4;

		private static readonly FieldCodec<long> _repeated_nextBuffs_codec;

		private readonly RepeatedField<long> nextBuffs_;

		public const int NextLevelsFieldNumber = 5;

		private static readonly FieldCodec<long> _repeated_nextLevels_codec;

		private readonly RepeatedField<long> nextLevels_;

		public const int MobEnhanceFieldNumber = 6;

		private string mobEnhance_;

		public const int WinMarkFieldNumber = 7;

		private static readonly FieldCodec<int> _repeated_winMark_codec;

		private readonly RepeatedField<int> winMark_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<R2Data> Parser
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
		public int MaxFloor
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
		public int Floor
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
		public RepeatedField<long> Buffs
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<long> Levels
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<long> NextBuffs
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<long> NextLevels
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public string MobEnhance
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
		public RepeatedField<int> WinMark
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public R2Data()
		{
		}

		[DebuggerNonUserCode]
		public R2Data(R2Data other)
		{
		}

		[DebuggerNonUserCode]
		public R2Data Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(R2Data other)
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
		public void MergeFrom(R2Data other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
