using System;
using System.Diagnostics;
using Combatmod;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Cscmod
{
	public sealed class CscCombatInfo : IMessage<CscCombatInfo>, IMessage, IEquatable<CscCombatInfo>, IDeepCloneable<CscCombatInfo>
	{
		private static readonly MessageParser<CscCombatInfo> _parser;

		public const int SvCardIDsFieldNumber = 1;

		private static readonly FieldCodec<long> _repeated_svCardIDs_codec;

		private readonly RepeatedField<long> svCardIDs_;

		public const int SvEnegysFieldNumber = 2;

		private static readonly FieldCodec<int> _repeated_svEnegys_codec;

		private readonly RepeatedField<int> svEnegys_;

		public const int RoleHPFieldNumber = 16;

		private int roleHP_;

		public const int ClientDataFieldNumber = 17;

		private string clientData_;

		public const int RoleCombatInfoProtoFieldNumber = 18;

		private RoleCombatInfoProto roleCombatInfoProto_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<CscCombatInfo> Parser
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
		public RepeatedField<long> SvCardIDs
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public RepeatedField<int> SvEnegys
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int RoleHP
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
		public string ClientData
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
		public RoleCombatInfoProto RoleCombatInfoProto
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
		public CscCombatInfo()
		{
		}

		[DebuggerNonUserCode]
		public CscCombatInfo(CscCombatInfo other)
		{
		}

		[DebuggerNonUserCode]
		public CscCombatInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(CscCombatInfo other)
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
		public void MergeFrom(CscCombatInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
