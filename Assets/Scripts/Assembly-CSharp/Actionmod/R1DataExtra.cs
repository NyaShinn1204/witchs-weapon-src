using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Actionmod
{
	public sealed class R1DataExtra : IMessage<R1DataExtra>, IMessage, IEquatable<R1DataExtra>, IDeepCloneable<R1DataExtra>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public sealed class LevelInfo : IMessage<LevelInfo>, IMessage, IEquatable<LevelInfo>, IDeepCloneable<LevelInfo>
			{
				private static readonly MessageParser<LevelInfo> _parser;

				public const int LevelIDFieldNumber = 1;

				private long levelID_;

				public const int MobEnhanceFieldNumber = 2;

				private string mobEnhance_;

				public const int RewardDoneFieldNumber = 3;

				private bool rewardDone_;

				public const int CountFieldNumber = 4;

				private int count_;

				public const int BattleScoreFieldNumber = 5;

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
				public static MessageParser<LevelInfo> Parser
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
				public long LevelID
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
				public bool RewardDone
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
				public int Count
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
				public LevelInfo()
				{
				}

				[DebuggerNonUserCode]
				public LevelInfo(LevelInfo other)
				{
				}

				[DebuggerNonUserCode]
				public LevelInfo Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return false;
				}

				[DebuggerNonUserCode]
				public bool Equals(LevelInfo other)
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
				public void MergeFrom(LevelInfo other)
				{
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}
			}
		}

		private static readonly MessageParser<R1DataExtra> _parser;

		public const int FloorFieldNumber = 1;

		private int floor_;

		public const int MaxFloorFieldNumber = 2;

		private int maxFloor_;

		public const int BuffsFieldNumber = 3;

		private static readonly FieldCodec<long> _repeated_buffs_codec;

		private readonly RepeatedField<long> buffs_;

		public const int LevelsFieldNumber = 4;

		private static readonly FieldCodec<Types.LevelInfo> _repeated_levels_codec;

		private readonly RepeatedField<Types.LevelInfo> levels_;

		public const int FinishedFieldNumber = 5;

		private static readonly MapField<long, long>.Codec _map_finished_codec;

		private readonly MapField<long, long> finished_;

		public const int ResetFloorFieldNumber = 6;

		private int resetFloor_;

		public const int FreeCountFieldNumber = 7;

		private int freeCount_;

		public const int ResetCostFieldNumber = 8;

		private int resetCost_;

		public const int ResetCountFieldNumber = 9;

		private int resetCount_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<R1DataExtra> Parser
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
		public RepeatedField<long> Buffs
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<Types.LevelInfo> Levels
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public MapField<long, long> Finished
		{
			get
			{
				return null;
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
		public R1DataExtra()
		{
		}

		[DebuggerNonUserCode]
		public R1DataExtra(R1DataExtra other)
		{
		}

		[DebuggerNonUserCode]
		public R1DataExtra Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(R1DataExtra other)
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
		public void MergeFrom(R1DataExtra other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
