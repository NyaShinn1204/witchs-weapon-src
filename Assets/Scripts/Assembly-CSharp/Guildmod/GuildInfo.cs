using System;
using System.Diagnostics;
using Actionmod;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Guildmod
{
	public sealed class GuildInfo : IMessage<GuildInfo>, IMessage, IEquatable<GuildInfo>, IDeepCloneable<GuildInfo>
	{
		private static readonly MessageParser<GuildInfo> _parser;

		public const int UserInfoFieldNumber = 1;

		private UserGuild userInfo_;

		public const int CommonInfoFieldNumber = 2;

		private Guild commonInfo_;

		public const int ResultFieldNumber = 3;

		private string result_;

		public const int ExtraInfoFieldNumber = 4;

		private ExtraInfo extraInfo_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<GuildInfo> Parser
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
		public UserGuild UserInfo
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
		public Guild CommonInfo
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
		public string Result
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
		public ExtraInfo ExtraInfo
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
		public GuildInfo()
		{
		}

		[DebuggerNonUserCode]
		public GuildInfo(GuildInfo other)
		{
		}

		[DebuggerNonUserCode]
		public GuildInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(GuildInfo other)
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
		public void MergeFrom(GuildInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
