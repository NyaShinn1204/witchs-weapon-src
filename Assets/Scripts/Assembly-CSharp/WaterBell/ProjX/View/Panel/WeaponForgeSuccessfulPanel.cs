using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class WeaponForgeSuccessfulPanel : UIPanelSingle
	{
		public GameObject unlockWeaponAwake;

		public UILabel currentLevelLabel;

		public UILabel prevLevelLabel;

		public UILabel atkLabel;

		public UILabel prevAtkLabel;

		public UILabel prevMatkLabel;

		public UILabel matkLabel;

		public ButtonEx closeButton;

		public GameObject effSource;

		private GameObject eff;

		protected override void Awake()
		{
		}

		public void OpenPanel(long weaponId, int forgeLevel, long atk, long prevAtk, long MATK, long prevMATK)
		{
		}

		public void PlayUnlokSound()
		{
		}
	}
}
