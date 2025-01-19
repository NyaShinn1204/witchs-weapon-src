using UnityEngine;

namespace Slate.ActionClips
{
	public class SetSprite : ActorActionClip<SpriteRenderer>
	{
		public Sprite sprite;

		public Color color;

		public bool flipX;

		public bool flipY;

		public bool changeSorting;

		[SortingLayer]
		public int sortingLayerID;

		public int sortingOrder;

		private Sprite lastSprite;

		private Color lastColor;

		private bool lastFlipX;

		private bool lastFlipY;

		private int lastSortingLayerID;

		private int lastSortingOrder;

		public override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnEnter()
		{
		}

		protected override void OnReverse()
		{
		}
	}
}
