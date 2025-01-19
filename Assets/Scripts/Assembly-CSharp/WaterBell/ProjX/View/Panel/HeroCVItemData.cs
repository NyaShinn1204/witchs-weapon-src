using WaterBell.ProjX.Core.Manager.Audio;

namespace WaterBell.ProjX.View.Panel
{
	public class HeroCVItemData : UIDataBase
	{
		public long favLV;

		public int index;

		public bool isLock;

		public CharacterVoice.CVPreviewItem cvItem;

		public HeroCVItemData(long id, long favLV, int index, bool isLock, CharacterVoice.CVPreviewItem cvItem)
		{
		}
	}
}
