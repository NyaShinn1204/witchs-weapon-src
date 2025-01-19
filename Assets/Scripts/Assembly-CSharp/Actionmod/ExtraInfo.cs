using System;
using System.Diagnostics;
using Achievemod;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;
using Ratemod;
using Storymod;
using Vipmod;

namespace Actionmod
{
	public sealed class ExtraInfo : IMessage<ExtraInfo>, IMessage, IEquatable<ExtraInfo>, IDeepCloneable<ExtraInfo>
	{
		private static readonly MessageParser<ExtraInfo> _parser;

		public const int LevelEventFieldNumber = 1;

		private static readonly FieldCodec<LevelEvent> _repeated_levelEvent_codec;

		private readonly RepeatedField<LevelEvent> levelEvent_;

		public const int AchieveResultFieldNumber = 2;

		private Result achieveResult_;

		public const int CscOpenFieldNumber = 3;

		private bool cscOpen_;

		public const int OneDayVipExpFieldNumber = 4;

		private OneDayVipExp oneDayVipExp_;

		public const int StoryFieldNumber = 5;

		private Story story_;

		public const int ShopEventFieldNumber = 6;

		private static readonly FieldCodec<ShopEvent> _repeated_shopEvent_codec;

		private readonly RepeatedField<ShopEvent> shopEvent_;

		public const int ApOpenFieldNumber = 7;

		private int apOpen_;

		public const int VipExtraFieldNumber = 100;

		private VipExtra vipExtra_;

		public const int R1DataFieldNumber = 101;

		private R1DataExtra r1Data_;

		public const int R2DataFieldNumber = 102;

		private R2DataExtra r2Data_;

		public const int R3DataFieldNumber = 103;

		private R3DataExtra r3Data_;

		public const int R4DataFieldNumber = 104;

		private R4DataExtra r4Data_;

		public const int R5DataFieldNumber = 105;

		private R5DataExtra r5Data_;

		public const int R6DataFieldNumber = 106;

		private R6DataExtra r6Data_;

		public const int R7DataFieldNumber = 107;

		private R7DataExtra r7Data_;

		public const int R8DataFieldNumber = 108;

		private R8DataExtra r8Data_;

		public const int R9DataFieldNumber = 109;

		private R9DataExtra r9Data_;

		public const int R10DataFieldNumber = 110;

		private R10DataExtra r10Data_;

		public const int ActivityStoryFieldNumber = 111;

		private long activityStory_;

		public const int RateInfoFieldNumber = 112;

		private RateInfo rateInfo_;

		[DebuggerNonUserCode]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public static MessageParser<ExtraInfo> Parser
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
		public RepeatedField<LevelEvent> LevelEvent
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public Result AchieveResult
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
		public bool CscOpen
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
		public OneDayVipExp OneDayVipExp
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
		public Story Story
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
		public RepeatedField<ShopEvent> ShopEvent
		{
			get
			{
				return null;
			}
		}

		[DebuggerNonUserCode]
		public int ApOpen
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
		public VipExtra VipExtra
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
		public R1DataExtra R1Data
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
		public R2DataExtra R2Data
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
		public R3DataExtra R3Data
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
		public R4DataExtra R4Data
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
		public R5DataExtra R5Data
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
		public R6DataExtra R6Data
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
		public R7DataExtra R7Data
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
		public R8DataExtra R8Data
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
		public R9DataExtra R9Data
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
		public R10DataExtra R10Data
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
		public long ActivityStory
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
		public RateInfo RateInfo
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
		public ExtraInfo()
		{
		}

		[DebuggerNonUserCode]
		public ExtraInfo(ExtraInfo other)
		{
		}

		[DebuggerNonUserCode]
		public ExtraInfo Clone()
		{
			return null;
		}

		[DebuggerNonUserCode]
		public override bool Equals(object other)
		{
			return false;
		}

		[DebuggerNonUserCode]
		public bool Equals(ExtraInfo other)
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
		public void MergeFrom(ExtraInfo other)
		{
		}

		[DebuggerNonUserCode]
		public void MergeFrom(CodedInputStream input)
		{
		}
	}
}
