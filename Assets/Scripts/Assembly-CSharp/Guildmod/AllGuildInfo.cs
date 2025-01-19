using System;
using System.Diagnostics;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Guildmod
{
	public sealed class AllGuildInfo : IMessage<AllGuildInfo>, IMessage, IEquatable<AllGuildInfo>, IDeepCloneable<AllGuildInfo>
	{
		[DebuggerNonUserCode]
		public static class Types
		{
			public sealed class Info : IMessage<Info>, IMessage, IEquatable<Info>, IDeepCloneable<Info>
			{
				private static readonly MessageParser<Info> _parser;

				public const int IDFieldNumber = 1;

				private string iD_;

				public const int NameFieldNumber = 2;

				private string name_;

				public const int CountFieldNumber = 3;

				private int count_;

				public const int SloganFieldNumber = 4;

				private string slogan_;

				public const int LevelFieldNumber = 5;

				private int level_;

				public const int PresidentIDFieldNumber = 6;

				private long presidentID_;

				public const int PresidentNameFieldNumber = 7;

				private string presidentName_;

				public const int PresidentLevelFieldNumber = 8;

				private int presidentLevel_;

				public const int AVGPTFieldNumber = 9;

				private int aVGPT_;

				public const int EmblemFieldNumber = 10;

				private long emblem_;

				public const int EmblemColorFieldNumber = 14;

				private int emblemColor_;

				public const int EmblemBorderFieldNumber = 11;

				private long emblemBorder_;

				public const int EmblemBorderColorFieldNumber = 15;

				private int emblemBorderColor_;

				public const int EmblemBackgroundFieldNumber = 12;

				private long emblemBackground_;

				public const int EmblemBackgroundColorFieldNumber = 16;

				private int emblemBackgroundColor_;

				public const int BuffFieldNumber = 13;

				private uint buff_;

				public const int CEFieldNumber = 17;

				private long cE_;

				[DebuggerNonUserCode]
				MessageDescriptor IMessage.Descriptor
				{
					get
					{
						return null;
					}
				}

				[DebuggerNonUserCode]
				public static MessageParser<Info> Parser
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
				public string ID
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
				public string Name
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
				public string Slogan
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
				public int Level
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
				public long PresidentID
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
				public string PresidentName
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
				public int PresidentLevel
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
				public int AVGPT
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
				public long Emblem
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
				public int EmblemColor
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
				public long EmblemBorder
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
				public int EmblemBorderColor
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
				public long EmblemBackground
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
				public int EmblemBackgroundColor
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
				public uint Buff
				{
					get
					{
						return 0u;
					}
					set
					{
					}
				}

				[DebuggerNonUserCode]
				public long CE
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
				public Info()
				{
				}

				[DebuggerNonUserCode]
				public Info(Info other)
				{
				}

				[DebuggerNonUserCode]
				public Info Clone()
				{
					return null;
				}

				[DebuggerNonUserCode]
				public override bool Equals(object other)
				{
					return false;
				}

				[DebuggerNonUserCode]
				public bool Equals(Info other)
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
				public void MergeFrom(Info other)
				{
				}

				[DebuggerNonUserCode]
				public void MergeFrom(CodedInputStream input)
				{
				}
			}
		}

		private static readonly MessageParser<AllGuildInfo> _parser;

		public const int DataFieldNumber = 1;

		private static readonly FieldCodec<Types.Info> _repeated_data_codec;

		private readonly RepeatedField<Types.Info> data_;

		public const int GuildNumFieldNumber = 2;

		private int guildNum_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<AllGuildInfo> Parser
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
		public RepeatedField<Types.Info> Data
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int GuildNum
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
		public AllGuildInfo()
		{
		}

		[DebuggerNonUserCode]
		public AllGuildInfo(AllGuildInfo other)
		{
		}

		[DebuggerNonUserCode]
		public AllGuildInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(AllGuildInfo other)
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
		public void MergeFrom(AllGuildInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
