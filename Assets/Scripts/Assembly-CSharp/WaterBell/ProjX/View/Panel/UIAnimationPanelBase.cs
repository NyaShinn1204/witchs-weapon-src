using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;

namespace WaterBell.ProjX.View.Panel
{
	public class UIAnimationPanelBase : UIPanelBase
	{
		protected Animator m_Animator;

		protected override void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		public override void OpenPanel(UIDataBase mData = null)
		{
		}

		public override void ClosePanel(Action action = null)
		{
		}

		public virtual void EnterAnimation()
		{
		}

		public virtual void EnterAnimation(EventDelegate.Callback onComplete)
		{
		}

		public virtual void QuitAnimation()
		{
		}

		public virtual void QuitAnimation(EventDelegate.Callback onComplete)
		{
		}

		public virtual void ResetAnimation()
		{
		}

		public override void ResetPanel()
		{
		}

		public void Play(string animName, float delay = 0f)
		{
		}

		[DebuggerHidden]
		private IEnumerator PlayDelay(string animName, float delay = 0f)
		{
			return null;
		}

		public virtual void Disappear()
		{
		}

		public virtual void Pause()
		{
		}

		public virtual void Resume()
		{
		}

		public void CancelAnimator()
		{
		}

		public void UseAnimator()
		{
		}

		public void PlaySound(string residStr)
		{
		}

		public virtual void GC()
		{
		}
	}
}
