using System.Collections.Specialized;

public class CurrentServantWeaponInfoViewModelBase : ViewModel
{
	public P<long> _CurrentWeaponCardIDProperty;

	public P<long> _WeaponExpProperty;

	public P<long> _WeaponLevelProperty;

	public P<bool> _IsUnlockProperty;

	public P<int> _WeaponSpellPromoteLvProperty;

	public P<NeedLoot> _WeaponSpellPromoteItem1Property;

	public P<int> _WeaponSpellPromoteItem1NumProperty;

	public P<NeedLoot> _WeaponSpellPromoteItem2Property;

	public P<int> _WeaponSpellPromoteItem2NumProperty;

	public P<NeedLoot> _WeaponSpellPromoteItem3Property;

	public P<int> _WeaponSpellPromoteItem3NumProperty;

	public P<NeedLoot> _composeItem1Property;

	public P<NeedLoot> _composeItem2Property;

	public P<NeedLoot> _composeItem3Property;

	public P<int> _composeItem1NumProperty;

	public P<int> _composeItem2NumProperty;

	public P<int> _composeItem3NumProperty;

	public P<long> _Weapon1IDProperty;

	public P<long> _Weapon2IDProperty;

	public P<bool> _CanComposeWeapon1Property;

	public P<bool> _CanComposeWeapon2Property;

	public P<int> _ServantWeaponSpellLvProperty;

	public P<int> _CurrentSkinIndexProperty;

	public P<int> _SkinStateProperty;

	public P<bool> _CanPromoteWp1Property;

	public P<bool> _CanPromoteWp2Property;

	public P<long> _Weapon3IDProperty;

	public P<long> _Weapon4IDProperty;

	public P<bool> _CanComposeWeapon3Property;

	public P<bool> _CanComposeWeapon4Property;

	public P<bool> _CanPromoteWp3Property;

	public P<bool> _CanPromoteWp4Property;

	public ModelCollection<ServantWeaponSimpleInfo> _WeaponListProperty;

	public ModelCollection<ServantWeaponExpItemViewModel> _WeaponExpItemsProperty;

	protected CommandWithSenderAndArgument<CurrentServantWeaponInfoViewModel, long> _SelectWeapon;

	protected CommandWithSender<CurrentServantWeaponInfoViewModel> _AddWeapon;

	protected CommandWithSenderAndArgument<CurrentServantWeaponInfoViewModel, long> _ChangeWeapon;

	protected CommandWithSenderAndArgument<CurrentServantWeaponInfoViewModel, string> _AddWeaponExp;

	protected CommandWithSenderAndArgument<CurrentServantWeaponInfoViewModel, int> _TestFakeAddExp;

	protected CommandWithSenderAndArgument<CurrentServantWeaponInfoViewModel, UseItemArgus> _SubmitAddWeaponExp;

	protected CommandWithSender<CurrentServantWeaponInfoViewModel> _PromoteWeaponSpell;

	protected CommandWithSenderAndArgument<CurrentServantWeaponInfoViewModel, long> _ComposeWeapon;

	protected CommandWithSenderAndArgument<CurrentServantWeaponInfoViewModel, int> _SwitchSkin;

	public CurrentServantWeaponInfoViewModelBase(CurrentServantWeaponInfoControllerBase controller, bool initialize = true)
	{
	}

	public CurrentServantWeaponInfoViewModelBase()
	{
	}

	public override void Bind()
	{
	}

	protected virtual void WeaponExpItemsCollectionChanged(NotifyCollectionChangedEventArgs args)
	{
	}
}
