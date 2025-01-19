using LeanCloud.Realtime;

namespace WaterBell.ProjX.Core.Manager
{
	public class ChatMessage : AVIMTypedMessage
	{
		private int channelType;

		private int head;

		private int headBox;

		private string guildid;

		private string name;

		public string ChatContent { get; set; }

		public int ChannelType
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int Head
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int HeadBox
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public string Guildid
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

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

		public int CountAchieve { get; set; }

		public int CountStory { get; set; }

		public int CountWeapon { get; set; }

		public int CountServant { get; set; }

		public int idTitle { get; set; }

		public string idRole { get; set; }

		public string guildName { get; set; }

		public int guildPrivilege { get; set; }

		public long guildEmblemBorder { get; set; }

		public long guildEmblemBackground { get; set; }

		public long guildEmblem { get; set; }

		public int guildEmblemBackgroundColor { get; set; }

		public int guildEmblemBorderColor { get; set; }

		public int guildEmblemColor { get; set; }

		public int roleLv { get; set; }

		public ChatMessage()
		{
		}

		public ChatMessage(int channelType, string name, int head, int headBox, string content, string guildid = "")
		{
		}
	}
}
