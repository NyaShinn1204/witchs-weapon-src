using System.Collections;
using System.Diagnostics;
using UnityEngine;
using WaterBell.ProjX.Guide.DataModel;

namespace WaterBell.ProjX.Guide.Content
{
	public class PhoneDialogLayer : MonoBehaviour
	{
		private enum RoleSlotStatus
		{
			empty = 0,
			normal = 1
		}

		private Vector3 roleDefaultPos;

		private Color normalCol;

		public UITexture wordBox;

		public DialogTextUI textUI;

		private bool isRunning;

		private bool isRunningBgAnim;

		private bool isInstantFinish;

		private Transform selfTrans;

		public bool GetIsRunning()
		{
			return false;
		}

		public bool GetIsRunningAnim()
		{
			return false;
		}

		public void LetInstantFinish()
		{
		}

		private void Awake()
		{
		}

		public void Begin(int x, int y)
		{
		}

		public void Move(int x, int y)
		{
		}

		public void End()
		{
		}

		public void Speak(string word)
		{
		}

		[DebuggerHidden]
		private IEnumerator SpeakAfterLoadingBg(string word)
		{
			return null;
		}

		private void Clear()
		{
		}

		private void ShowNewRole(ConversationRole roleData, string faceSubFix = "")
		{
		}
	}
}
