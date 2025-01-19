using System.Collections.Generic;
using LitJson;
using UnityEngine;

public class DebugTools : MonoBehaviour, IHTTPResponse
{
	private class CSVModel
	{
		private static CSVModel instance;

		private string[] colName;

		private string[] dataType;

		private string[] annotation;

		private string[,] data;

		private int lineCount;

		private CSVModel()
		{
		}

		public static CSVModel GetInstance()
		{
			return null;
		}

		public void SetData(string[] lines)
		{
		}

		public int GetCollIdxByName(string name)
		{
			return 0;
		}

		public string GetData(int col, int row)
		{
			return null;
		}

		public int GetLineCount()
		{
			return 0;
		}
	}

	private class MonsterData
	{
		public long id;

		public string name;

		public string dev_name;

		public string model_name;

		public int type;
	}

	public class GUIPlus
	{
		public class DropDownList
		{
			private Vector2 scrollPos;

			private string[] dataList;

			private float width;

			private float height;

			private bool showDropDown;

			private int index;

			private Rect listRect;

			private string title;

			public DropDownList(string title, string[] data, int w, int h)
			{
			}

			internal int OnGUI()
			{
				return 0;
			}

			internal void OnGUIDropList()
			{
			}
		}

		internal static Vector2 GUI_DEV_WinSize;

		internal static float GUI_OVERALL_SCALE;

		internal static Rect GUI_WindowRect;

		internal static void refreshScale()
		{
		}

		internal static bool Button(string content, int w, int h)
		{
			return false;
		}

		internal static int Toolbar(int selectedIdx, string[] content, int w, int h)
		{
			return 0;
		}

		internal static bool Toggle(bool value, string content, int w, int h)
		{
			return false;
		}

		internal static void Label(string content, int w, int h)
		{
		}

		internal static string TextField(string content, int w, int h)
		{
			return null;
		}

		internal static void Space(int p)
		{
		}

		internal static int IntField(string title, int value)
		{
			return 0;
		}

		internal static long LongField(string title, long value)
		{
			return 0L;
		}
	}

	private List<MonsterData> MonsterSelectData;

	private const int GUI_NORMAL_HEIGHT = 15;

	private const int GUI_STANDARD_BUTTON_WIDTH = 70;

	private const int GUI_STANDARD_TITLE_WIDTH = 120;

	private const int GUI_STANDARD_TOOLBAR_WIDTH = 220;

	private const int GUI_STANDARD_ITEM_WIDTH = 300;

	private const int GUI_TAB_ID_MOB_SPAWN = 0;

	private const int GUI_TAB_ID_CHAR_STAT = 1;

	private const int GUI_TAB_ID_MOB_STAT = 2;

	private const int GUI_TAB_ID_LEVEL_STATE = 3;

	private readonly string[] GUI_MAINTAB_TYPE_STR;

	private readonly string[] GUI_MOB_TYPE_STR;

	private readonly string[] GUI_MOB_RANK_STR;

	private static int GUI_WindowId;

	private static DebugTools instace;

	private bool showDebugMenu;

	private int GUI_MAIN_selectedTabIdx;

	private int GUI_MOB_selectedType;

	private int GUI_MOB_selectedRank;

	private string GUI_MOB_levelText;

	private int GUI_MOB_selectedLevel;

	private MonsterData GUI_MOB_selectedMonsterData;

	private Vector2 GUI_MOB_scrollPosition;

	public const string TAG_GET_HERO_INFO = "$NEW_PROTOCOL$_HERO_INFO";

	public const string TAG_GET_MONSTERS_INFO = "$NEW_PROTOCOL$_MONSTERS_INFO";

	private DebugTools()
	{
	}

	private void GenMonsterData()
	{
	}

	public static DebugTools GetInstance()
	{
		return null;
	}

	public void ToggleDebugUI()
	{
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void OnGUI()
	{
	}

	private void GUI_DebugWindow(int windowId)
	{
	}

	private void GUI_DrawTabMob()
	{
	}

	private void GUI_DrawTabChar()
	{
	}

	private void GUI_DrawTabMobStat()
	{
	}

	private void GetMonsterInfoFromHTTPTest(long id, int type, int level)
	{
	}

	private void GetHeroInfoFromHTTPTest()
	{
	}

	private void GUI_DrawTabLevelState()
	{
	}

	private void DoDumpLevelState()
	{
	}

	private void DoCheckAndSpawn(MonsterData m)
	{
	}

	public void OnData(byte[] data, string URL, string type, string tag)
	{
	}

	private void OnHeroResponse(JsonData userData)
	{
	}

	private void ProcessUnitData(BattleDataStore dataStore, JsonData unit)
	{
	}

	private void OnMonsterResponse(JsonData json)
	{
	}

	private void DoSpawnMonsterDataFromWeb(JsonData json)
	{
	}

	private JsonData GetNoErrorData(string responseText)
	{
		return null;
	}
}
