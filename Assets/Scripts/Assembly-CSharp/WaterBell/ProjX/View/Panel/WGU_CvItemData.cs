using WaterBell.ProjX.Core.Manager.Audio;

namespace WaterBell.ProjX.View.Panel
{
	public class WGU_CvItemData : UIDataBase
	{
		public long favLV;

		public int index;

		public bool isLock;

		public CharacterVoice.CVPreviewItem cvItem;

		public WGU_CvItemData(long id, long favLV, int index, bool isLock, CharacterVoice.CVPreviewItem cvItem)
		{
		}
	}
}
