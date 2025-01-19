using System.Collections.Generic;

public class ServerDataChatMngr : MngrDataServer
{
	public enum ServerDataChatType
	{
		World = 0,
		Guild = 1,
		System = 2,
		GuildLink = 3
	}

	public class ServerDataChatItem
	{
		public double _timeStamp;

		public string id;

		public ServerDataChatType type;

		private string _info;

		public string name;

		public int icon;

		public int iconBack;

		public bool isSelf;

		public string idGuild;

		public int countAchieve;

		public int countStory;

		public int countWeapon;

		public int countServant;

		public int idTitle;

		public string idRole;

		public int lv;

		public string guildName;

		public int guildPrivilege;

		public long guildEmblemBorder;

		public long guildEmblemBackground;

		public long guildEmblem;

		public int guildEmblemBackgroundColor;

		public int guildEmblemBorderColor;

		public int guildEmblemColor;

		private double _sysMsgTimeBegin;

		private double _sysMsgTimeEnd;

		private float[] _sysMsgTimeLoop;

		private int _sysMsgShowCounts;

		public string info
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string infoLua
		{
			get
			{
				return null;
			}
		}

		public string infoReal
		{
			get
			{
				return null;
			}
		}

		public double sysMsgTimeBegin
		{
			get
			{
				return 0.0;
			}
		}

		public double sysMsgTimeEnd
		{
			get
			{
				return 0.0;
			}
		}

		public float[] sysMsgTimeLoop
		{
			get
			{
				return null;
			}
		}

		public int sysMsgShowCount
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public int sysMsgShowCountWill
		{
			get
			{
				return 0;
			}
		}

		public int sysMsgShowCountMax
		{
			get
			{
				return 0;
			}
		}

		public string sysMsgOverQuit
		{
			get
			{
				return null;
			}
		}

		public int timeSecond
		{
			get
			{
				return 0;
			}
		}

		public string formatTime
		{
			get
			{
				return null;
			}
		}
	}

	public const string CHAT_LISTENER = "ServerDataChatMngrListener";

	private Dictionary<string, ServerDataChatItem> _dataAll;

	private Dictionary<ServerDataChatType, List<ServerDataChatItem>> _dataTypeArr;

	private Dictionary<ServerDataChatType, int> _dataTypeUnReadCount;

	public void AddChat(ServerDataChatItem sChatData)
	{
	}

	public ServerDataChatItem GetChat(string sID)
	{
		return null;
	}

	private string AddChatResult(ServerDataChatItem sChatData)
	{
		return null;
	}

	private void AddChatUnResult(ServerDataChatItem sChatData)
	{
	}

	public List<ServerDataChatItem> GetChatList(ServerDataChatType sType)
	{
		return null;
	}

	public int GetUnReadCount(ServerDataChatType sType)
	{
		return 0;
	}

	public int GetUnReadCount()
	{
		return 0;
	}

	public float GetLastMsgTime()
	{
		return 0f;
	}

	public void SetUnReadEmpty()
	{
	}

	public void ClearChat()
	{
	}
}
