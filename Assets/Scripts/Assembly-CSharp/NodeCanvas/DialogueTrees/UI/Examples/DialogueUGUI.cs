using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

namespace NodeCanvas.DialogueTrees.UI.Examples
{
	public class DialogueUGUI : MonoBehaviour
	{
		[Serializable]
		public class SubtitleDelays
		{
			public float characterDelay;

			public float sentenceDelay;

			public float commaDelay;

			public float finalDelay;
		}

		public bool skipOnInput;

		public bool waitForInput;

		public RectTransform subtitlesGroup;

		public Text actorSpeech;

		public Text actorName;

		public Image actorPortrait;

		public RectTransform waitInputIndicator;

		public SubtitleDelays subtitleDelays;

		public List<AudioClip> typingSounds;

		public RectTransform optionsGroup;

		public Button optionButton;

		private Dictionary<Button, int> cachedButtons;

		private Vector2 originalSubsPosition;

		private bool isWaitingChoice;

		private AudioSource _localSource;

		private AudioSource localSource
		{
			get
			{
				return null;
			}
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Start()
		{
		}

		private void OnDialogueStarted(DialogueTree dlg)
		{
		}

		private void OnDialoguePaused(DialogueTree dlg)
		{
		}

		private void OnDialogueFinished(DialogueTree dlg)
		{
		}

		private void OnSubtitlesRequest(SubtitlesRequestInfo info)
		{
		}

		[DebuggerHidden]
		private IEnumerator Internal_OnSubtitlesRequestInfo(SubtitlesRequestInfo info)
		{
			return null;
		}

		private void PlayTypeSound()
		{
		}

		[DebuggerHidden]
		private IEnumerator CheckInput(Action Do)
		{
			return null;
		}

		[DebuggerHidden]
		private IEnumerator DelayPrint(float time)
		{
			return null;
		}

		private void OnMultipleChoiceRequest(MultipleChoiceRequestInfo info)
		{
		}

		[DebuggerHidden]
		private IEnumerator CountDown(MultipleChoiceRequestInfo info)
		{
			return null;
		}

		private void Finalize(MultipleChoiceRequestInfo info, int index)
		{
		}

		private void SetMassAlpha(RectTransform root, float alpha)
		{
		}
	}
}
