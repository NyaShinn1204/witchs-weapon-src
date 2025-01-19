using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using WaterBell.ProjX.Guide.DataModel;

namespace WaterBell.ProjX.Guide.Content
{
	public class StoryRole : MonoBehaviour
	{
		internal struct RoleAnimCmd
		{
			public string cmdName;

			public object[] cmdArgs;

			public bool isFinish;
		}

		internal enum AnimCmd
		{
			Appear = 0,
			Disappear = 1,
			Show = 2,
			ShowAsDark = 3,
			Hide = 4,
			SwapFace = 5,
			Move = 6,
			MoveAndDark = 7,
			BeDark = 8,
			BeNormal = 9,
			Speak = 10
		}

		public static float darkColRatio;

		public static float normalColRatio;

		private UISprite tmpFaceSprite;

		private UISprite faceSprite;

		private UITexture bodyTex;

		private Transform selfTrans;

		private int depth;

		private bool isDark;

		private bool isHide;

		private string _name;

		private string _sn;

		private ConversationManager _conversationMngr;

		private float xPosSrc;

		private float xPosDes;

		private Coroutine _animCorotine;

		internal Queue<RoleAnimCmd> cmdQueue;

		private bool isRunningAnim;

		private float animDelay;

		private float animTimeAdd;

		private bool isInstantFinish;

		private Vector3 srcPos;

		private Vector3 desPos;

		private float tmpColRatio;

		private Color tmpCol;

		private string tmpFace;

		private int speakTermCount;

		private RoleAnimCmd currCmd;

		public string sn
		{
			get
			{
				return null;
			}
		}

		public string roleName
		{
			get
			{
				return null;
			}
		}

		private void Awake()
		{
		}

		public void BindRoleData(ConversationRole roleData, ConversationManager parentNodeScript)
		{
		}

		public void SetAppearFace(string faceName)
		{
		}

		public void SwapFace(string faceName)
		{
		}

		public void SetDepth(int baseDepth)
		{
		}

		public void BeDark()
		{
		}

		public void BeNormal()
		{
		}

		public void Shake()
		{
		}

		public float Appear(float xPos, float delayTime = 0f)
		{
			return 0f;
		}

		public float Disappear()
		{
			return 0f;
		}

		public void Hide()
		{
		}

		public void Show(bool isShowAsDark = false)
		{
		}

		public void Move(float xPos, float delayTime = 0f)
		{
		}

		public void MoveAndDark(float xPos, float delayTime = 0f)
		{
		}

		public void Speak(string origWord, long speechId, string titleName)
		{
		}

		private void TryRunAnim()
		{
		}

		private void TryEndAnim()
		{
		}

		internal static float GetAnimTime(AnimCmd cmdType)
		{
			return 0f;
		}

		public bool GetIsRunningAnim()
		{
			return false;
		}

		public void LetInstantFinish()
		{
		}

		[DebuggerHidden]
		private IEnumerator RunAnim()
		{
			return null;
		}

		private void PosLerp(float lerpRatio)
		{
		}

		private void ShowAlphaLerp(float lerpRatio, bool isShowAsDark = false)
		{
		}

		private void HideAlphaLerp(float lerpRatio)
		{
		}

		private void ColorAlphaLerp(float lerpRatio, bool beDark)
		{
		}
	}
}
