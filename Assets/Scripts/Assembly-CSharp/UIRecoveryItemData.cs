using WaterBell.ProjX.View.Panel;

public class UIRecoveryItemData : UIRawResData
{
	public int count;

	public int price;

	public override UIAtlas rawSelectedIconAtlas
	{
		get
		{
			return null;
		}
	}

	public UIRecoveryItemData(long resID, int _count, int _price)
	{
	}

	protected override void InitOtherAttrs()
	{
	}
}
