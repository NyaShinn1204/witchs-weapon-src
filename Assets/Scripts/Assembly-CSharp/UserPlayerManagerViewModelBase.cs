public class UserPlayerManagerViewModelBase : ViewModel
{
	public P<string> _RoleIDProperty;

	public P<long> _GoldProperty;

	public P<int> _LevelProperty;

	public P<long> _ExpProperty;

	public P<int> _VitProperty;

	public P<int> _VipProperty;

	public P<long> _VittimeProperty;

	public P<int> _FreeGoldDrawProperty;

	public P<int> _FreeRMBDrawProperty;

	public P<int> _BuyVitTimeProperty;

	public P<int> _BuyGoldTimeProperty;

	public P<long> _RMBProperty;

	public P<int> _ExpdeditionTimeProperty;

	public P<int> _ReceiveStaminaResultProperty;

	public P<int> _HeadProperty;

	public P<int> _HeadBoxProperty;

	public P<int> _VipExpProperty;

	public P<int> _VipPointProperty;

	public P<bool> _Vip2GiftStateProperty;

	public P<bool> _Vip5GiftStateProperty;

	public P<int> _StoryCurrencyProperty;

	public P<int> _ActivityStoryCurrencyProperty;

	public P<int> _DrawCurrencyProperty;

	public P<bool> _SecretShop1StateProperty;

	public P<bool> _SecretShop2StateProperty;

	public P<int> _RenameItemNumProperty;

	public P<int> _RenameResultProperty;

	public P<int> _RedeemResultProperty;

	public P<bool> _isSpecialRCodeProperty;

	public P<int> _FashionItemNumProperty;

	public P<bool> _CanReceiveStaminaProperty;

	public P<bool> _isReceivePhoneRewardProperty;

	public P<int> _RecycleCurrencyProperty;

	public P<long> _InviteOpResultProperty;

	public ModelCollection<DrawResultData> _DrawLootProperty;

	public ModelCollection<DrawResultData> _ExtraWeaponProperty;

	protected CommandWithSender<UserPlayerManagerViewModel> _ReceiveStamina;

	protected CommandWithSender<UserPlayerManagerViewModel> _FinishReceiveStamina;

	protected CommandWithSenderAndArgument<UserPlayerManagerViewModel, int> _ChangeCurrentHead;

	protected CommandWithSenderAndArgument<UserPlayerManagerViewModel, int> _ChangeCurrentHeadBox;

	protected CommandWithSenderAndArgument<UserPlayerManagerViewModel, string> _ChangeHeadAndBox;

	protected CommandWithSender<UserPlayerManagerViewModel> _ReceiveVip2Gift;

	protected CommandWithSender<UserPlayerManagerViewModel> _ReceiveVip5Gift;

	protected CommandWithSender<UserPlayerManagerViewModel> _FinishReceiveGift;

	protected CommandWithSenderAndArgument<UserPlayerManagerViewModel, long> _ChangeCurrentSvAction;

	protected CommandWithSenderAndArgument<UserPlayerManagerViewModel, string> _ReName;

	protected CommandWithSender<UserPlayerManagerViewModel> _FinishReName;

	protected CommandWithSenderAndArgument<UserPlayerManagerViewModel, long> _ChangeTitle;

	protected CommandWithSenderAndArgument<UserPlayerManagerViewModel, string> _Redeem;

	protected CommandWithSender<UserPlayerManagerViewModel> _FinishRedeem;

	protected CommandWithSender<UserPlayerManagerViewModel> _ReceivePhoneReward;

	protected CommandWithSenderAndArgument<UserPlayerManagerViewModel, long> _ReceiveInviteReward;

	protected CommandWithSender<UserPlayerManagerViewModel> _FinishReceiveInviteReward;

	protected CommandWithSenderAndArgument<UserPlayerManagerViewModel, long> _ReceiveBeInvitedReward;

	protected CommandWithSender<UserPlayerManagerViewModel> _FinishReceiveBeInvitedReward;

	protected CommandWithSenderAndArgument<UserPlayerManagerViewModel, long> _UseInviteCode;

	protected CommandWithSender<UserPlayerManagerViewModel> _FinishUseInviteCode;

	protected CommandWithSender<UserPlayerManagerViewModel> _SyncInviteInfo;

	protected CommandWithSender<UserPlayerManagerViewModel> _FinishSyncInviteInfo;

	public UserPlayerManagerViewModelBase(UserPlayerManagerControllerBase controller, bool initialize = true)
	{
	}

	public UserPlayerManagerViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
