using UnityEngine;
using WaterBell.ProjX.Data.Entity;

namespace WaterBell.ProjX.View.Panel
{
	public class ServantInfos : MonoBehaviour
	{
		public Transform isExsit;

		public Transform isNull;

		public ButtonEx mercenaryBtn;

		private GameObject ServantIconPrefab;

		public Transform IconWidget;

		public UILabel svLevel;

		public UILabel wpLevel;

		public GameObject go;

		public UISprite energySlider;

		public UISprite changeBG;

		public UILabel hpLabel;

		public ButtonEx DisClickObj;

		public ButtonEx Btn;

		public long id;

		public long rid;

		private GameObject servantPrefab;

		private GameObject SelectMercenarySvPrefab;

		public Transform MecenaryBg;

		public bool isMercenary;

		public ButtonEx DisClickRestrictObj;

		public Transform upImg;

		private void Awake()
		{
		}

		private bool IsExsitMercenary(int _index)
		{
			return false;
		}

		private void ServantOnClick()
		{
		}

		public void SetNull()
		{
		}

		public void SetMercenary(MercenaryServant _servant)
		{
		}

		private void SetUpImg(long _sid)
		{
		}

		public void SetServantInfo(ObservableSingleServant _servant)
		{
		}

		public void SetrRstrictServantInfo(long _servantID, int _level, int _rank, int _star, int _index, int _wpLevel)
		{
		}

		public void SetSpecial()
		{
		}

		private bool IsFull()
		{
			return false;
		}

		private int GetEnergy(long _id)
		{
			return 0;
		}

		private void SetServantIcon(long _id, int _rank, int _star, int _serial = 1)
		{
		}
	}
}
