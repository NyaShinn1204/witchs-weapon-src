using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using WaterBell.ProjX.Guide.DataModel;

namespace WaterBell.ProjX.Guide.Content
{
	public class ConversationManager : MonoBehaviour
	{
		public enum SlotShowMode
		{
			Empty = 0,
			One = 1,
			Two = 2,
			Three = 3,
			Custom = 4
		}

		public enum AnimPlayState
		{
			Empty = 0,
			RoleMoveAnim = 1,
			WordAnim = 2,
			FadeAnim = 3
		}

		private class RolePosSlotMngr
		{
			private enum AutoSlotRule
			{
				PushLeft = 0
			}

			private SlotShowMode mode;

			private string[] prevRolePosSlotArr;

			private string[] currRolePosSlotArr;

			private float[] slotDefautPosArr;

			private AutoSlotRule rule;

			public void Reset()
			{
			}

			public int GetCurrRoleSlotIndex(string roleSN)
			{
				return 0;
			}

			public float GetRoleMoveDesPos(string roleSN)
			{
				return 0f;
			}

			public float GetRoleMoveSrcPos(string roleSN)
			{
				return 0f;
			}

			public SlotShowMode GetShowMode()
			{
				return default(SlotShowMode);
			}

			public bool IsAllSlotFull()
			{
				return false;
			}

			public bool IsSlotFullUnderCurrMode()
			{
				return false;
			}

			public void AssignSlot4Role(StoryRole role, int slotIdx)
			{
			}

			public void AutoAssignSlotsOnRoleIn(StoryRole role)
			{
			}

			public void AutoAssignSlotsOnRoleOut(StoryRole role)
			{
			}

			private void SaveCurrSlot()
			{
			}
		}

		public static readonly int SlotMax;

		public static readonly string HideNameTag;

		public ConversationTextUI textUI;

		public BgTexCtrl bgUI;

		public StorySkipBtn skipBtn;

		private Transform selfTrans;

		private GameObject selfObj;

		private Dictionary<string, StoryRole> roleDict;

		private StoryRole lastSpeaker;

		private RolePosSlotMngr slotMngr;

		private bool isRunning;

		private Coroutine _endTask;

		private bool isStartEndCmd;

		private bool isConversationHidedBySpeakAside;

		private bool isConversationDarkenBySpeakAside;

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

		public void RemoveStoryRole(string roleSN)
		{
		}

		private void Awake()
		{
		}

		public void Begin(string bgPicName, bool isAllowSkip = true)
		{
		}

		public bool IsEndFinished()
		{
			return false;
		}

		public void End()
		{
		}

		[DebuggerHidden]
		private IEnumerator DelayRealEnd()
		{
			return null;
		}

		private StoryRole LoadStoryRole(string roleSN)
		{
			return null;
		}

		private bool isRoleExistedOnAnySlot(string roleSN)
		{
			return false;
		}

		private bool isRoleContinue2Speak(StoryRole role)
		{
			return false;
		}

		private float GroupCmd_allRoleDisappear()
		{
			return 0f;
		}

		private float GroupCmd_moveAndDarkOtherRolesOnRoleIn(string newRoleSN)
		{
			return 0f;
		}

		private float GroupCmd_moveOtherRolesOnRoleOut(string roleSN, float delayTime)
		{
			return 0f;
		}

		private float GroupCmd_darkenOtherRoles(string speakingRoleSN)
		{
			return 0f;
		}

		public void RoleSpeak(ConversationRole roleData, string word, int slotIndex, string faceName = "", long speechId = -1L, string spRoleName = "", bool isLanguage = false)
		{
		}

		public void RoleOut(ConversationRole roleData)
		{
		}

		private void DoSpeakAction(StoryRole role, string origWord, long speechId, string spRoleName, bool isSameRoleSpeekAg = false)
		{
		}

		public void SpeakAside(string word, string tmpName = "", bool isHideConversation = true, long speechId = -1L)
		{
		}

		private float GroupCmd_speakAsideHideAllRole()
		{
			return 0f;
		}

		private float GroupCmd_recoverFromSpeakAsideShowAllRole(ConversationRole roleData)
		{
			return 0f;
		}

		private float GroupCmd_speakAsideDarkenAllRole()
		{
			return 0f;
		}
	}
}
