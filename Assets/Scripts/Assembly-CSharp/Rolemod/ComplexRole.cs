using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Rolemod
{
	public sealed class ComplexRole : IMessage<ComplexRole>, IMessage, IEquatable<ComplexRole>, IDeepCloneable<ComplexRole>
	{
		private static readonly MessageParser<ComplexRole> _parser;

		public const int RoleInstanceProtoFieldNumber = 1;

		private RoleInstanceProto roleInstanceProto_;

		public const int RoleTimeInstanceFieldNumber = 2;

		private RoleTimeInstance roleTimeInstance_;

		public const int FashionInstancesFieldNumber = 3;

		private static readonly FieldCodec<FashionInstance> _repeated_fashionInstances_codec;

		private readonly RepeatedField<FashionInstance> fashionInstances_;

		public const int PreRoleLevelFieldNumber = 4;

		private int preRoleLevel_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<ComplexRole> Parser
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
		public RoleInstanceProto RoleInstanceProto
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
		public RoleTimeInstance RoleTimeInstance
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
		public RepeatedField<FashionInstance> FashionInstances
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int PreRoleLevel
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
		public ComplexRole()
		{
		}

		[DebuggerNonUserCode]
		public ComplexRole(ComplexRole other)
		{
		}

		[DebuggerNonUserCode]
		public ComplexRole Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ComplexRole other)
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
		public void MergeFrom(ComplexRole other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
