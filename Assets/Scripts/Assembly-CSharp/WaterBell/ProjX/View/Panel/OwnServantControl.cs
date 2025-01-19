using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class OwnServantControl : MonoBehaviour
	{
		public ButtonEx addBtn;

		public ButtonEx removeBtn;

		public ButtonEx disRemoveBtn;

		public Transform Inner;

		public UISprite Icon;

		public UITexture photo;

		public UITexture specialPhoto;

		public UILabel Time;

		public Transform Star;

		public UISprite Rank;

		public UILabel Fighting;

		public UILabel Lv;

		public Transform wpWidget;

		public Transform addIcon;

		public Transform CanRmove;

		public Transform CannotRemove;

		public UILabel RewardValue;

		public UISprite RewardSlider;

		public long servantID;

		private long _time;

		private int Profit;

		public Transform infoView;

		public ButtonEx bgBox;

		public UILabel dailyTimeValue;

		public UILabel dailyGoldValue;

		public UILabel totalTimeValue;

		public UILabel totalGoldValue;

		public UILabel goldValue;

		public ButtonEx lookAtBtn;

		private GameObject weaponIcon;

		private const float PHOTO_SCALE_V = 0.7f;

		private void Awake()
		{
		}

		public void IsExistUI(GuildMercenarySv sv)
		{
		}

		private float GetPosition(long _length)
		{
			return 0f;
		}

		public void IsNullUI()
		{
		}

		public void LockUI()
		{
		}

		private void Remove()
		{
		}

		private void Add()
		{
		}

		private void FreshTime()
		{
		}

		private void IsRemoveType(bool _active)
		{
		}

		private void SetPhoto(long id)
		{
		}
	}
}
