using System;
using UnityEngine;

namespace Slate
{
	[ExecuteInEditMode]
	public class AnimatorDispatcher : MonoBehaviour
	{
		private bool wasRootMotion;

		private Animator _animator;

		private Animator animator
		{
			get
			{
				return null;
			}
		}

		public event Action onAnimatorMove
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<int> onAnimatorIK
		{
			add
			{
			}
			remove
			{
			}
		}

		private void Awake()
		{
		}

		private void OnAnimatorMove()
		{
		}

		private void OnAnimatorIK(int index)
		{
		}
	}
}
