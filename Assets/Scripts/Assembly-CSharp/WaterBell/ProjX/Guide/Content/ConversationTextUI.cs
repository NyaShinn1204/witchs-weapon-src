using UnityEngine;

namespace WaterBell.ProjX.Guide.Content
{
	public class ConversationTextUI : MonoBehaviour
	{
		public GameObject nameBoardContainer;

		public GameObject wordBoxContainer;

		public GameObject nextObj;

		public UILabel nameBoardLabel;

		public UILabel wordBoxLabel;

		public UILabel wordBoxLabelHide;

		public TypewriterEffect writerEff;

		private bool hasRemainingWord;

		private bool isRemainingWordAsUnspokenWord;

		private string remainingWordCache;

		private bool isBindEffFinishEvt;

		private Color origLabelCol;

		private Color unspokenCol;

		private char[] cnEndPunctuations;

		private void Start()
		{
		}

		public void Reset()
		{
		}

		private void showNextSign()
		{
		}

		public void ClearOnNobodySpeak(bool isSameRoleSpeakAg = false)
		{
		}

		public void ShowName(string storyRoleName)
		{
		}

		public void ShowWord(string origWord, bool isUnspokenWord = false)
		{
		}

		public void ShowRemainingWord()
		{
		}

		private void SplitAndResize(UILabel uiLabel, UILabel uiLabelHide, string origWord, out string fitprintWord, out string remainningWord)
		{
			fitprintWord = null;
			remainningWord = null;
		}

		private string FindLastUnclosedBeginSymbol(string text)
		{
			return null;
		}

		private bool IsCnLangEndPunctuation(char ch)
		{
			return false;
		}

		public void HideName()
		{
		}

		public bool GetIsRunningAnim()
		{
			return false;
		}

		public bool GetHasRemainingWord()
		{
			return false;
		}

		public void LetInstantFinish()
		{
		}
	}
}
