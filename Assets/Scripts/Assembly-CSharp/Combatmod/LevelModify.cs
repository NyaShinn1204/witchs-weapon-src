using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Combatmod
{
	public sealed class LevelModify : IMessage<LevelModify>, IMessage, IEquatable<LevelModify>, IDeepCloneable<LevelModify>
	{
		private static readonly MessageParser<LevelModify> _parser;

		public const int HitRateLevelModifyFieldNumber = 1;

		private double hitRateLevelModify_;

		public const int SpellHitRateLevelModifyFieldNumber = 2;

		private double spellHitRateLevelModify_;

		public const int CriticalRateLevelModifyFieldNumber = 3;

		private double criticalRateLevelModify_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<LevelModify> Parser
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
		public double HitRateLevelModify
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
		public double SpellHitRateLevelModify
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
		public double CriticalRateLevelModify
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
		public LevelModify()
		{
		}

		[DebuggerNonUserCode]
		public LevelModify(LevelModify other)
		{
		}

		[DebuggerNonUserCode]
		public LevelModify Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(LevelModify other)
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
		public void MergeFrom(LevelModify other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
