using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public abstract class RegAndLoginSubView : MonoBehaviour, IRegAndLoginView
	{
		protected LoginFormal ctrl;

		public virtual void Hide()
		{
		}

		public virtual void Show()
		{
		}

		protected virtual void ReturnBack2PrevView()
		{
		}

		protected virtual void AssignUIEvent()
		{
		}

		public void ShowTipsBox(string text)
		{
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}
	}
}
