using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class SettlementLootUI : MonoBehaviour
	{
		private static int ServantPieceType;

		private static int EquitPieceType;

		private static int ConsumeType;

		public UIImageNGUI photo;

		public UIImageNGUI bg;

		public UILabel countLabel;

		public GameObject Piece;

		[Space]
		public TweenScale tweenScale;

		public TweenRotation tweenRotation;

		public TweenAlpha tweenAlpha;

		private bool hasLoot;

		public bool HasLoot
		{
			get
			{
				return false;
			}
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void SetLoot(bool hasLoot, string icon = "", int count = 0, int quality = 0, int lootType = 0)
		{
		}

		private void Init()
		{
		}

		public void Show(float delay = 0f)
		{
		}
	}
}
