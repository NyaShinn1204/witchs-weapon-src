using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Combatmod
{
	public sealed class Basket : IMessage<Basket>, IMessage, IEquatable<Basket>, IDeepCloneable<Basket>
	{
		private static readonly MessageParser<Basket> _parser;

		public const int SpellInfosFieldNumber = 1;

		private static readonly FieldCodec<SpellInfo> _repeated_spellInfos_codec;

		private readonly RepeatedField<SpellInfo> spellInfos_;

		public const int BuffInfosFieldNumber = 2;

		private static readonly FieldCodec<BuffInfo> _repeated_buffInfos_codec;

		private readonly RepeatedField<BuffInfo> buffInfos_;

		public const int AgentInfosFieldNumber = 3;

		private static readonly FieldCodec<AgentInfo> _repeated_agentInfos_codec;

		private readonly RepeatedField<AgentInfo> agentInfos_;

		public const int TriggerInfosFieldNumber = 4;

		private static readonly FieldCodec<TriggerInfo> _repeated_triggerInfos_codec;

		private readonly RepeatedField<TriggerInfo> triggerInfos_;

		public const int MobInfosFieldNumber = 5;

		private static readonly FieldCodec<MobInfo> _repeated_mobInfos_codec;

		private readonly RepeatedField<MobInfo> mobInfos_;

		public const int MobTypeInfosFieldNumber = 6;

		private static readonly FieldCodec<MobTypeInfo> _repeated_mobTypeInfos_codec;

		private readonly RepeatedField<MobTypeInfo> mobTypeInfos_;

		public const int EffectArgumentInfosFieldNumber = 7;

		private static readonly FieldCodec<EffectArgumentInfo> _repeated_effectArgumentInfos_codec;

		private readonly RepeatedField<EffectArgumentInfo> effectArgumentInfos_;

		public const int BehaviorTreeArgumentInfosFieldNumber = 8;

		private static readonly FieldCodec<BehaviorTreeArgumentInfo> _repeated_behaviorTreeArgumentInfos_codec;

		private readonly RepeatedField<BehaviorTreeArgumentInfo> behaviorTreeArgumentInfos_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<Basket> Parser
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
		public RepeatedField<SpellInfo> SpellInfos
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<BuffInfo> BuffInfos
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<AgentInfo> AgentInfos
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<TriggerInfo> TriggerInfos
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<MobInfo> MobInfos
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<MobTypeInfo> MobTypeInfos
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<EffectArgumentInfo> EffectArgumentInfos
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<BehaviorTreeArgumentInfo> BehaviorTreeArgumentInfos
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public Basket()
		{
		}

		[DebuggerNonUserCode]
		public Basket(Basket other)
		{
		}

		[DebuggerNonUserCode]
		public Basket Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(Basket other)
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
		public void MergeFrom(Basket other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
