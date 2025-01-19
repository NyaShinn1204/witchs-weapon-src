public class ServantListItemViewModelBase : ViewModel
{
	public P<long> _ServantIDProperty;

	public P<ServantListItemInfo> _InfoProperty;

	public P<int> _LvProperty;

	public P<int> _RankProperty;

	public P<int> _StarProperty;

	public P<bool> _Wp1CanComposeProperty;

	public P<bool> _Wp2CanComposeProperty;

	public P<bool> _isExistProperty;

	public P<long> _Weapon1IDProperty;

	public P<long> _Weapon2IDProperty;

	public P<bool> _Weapon1UnlockProperty;

	public P<bool> _Weapon2UnlockProperty;

	public P<int> _FashionProperty;

	public P<int> _FavQuestStatusProperty;

	public P<long> _FavQuestIDProperty;

	public P<bool> _CanPromoteWp1Property;

	public P<bool> _CanPromoteWp2Property;

	public P<int> _Wp1PromoteLvProperty;

	public P<int> _Wp2PromoteLvProperty;

	public P<bool> _Wp3CanComposeProperty;

	public P<bool> _Wp4CanComposeProperty;

	public P<long> _Weapon3IDProperty;

	public P<long> _Weapon4IDProperty;

	public P<bool> _Weapon3UnlockProperty;

	public P<bool> _Weapon4UnlockProperty;

	public P<bool> _CanPromoteWp3Property;

	public P<bool> _CanPromoteWp4Property;

	public P<int> _Wp3PromoteLvProperty;

	public P<int> _Wp4PromoteLvProperty;

	public P<int> _WeaponLevelProperty;

	public ServantListItemViewModelBase(ServantListItemControllerBase controller, bool initialize = true)
	{
	}

	public ServantListItemViewModelBase()
	{
	}

	public override void Bind()
	{
	}
}
