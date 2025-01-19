using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class ExpGeneralLevelIcon : MonoBehaviour
	{
		public enum LevelStates
		{
			General = 0,
			Lock = 1,
			Pass = 2
		}

		public long id;

		public UIWidget general;

		public UIWidget lockWeight;

		public UIWidget pass;

		public PositionSync pointSync;

		private UILabel indexLabel;

		private UISprite typeIcon;

		private UISprite thumb;

		private LevelStates m_LevelState;

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

		public int LevelIndex
		{
			set
			{
			}
		}

		public LevelStates LevelState
		{
			get
			{
				return default(LevelStates);
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void UpdateView()
		{
		}

		public void OnChildClick()
		{
		}
	}
}
