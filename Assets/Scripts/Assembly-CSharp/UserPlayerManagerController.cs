using Google.Protobuf.Collections;
using Lootmod;
using WaterBell.ProjX.Data.Entity;

public class UserPlayerManagerController : UserPlayerManagerControllerBase
{
	private string nickName;

	public override void InitializeUserPlayerManager(UserPlayerManagerViewModel userPlayerManager)
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

	private void UpdateSecretShopState(bool state)
	{
	}

	private void UpdatePlayer(PropertyChangeedObservable target)
	{
	}

	public override void ReceiveStamina(UserPlayerManagerViewModel userPlayerManager)
	{
	}

	public void SuccessfulReceiveStamina()
	{
	}

	public void FailedReceiveStamina(string text)
	{
	}

	public override void ChangeCurrentHead(UserPlayerManagerViewModel userPlayerManager, int arg)
	{
	}

	public override void ChangeCurrentHeadBox(UserPlayerManagerViewModel userPlayerManager, int arg)
	{
	}

	public override void ChangeHeadAndBox(UserPlayerManagerViewModel userPlayerManager, string arg)
	{
	}

	public override void ReceiveVip2Gift(UserPlayerManagerViewModel userPlayerManager)
	{
	}

	public void FailedReceiveGift(string text)
	{
	}

	public override void ReceiveVip5Gift(UserPlayerManagerViewModel userPlayerManager)
	{
	}

	private void dealResult(int result, RepeatedField<LootObject> loots)
	{
	}

	private void SuccessfulReceiveGift2()
	{
	}

	private void SuccessfulReceiveGift5()
	{
	}

	public override void ChangeCurrentSvAction(UserPlayerManagerViewModel userPlayerManager, long arg)
	{
	}

	public override void ReName(UserPlayerManagerViewModel userPlayerManager, string arg)
	{
	}

	public void FailReName(string text)
	{
	}

	private void SucccessRename()
	{
	}

	public override void ChangeTitle(UserPlayerManagerViewModel userPlayerManager, long arg)
	{
	}

	public override void Redeem(UserPlayerManagerViewModel userPlayerManager, string arg)
	{
	}

	public void SuccessfulRedeem()
	{
	}

	public void FailedRedeem(string text)
	{
	}

	private void dealRedeemResult(int result, bool isSpCode, RepeatedField<LootObject> loots)
	{
	}

	public override void ReceivePhoneReward(UserPlayerManagerViewModel userPlayerManager)
	{
	}

	private void SuccessfulReceiveBindPhoneReward()
	{
	}

	private void dealReceivePhoneRewardResult(int result, RepeatedField<LootObject> loots)
	{
	}

	public override void UseInviteCode(UserPlayerManagerViewModel userPlayerManager, long arg)
	{
	}

	private void AfterUseInviteCode()
	{
	}

	public void FailUseInviteCode(string text)
	{
	}

	public override void ReceiveBeInvitedReward(UserPlayerManagerViewModel userPlayerManager, long arg)
	{
	}

	private void AfterReceiveBeInvitedReward()
	{
	}

	public void FailReceiveBeInvitedReward(string text)
	{
	}

	public override void ReceiveInviteReward(UserPlayerManagerViewModel userPlayerManager, long arg)
	{
	}

	private void AfterReceiveInviteReward()
	{
	}

	public void FailReceiveInviteReward(string text)
	{
	}

	public override void SyncInviteInfo(UserPlayerManagerViewModel userPlayerManager)
	{
	}

	private void finishSync()
	{
	}
}
