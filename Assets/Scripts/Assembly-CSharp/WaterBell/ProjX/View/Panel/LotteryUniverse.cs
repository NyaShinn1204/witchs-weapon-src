using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using DG.Tweening;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class LotteryUniverse : UIPanelSingle
	{
		public static LotteryUniverse current;

		public GameObject starLightSource;

		public Star starSource;

		public StarSelectEffect starSelectEffectSource;

		public StarConnect starConnectSource;

		public Transform starConnectContainer;

		public Transform currentTouchPoint;

		public Camera bgCam;

		public UniverseArtsControl artsControl;

		public Transform selectContainer;

		public GameObject meteorEffectByGold;

		public GameObject meteorEffectByDiamond;

		public Transform meteorEffectContainer;

		[SerializeField]
		private float camFromStarDist;

		[SerializeField]
		private List<LotteryLootData> lotteryLootDataList;

		private List<Star> connectStarList;

		private List<StarConnect> starConnectList;

		private List<StarSelectEffect> starSelectEffectList;

		private Star[] stars;

		private int showIndex;

		private Vector3 camInitPos;

		private Vector3 camInitRotation;

		private int state;

		private bool isGoldFree;

		private bool isDiamondFree;

		private List<Tweener> tweenList;

		private Tweener currentTweener;

		private bool connectStarComplete;

		private int cacheLayerMask;

		private bool canDirectShowResult;

		private DrawSystemManagerView drawView;

		public Action<List<LotteryLootData>, List<Star>> OnDrawFinish;

		public Action<LotteryLootData> OnShowLootDetail;

		public Action<List<LotteryLootData>, List<Star>> OnShowLootDetailComplete;

		public Action<int> OnSelectStar;

		public Action OnConnectComplete;

		private int starFlashIndex;

		private float starFlashDuration;

		private float starFlashInterval;

		private List<GameObject> flashEffectList;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		private void Update()
		{
		}

		private void GotoMainScene()
		{
		}

		protected override void OnDestroy()
		{
		}

		public void SetCamInteractionState(bool state)
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public void DrawFinishExecuted()
		{
		}

		private void ConnectStar(Star star)
		{
		}

		private void BreakStarConnect()
		{
		}

		private void PaddingDataFromJPServer()
		{
		}

		[DebuggerHidden]
		private IEnumerator ShowResult()
		{
			return null;
		}

		private void PlayNext()
		{
		}

		private void PlayNextDelay()
		{
		}

		public void DirectShowResult()
		{
		}
	}
}
