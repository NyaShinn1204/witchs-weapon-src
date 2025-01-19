using System.Collections.Generic;
using UnityEngine;

namespace Slate.ActionClips
{
	public class SpriteFlipbook : ActorActionClip<SpriteRenderer>
	{
		[SerializeField]
		[HideInInspector]
		private float _length;

		public int loops;

		public List<Sprite> sprites;

		public bool endWithPrevious;

		private Sprite lastSprite;

		public override string info
		{
			get
			{
				return null;
			}
		}

		public override float length
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public override bool isValid
		{
			get
			{
				return false;
			}
		}

		protected override void OnEnter()
		{
		}

		protected override void OnUpdate(float deltaTime)
		{
		}

		protected override void OnExit()
		{
		}

		protected override void OnReverse()
		{
		}
	}
}
