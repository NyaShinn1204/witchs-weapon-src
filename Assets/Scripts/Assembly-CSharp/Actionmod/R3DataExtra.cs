using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Actionmod
{
	public sealed class R3DataExtra : IMessage<R3DataExtra>, IMessage, IEquatable<R3DataExtra>, IDeepCloneable<R3DataExtra>
	{
		private static readonly MessageParser<R3DataExtra> _parser;

		public const int MaxFloorFieldNumber = 4;

		private int maxFloor_;

		public const int FloorFieldNumber = 1;

		private int floor_;

		public const int LevelsFieldNumber = 2;

		private static readonly FieldCodec<R3LevelExtra> _repeated_levels_codec;

		private readonly RepeatedField<R3LevelExtra> levels_;

		public const int MobEnhanceFieldNumber = 3;

		private string mobEnhance_;

		public const int ResetFloorFieldNumber = 5;

		private int resetFloor_;

		public const int FreeCountFieldNumber = 6;

		private int freeCount_;

		public const int ResetCostFieldNumber = 7;

		private int resetCost_;

		public const int ResetCountFieldNumber = 8;

		private int resetCount_;

		public const int BattleScoreFieldNumber = 9;

		private int battleScore_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<R3DataExtra> Parser
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
		public RepeatedField<R3LevelExtra> Levels
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
		public int ResetFloor
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
		public int FreeCount
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
		public int ResetCost
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
		public int ResetCount
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
		public int BattleScore
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
		public R3DataExtra()
		{
		}

		[DebuggerNonUserCode]
		public R3DataExtra(R3DataExtra other)
		{
		}

		[DebuggerNonUserCode]
		public R3DataExtra Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(R3DataExtra other)
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
		public void MergeFrom(R3DataExtra other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
