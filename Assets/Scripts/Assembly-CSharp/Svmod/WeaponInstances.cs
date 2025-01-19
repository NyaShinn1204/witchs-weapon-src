using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Svmod
{
	public sealed class WeaponInstances : IMessage<WeaponInstances>, IMessage, IEquatable<WeaponInstances>, IDeepCloneable<WeaponInstances>
	{
		private static readonly MessageParser<WeaponInstances> _parser;

		public const int WeaponInstanceFieldNumber = 1;

		private static readonly FieldCodec<WeaponInstance> _repeated_weaponInstance_codec;

		private readonly RepeatedField<WeaponInstance> weaponInstance_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<WeaponInstances> Parser
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
		public RepeatedField<WeaponInstance> WeaponInstance
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public WeaponInstances()
		{
		}

		[DebuggerNonUserCode]
		public WeaponInstances(WeaponInstances other)
		{
		}

		[DebuggerNonUserCode]
		public WeaponInstances Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(WeaponInstances other)
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
		public void MergeFrom(WeaponInstances other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
