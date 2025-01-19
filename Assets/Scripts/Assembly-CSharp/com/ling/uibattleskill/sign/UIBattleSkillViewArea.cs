using System.Collections.Generic;
using UnityEngine;

namespace com.ling.uibattleskill.sign
{
	public class UIBattleSkillViewArea
	{
		private GameObject _view;

		private GameObject _viewRound;

		private GameObject _viewRoundDir;

		private GameObject _viewRecO;

		private GameObject _viewRecV;

		private Dictionary<int, HashSet<GameObject>> _viewHashShow;

		private GameObject[] _viewHashShowArr;

		private Color _color;

		private bool _viewChange;

		public Color color
		{
			set
			{
			}
		}

		public bool isShow
		{
			get
			{
				return false;
			}
		}

		public void draw(UIBattleSkillViewSkillJoystick sJoystick)
		{
		}

		private void drawViewHide(int sType)
		{
		}

		public void hide()
		{
		}

		public UIBattleSkill.UIBattleSkillReleaseData releaseData(UIBattleSkillViewSkillJoystick sJoystick)
		{
			return null;
		}
	}
}
