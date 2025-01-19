using System.Collections.Generic;
using WaterBell.ProjX.Core.Manager.Audio;

namespace WaterBell.ProjX.View.Panel
{
	public class HeroCVItem : UIPanelSingle, AudioPlay.AudioPlayListener
	{
		private static readonly string lockIcon;

		private static readonly string soundIcon;

		private static List<HeroCVItem> itemList;

		private static AudioPlay lastAudioPlay;

		public UISprite icon;

		public UILabel nameLabel;

		public UIPanel mask;

		public float speed;

		public bool isPlay;

		private ButtonEx button;

		private HeroCVItemData cvItemData;

		protected override void Awake()
		{
		}

		private void FixedUpdate()
		{
		}

		protected override void OnDestroy()
		{
		}

		public override void UpdatePanel()
		{
		}

		public void Stop()
		{
		}

		private void PlaySound()
		{
		}

		public void UpdateLayer()
		{
		}

		protected override void OnDisable()
		{
		}

		public void OnPlayStatusChanged(AudioPlay obj, AudioPlay.AudioStatus status)
		{
		}
	}
}
