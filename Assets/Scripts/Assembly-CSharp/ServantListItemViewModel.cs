using System.Collections.Generic;

public class ServantListItemViewModel : ServantListItemViewModelBase
{
	private ServantListManagerViewModel _ParentServantListManager;

	public long Weapon1ComposeItem1;

	public long Weapon1ComposeItem2;

	public long Weapon1ComposeItem3;

	public long Weapon2ComposeItem1;

	public long Weapon2ComposeItem2;

	public long Weapon2ComposeItem3;

	public long Weapon1ComposeItem1Num;

	public long Weapon1ComposeItem2Num;

	public long Weapon1ComposeItem3Num;

	public long Weapon2ComposeItem1Num;

	public long Weapon2ComposeItem2Num;

	public long Weapon2ComposeItem3Num;

	public long Weapon1ComposeItem1Current;

	public long Weapon1ComposeItem2Current;

	public long Weapon1ComposeItem3Current;

	public long Weapon2ComposeItem1Current;

	public long Weapon2ComposeItem2Current;

	public long Weapon2ComposeItem3Current;

	public long Weapon3ComposeItem1;

	public long Weapon3ComposeItem2;

	public long Weapon3ComposeItem3;

	public long Weapon4ComposeItem1;

	public long Weapon4ComposeItem2;

	public long Weapon4ComposeItem3;

	public long Weapon3ComposeItem1Num;

	public long Weapon3ComposeItem2Num;

	public long Weapon3ComposeItem3Num;

	public long Weapon4ComposeItem1Num;

	public long Weapon4ComposeItem2Num;

	public long Weapon4ComposeItem3Num;

	public long Weapon3ComposeItem1Current;

	public long Weapon3ComposeItem2Current;

	public long Weapon3ComposeItem3Current;

	public long Weapon4ComposeItem1Current;

	public long Weapon4ComposeItem2Current;

	public long Weapon4ComposeItem3Current;

	public virtual P<long> ServantIDProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long ServantID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<ServantListItemInfo> InfoProperty
	{
		get
		{
			return null;
		}
	}

	public virtual ServantListItemInfo Info
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public virtual P<int> LvProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int Lv
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> RankProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int Rank
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> StarProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int Star
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<bool> Wp1CanComposeProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool Wp1CanCompose
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<bool> Wp2CanComposeProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool Wp2CanCompose
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<bool> isExistProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool isExist
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<long> Weapon1IDProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long Weapon1ID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<long> Weapon2IDProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long Weapon2ID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<bool> Weapon1UnlockProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool Weapon1Unlock
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<bool> Weapon2UnlockProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool Weapon2Unlock
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<int> FashionProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int Fashion
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> FavQuestStatusProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int FavQuestStatus
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<long> FavQuestIDProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long FavQuestID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<bool> CanPromoteWp1Property
	{
		get
		{
			return null;
		}
	}

	public virtual bool CanPromoteWp1
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<bool> CanPromoteWp2Property
	{
		get
		{
			return null;
		}
	}

	public virtual bool CanPromoteWp2
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<int> Wp1PromoteLvProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int Wp1PromoteLv
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> Wp2PromoteLvProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int Wp2PromoteLv
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<bool> Wp3CanComposeProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool Wp3CanCompose
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<bool> Wp4CanComposeProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool Wp4CanCompose
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<long> Weapon3IDProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long Weapon3ID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<long> Weapon4IDProperty
	{
		get
		{
			return null;
		}
	}

	public virtual long Weapon4ID
	{
		get
		{
			return 0L;
		}
		set
		{
		}
	}

	public virtual P<bool> Weapon3UnlockProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool Weapon3Unlock
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<bool> Weapon4UnlockProperty
	{
		get
		{
			return null;
		}
	}

	public virtual bool Weapon4Unlock
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<bool> CanPromoteWp3Property
	{
		get
		{
			return null;
		}
	}

	public virtual bool CanPromoteWp3
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<bool> CanPromoteWp4Property
	{
		get
		{
			return null;
		}
	}

	public virtual bool CanPromoteWp4
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public virtual P<int> Wp3PromoteLvProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int Wp3PromoteLv
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> Wp4PromoteLvProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int Wp4PromoteLv
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual P<int> WeaponLevelProperty
	{
		get
		{
			return null;
		}
	}

	public virtual int WeaponLevel
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual ServantListManagerViewModel ParentServantListManager
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public ServantListItemViewModel(ServantListItemControllerBase controller, bool initialize = true)
		: base(null, false)
	{
	}

	public ServantListItemViewModel()
		: base(null, false)
	{
	}

	protected override void WireCommands(Controller controller)
	{
	}

	public override void Write(ISerializerStream stream)
	{
	}

	public override void Read(ISerializerStream stream)
	{
	}

	public override void Unbind()
	{
	}

	protected override void FillProperties(List<ViewModelPropertyInfo> list)
	{
	}

	protected override void FillCommands(List<ViewModelCommandInfo> list)
	{
	}
}
