using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class BMLevelIcon : MonoBehaviour
	{
		public enum ProgressTypes
		{
			Lock = 0,
			Unlock = 1
		}

		private static Dictionary<long, Vector3> levelIconAnchorPointsDict;

		public static float maxDis;

		public static float minDis;

		public static float minScale;

		[SerializeField]
		protected long id;

		[HideInInspector]
		public PositionSync positionSync;

		public UIWidget detailsPanel;

		public GameObject detailsPanelMain;

		public GameObject point;

		public GameObject repeat_Lock;

		public GameObject repeat_Unlock;

		public GameObject linkLine;

		public UILabel indexLabel;

		public UISprite photo;

		public UISprite blackMask;

		public UISprite typeIcon;

		public BMLevelPos levelPos;

		public UISprite sweepIcon;

		public ButtonEx buttonPoint;

		public ButtonEx buttonBox;

		public UISprite clearIcon;

		public UILabel svNameLabel;

		public UILabel itemNameLabel;

		public GameObject itemIcon;

		public GameObject itemContainer;

		protected Animator m_Anim;

		protected TypeCsvInstance levelTabelData;

		protected TypeCsvVictoryFailureConditions victoryFailureTableData;

		protected TypeCsvInstanceMobList instanceMobListTableData;

		protected ProgressTypes m_ProgressType;

		protected bool m_Clear;

		protected bool m_CanSweep;

		public Vector3 AnchorPoint
		{
			set
			{
			}
		}

		public bool IsClear
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool CanSweep
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public virtual ProgressTypes ProgressType
		{
			get
			{
				return default(ProgressTypes);
			}
			set
			{
			}
		}

		public virtual int Status
		{
			set
			{
			}
		}

		public long ID
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Update()
		{
		}

		public virtual void Open(float delay)
		{
		}

		public virtual void Close(float delay)
		{
		}

		[DebuggerHidden]
		private IEnumerator Play(string name, float delay)
		{
			return null;
		}

		public virtual void SetNewLevel()
		{
		}

		private void OnButtonClick()
		{
		}

		protected virtual void UpdateID(long value)
		{
		}

		public void ShowItem(bool isActive)
		{
		}
	}
}
