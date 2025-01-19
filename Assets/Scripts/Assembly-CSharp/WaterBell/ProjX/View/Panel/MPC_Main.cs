using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public sealed class MPC_Main : UIPanelSingle
	{
		private static MPC_Main current;

		public Camera mapCamera;

		public Transform chapters;

		public UILabel chapterNameLabel;

		public ButtonEx prevButton;

		public ButtonEx nextButton;

		public List<long> chapterIDs;

		private int currentIdx;

		private int mainChapterType;

		private Sequence mapCamSeq;

		private Dictionary<long, MPC_Chapter> chapterDict;

		protected override void Awake()
		{
		}

		private void Update()
		{
		}

		public static MPC_Main GetInstance()
		{
			return null;
		}

		public void Goto(long chapterID)
		{
		}

		public void PrevChapter()
		{
		}

		public void NextChapter()
		{
		}
	}
}
