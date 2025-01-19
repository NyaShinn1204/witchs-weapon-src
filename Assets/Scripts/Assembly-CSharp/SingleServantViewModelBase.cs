using System;
using System.Collections.Generic;
using System.Diagnostics;

public class SingleServantViewModelBase : ViewModel
{
	private IDisposable _ServantMainInfoComputedPropertyDisposable;

	private IDisposable _SpellActiveComputedPropertyDisposable;

	private IDisposable _SpellPassive1ComputedPropertyDisposable;

	private IDisposable _SpellPassive2ComputedPropertyDisposable;

	private IDisposable _SpellPassive3mputedPropertyDisposable;

	private IDisposable _EquipInfoComputedPropertyDisposable;

	private IDisposable _ServantPropertyComputedPropertyDisposable;

	public P<long> _ServantCardIDProperty;

	public P<int> _LvProperty;

	public P<long> _ExpProperty;

	public P<long> _FavLvProperty;

	public P<long> _FavExpProperty;

	public P<int> _RankProperty;

	public P<int> _StarProperty;

	public P<int> _SpellActiveLevelProperty;

	public P<int> _SpellPassiveLevel1Property;

	public P<int> _SpellPassiveLevel2Property;

	public P<int> _SpellPassiveLevel3Property;

	public P<bool> _equip1canUseProperty;

	public P<bool> _equip2CanUseProperty;

	public P<bool> _equip3CanUseProperty;

	public P<bool> _equip4CanUseProperty;

	public P<bool> _equip5CanUseProperty;

	public P<bool> _equip6CanUseProperty;

	public P<long> _equip1Property;

	public P<long> _equip2Property;

	public P<long> _equip3Property;

	public P<long> _equip4Property;

	public P<long> _equip5Property;

	public P<long> _equip6Property;

	public P<bool> _equipCanCompse1Property;

	public P<bool> _equipCanCompse2Property;

	public P<bool> _equipCanCompse3Property;

	public P<bool> _equipCanCompse4Property;

	public P<bool> _equipCanCompse5Property;

	public P<bool> _equipCanCompse6Property;

	public P<long> _ExpLimitProperty;

	public P<int> _WeaponLvProperty;

	public P<bool> _Weapon1UnlockProperty;

	public P<bool> _Weapon2UnlockProperty;

	public P<int> _Wp1PromoteLvProperty;

	public P<int> _Wp2PromoteLvProperty;

	public P<int> _Wp1SpPromoteLvProperty;

	public P<int> _Wp2SpPromoteLvProperty;

	public P<bool> _ShowCanRankupProperty;

	public P<bool> _ShowCanStarUpProperty;

	public P<int> _CurrentImangeProperty;

	public P<long> _FavQuestIDProperty;

	public P<int> _FavQuestStatusProperty;

	public P<int> _FavQuestMetaProperty;

	public P<bool> _ShowFavRedStarProperty;

	public P<bool> _ShowNewImageProperty;

	public P<bool> _Weapon3UnlockProperty;

	public P<bool> _Weapon4UnlockProperty;

	public P<int> _Wp3PromoteLvProperty;

	public P<int> _Wp4PromoteLvProperty;

	public P<int> _Wp3SpPromoteLvProperty;

	public P<int> _Wp4SpPromoteLvProperty;

	public P<ServantMainInfo> _ServantMainInfoComputedPropertyProperty;

	public P<Spell> _SpellActiveComputedPropertyProperty;

	public P<Spell> _SpellPassive1ComputedPropertyProperty;

	public P<Spell> _SpellPassive2ComputedPropertyProperty;

	public P<Spell> _SpellPassive3mputedPropertyProperty;

	public P<bool> _EquipInfoComputedPropertyProperty;

	public P<ServantPropertyInfo> _ServantPropertyComputedPropertyProperty;

	protected CommandWithSender<SingleServantViewModel> _GotoPreServant;

	protected CommandWithSender<SingleServantViewModel> _GotoNextServant;

	protected CommandWithSender<SingleServantViewModel> _AddRank;

	protected CommandWithSenderAndArgument<SingleServantViewModel, int> _AddSpellActiveLevel;

	protected CommandWithSenderAndArgument<SingleServantViewModel, int> _AddSpellPassiveLevel1;

	protected CommandWithSenderAndArgument<SingleServantViewModel, int> _AddSpellPassiveLevel2;

	protected CommandWithSenderAndArgument<SingleServantViewModel, int> _AddSpellPassiveLevel3;

	protected CommandWithSender<SingleServantViewModel> _EquipAll;

	protected CommandWithSenderAndArgument<SingleServantViewModel, int> _UseEuip;

	protected CommandWithSenderAndArgument<SingleServantViewModel, UseItemArgus> _AddExp;

	protected CommandWithSenderAndArgument<SingleServantViewModel, long> _ComposeEquip;

	protected CommandWithSenderAndArgument<SingleServantViewModel, long> _ComposeEquipOneClick;

	protected CommandWithSenderAndArgument<SingleServantViewModel, int> _ChangeImage;

	protected CommandWithSenderAndArgument<SingleServantViewModel, int> _ReceiveImageFav;

	protected CommandWithSender<SingleServantViewModel> _FinishFavQuest;

	public SingleServantViewModelBase(SingleServantControllerBase controller, bool initialize = true)
	{
	}

	public SingleServantViewModelBase()
	{
	}

	public override void Bind()
	{
	}

	public virtual void ResetServantMainInfoComputedProperty()
	{
	}

	public virtual void ResetSpellActiveComputedProperty()
	{
	}

	public virtual void ResetSpellPassive1ComputedProperty()
	{
	}

	public virtual void ResetSpellPassive2ComputedProperty()
	{
	}

	public virtual void ResetSpellPassive3mputedProperty()
	{
	}

	public virtual void ResetEquipInfoComputedProperty()
	{
	}

	public virtual void ResetServantPropertyComputedProperty()
	{
	}

	public virtual ServantMainInfo ComputeServantMainInfoComputedProperty()
	{
		return null;
	}

	[DebuggerHidden]
	public virtual IEnumerable<IObservableProperty> GetServantMainInfoComputedPropertyDependents()
	{
		return null;
	}

	public virtual Spell ComputeSpellActiveComputedProperty()
	{
		return null;
	}

	[DebuggerHidden]
	public virtual IEnumerable<IObservableProperty> GetSpellActiveComputedPropertyDependents()
	{
		return null;
	}

	public virtual Spell ComputeSpellPassive1ComputedProperty()
	{
		return null;
	}

	[DebuggerHidden]
	public virtual IEnumerable<IObservableProperty> GetSpellPassive1ComputedPropertyDependents()
	{
		return null;
	}

	public virtual Spell ComputeSpellPassive2ComputedProperty()
	{
		return null;
	}

	[DebuggerHidden]
	public virtual IEnumerable<IObservableProperty> GetSpellPassive2ComputedPropertyDependents()
	{
		return null;
	}

	public virtual Spell ComputeSpellPassive3mputedProperty()
	{
		return null;
	}

	[DebuggerHidden]
	public virtual IEnumerable<IObservableProperty> GetSpellPassive3mputedPropertyDependents()
	{
		return null;
	}

	public virtual bool ComputeEquipInfoComputedProperty()
	{
		return false;
	}

	[DebuggerHidden]
	public virtual IEnumerable<IObservableProperty> GetEquipInfoComputedPropertyDependents()
	{
		return null;
	}

	public virtual ServantPropertyInfo ComputeServantPropertyComputedProperty()
	{
		return null;
	}

	[DebuggerHidden]
	public virtual IEnumerable<IObservableProperty> GetServantPropertyComputedPropertyDependents()
	{
		return null;
	}
}
