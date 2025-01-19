using Google.Protobuf.Collections;
using Lootmod;
using WaterBell.ProjX.Data.Entity;

public class DrawSystemManagerController : DrawSystemManagerControllerBase
{
	public long GiftCouponID;

	public override void InitializeDrawSystemManager(DrawSystemManagerViewModel drawSystemManager)
	{
	}

	private void UpdateCanFreeDraw(PropertyChangeedObservable target)
	{
	}

	private void AddItem(ObservableSingleItem item)
	{
	}

	private void RemoveItem(ObservableSingleItem item)
	{
	}

	private void UpdateItem(PropertyChangeedObservable target)
	{
	}

	private void UpdatePlayer(PropertyChangeedObservable target)
	{
	}

	public override void Draw(DrawSystemManagerViewModel drawSystemManager, DrawArgu arg)
	{
	}

	private void FakeDrawTen(long fakeid)
	{
	}

	private void ActivityDrawSingle()
	{
	}

	private void ActivityDrawTen()
	{
	}

	private void SpecialActivityDrawSingle(long baseID)
	{
	}

	private void SpecialActivityDrawTen(long baseID)
	{
	}

	private void SpecialPersonActivityDrawSingle(long baseID)
	{
	}

	private void SpecialPersonActivityDrawTen(long baseID)
	{
	}

	private void GoldDrawSingle(int type)
	{
	}

	private void dealResult(int result, RepeatedField<LootObject> loots)
	{
	}

	private void GoldDrawTen(int drawType)
	{
	}

	private void RmbDrawSingle(int drawType)
	{
	}

	private void RmbDrawTen()
	{
	}

	private void GuideDrawSinge(int drawSerial)
	{
	}

	public void SuccessfulDraw()
	{
	}

	private long ToTimeStamp()
	{
		return 0L;
	}

	public void FailedDraw(string text)
	{
	}
}
