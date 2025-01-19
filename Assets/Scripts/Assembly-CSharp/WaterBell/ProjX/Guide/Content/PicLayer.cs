using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace WaterBell.ProjX.Guide.Content
{
	public class PicLayer : MonoBehaviour
	{
		public enum PicInsertLayer
		{
			Conversation = 0,
			BgIntroLayer = 1,
			Dialog = 2,
			Teaching = 3
		}

		private float _delay;

		public UITexture picTex;

		public UISlider _slider;

		private bool isRunning;

		private bool isRunningAnim;

		private bool isInstantFinish;

		public bool IsRunning()
		{
			return false;
		}

		public bool IsRunningAnim()
		{
			return false;
		}

		public void LetInstantFinish()
		{
		}

		public bool isShowingPicOfCertainLayer(PicInsertLayer layer)
		{
			return false;
		}

		public void ShowPic(string picName, PicInsertLayer layer, int xOffset, int yOffset, bool isLanguage, float delay = 0f)
		{
		}

		public void HidePic()
		{
		}

		public void InsertBegin(string picName, PicInsertLayer layer, int xOffset, int yOffset)
		{
		}

		public void Change(string picName, PicInsertLayer layer, int xOffset, int yOffset)
		{
		}

		public void InsertEnd()
		{
		}

		private void ShowPicture(string picName, PicInsertLayer layer, int x, int y, bool isFirstTimeShowPic)
		{
		}

		[DebuggerHidden]
		private IEnumerator RunLoadPicAnim()
		{
			return null;
		}

		private void Hide(bool isForce = false)
		{
		}
	}
}
