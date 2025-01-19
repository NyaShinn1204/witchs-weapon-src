using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class BossLevelIcon : MonoBehaviour
	{
		private static Color normalColor;

		private static Color lockColor;

		private static Color hardColor;

		private const string UnknownPhoto = "Unknown";

		public GameObject normalState;

		public GameObject hardState;

		public GameObject lockState;

		public GameObject star;

		public UILabel level;

		public UILabel chapter;

		public UILabel power;

		public UISprite photo;

		public LevelIcon levelIcon;

		protected long m_LevelId;

		private bool m_Lock;

		public bool Lock
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public long LevelId
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		public static string GetBossIcon(long levelID)
		{
			return null;
		}

		protected void OnClick()
		{
		}

		private void HideAllState()
		{
		}
	}
}
