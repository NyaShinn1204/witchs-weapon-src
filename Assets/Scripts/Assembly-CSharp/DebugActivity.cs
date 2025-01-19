using UnityEngine;

public class DebugActivity : MonoBehaviour
{
	private static bool showDebug;

	private const int GUI_WindowId = 1003;

	private const int GUI_NORMAL_HEIGHT = 15;

	private const int GUI_STANDARD_BUTTON_WIDTH = 70;

	private const int GUI_STANDARD_TITLE_WIDTH = 120;

	private const int GUI_STANDARD_TOOLBAR_WIDTH = 220;

	private const int GUI_STANDARD_ITEM_WIDTH = 300;

	private const int GUI_TAB_ID_MOB_SPAWN = 0;

	private const int GUI_TAB_ID_CHAR_STAT = 1;

	private const int GUI_TAB_ID_MOB_STAT = 2;

	private const int GUI_TAB_ID_LEVEL_STATE = 3;

	public static ActivityDebugData debugData;

	private DebugTools.GUIPlus.DropDownList buffDDL1;

	private DebugTools.GUIPlus.DropDownList buffDDL2;

	private DebugTools.GUIPlus.DropDownList buffDDL3;

	public static string[] GUI_MOB_ENHANCE;

	private int index;

	public static void ToggleDebug()
	{
	}

	private void Start()
	{
	}

	private void OnGUI()
	{
	}

	private void GUI_DebugWindow(int windowId)
	{
	}

	private void doModify()
	{
	}
}
