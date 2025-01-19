using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class NetworkWatingBoxBase : MonoBehaviour
	{
		public enum BoxState
		{
			none = 0,
			wait = 1,
			timeout = 2,
			restart = 3
		}

		public CommonWaitingBox WaitBox;

		public GameObject TimeOutBox;

		public GameObject ReStartBox;

		public UILabel ReStartTitle;

		public UILabel ReStartContant;

		public CommonTipsBox TipsBox;

		public GameObject WaitAnimaBlock;

		public UISprite TipsBG;

		public UISprite TipsIcon;

		public UISprite WaitBG;

		public UISprite WaitIcon;

		public UISprite TimeOutBG;

		public UISprite TimeOutTitle;

		public UISprite TimeOutIcon;

		public UISprite TimeOutBtn;

		public UISprite RestartBG;

		public UISprite RestartTitle;

		public UISprite RestartIcon;

		public UISprite RestartBtn;

		private BoxState boxState;

		public const float maxWaitTime = 30f;

		public BoxState GetBoxState()
		{
			return default(BoxState);
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void StartCountDown()
		{
		}

		public void CheckWait()
		{
		}

		public void ShowTips(string tipStr)
		{
		}

		public void ShowWait(bool isShow = true)
		{
		}

		public void ShowBlockAnima(float Delay = -1f)
		{
		}

		public void HideBlockAnima()
		{
		}

		public void ShowTimeOut()
		{
		}

		public void ShowRestartGame(string title, string content, string code)
		{
		}

		private void StartCountDownToResend()
		{
		}

		private void CancelCountDownToResend()
		{
		}

		private void ShowTimeOutAfterMaxWaitTime()
		{
		}

		private void Show(BoxState src, BoxState dst, bool isShow = true)
		{
		}

		private void HideTimeOut()
		{
		}

		public void OnClickResendMsg()
		{
		}

		private void ResentMsg()
		{
		}

		public void OnClickRestartGame()
		{
		}
	}
}
