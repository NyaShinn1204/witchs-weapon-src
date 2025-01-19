using UnityEngine;

namespace Slate.ActionClips
{
	public class SetSortingLayer : ActorActionClip<SpriteRenderer>
	{
		public int sortingOrder;

		[SortingLayer]
		public int sortingLayerID;

		private string _lastLayer;

		private int _lastOrder;

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
