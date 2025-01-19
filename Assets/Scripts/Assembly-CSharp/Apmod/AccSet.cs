using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Apmod
{
	public sealed class AccSet : IMessage<AccSet>, IMessage, IEquatable<AccSet>, IDeepCloneable<AccSet>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public sealed class Level : IMessage<Level>, IMessage, IEquatable<Level>, IDeepCloneable<Level>
			{
				private static readonly MessageParser<Level> _parser;

				public const int IDFieldNumber = 1;

				private long iD_;

				public const int BattleCountFieldNumber = 2;

				private int battleCount_;

				public const int SweepFieldNumber = 3;

				private bool sweep_;

				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return null;
					}
				}

				[DebuggerNonUserCode]
				public static MessageParser<Level> Parser
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
				public int BattleCount
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
				public bool Sweep
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
				public Level()
				{
				}

				[DebuggerNonUserCode]
				public Level(Level other)
				{
				}

				[DebuggerNonUserCode]
				public Level Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return false;
				}

				[DebuggerNonUserCode]
				public bool Equals(Level other)
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
				public void MergeFrom(Level other)
				{
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}
			}
		}

		private static readonly MessageParser<AccSet> _parser;

		public const int SetIDFieldNumber = 1;

		private long setID_;

		public const int LevelsFieldNumber = 2;

		private static readonly FieldCodec<Types.Level> _repeated_levels_codec;

		private readonly RepeatedField<Types.Level> levels_;

		public const int CountFieldNumber = 3;

		private int count_;

		public const int LastPlayFieldNumber = 4;

		private long lastPlay_;

		public const int StartPlayFieldNumber = 5;

		private long startPlay_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<AccSet> Parser
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
		public long SetID
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
		public RepeatedField<Types.Level> Levels
		{
			get
			{
				return null;
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
		public long LastPlay
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
		public long StartPlay
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
		public AccSet()
		{
		}

		[DebuggerNonUserCode]
		public AccSet(AccSet other)
		{
		}

		[DebuggerNonUserCode]
		public AccSet Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(AccSet other)
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
		public void MergeFrom(AccSet other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
