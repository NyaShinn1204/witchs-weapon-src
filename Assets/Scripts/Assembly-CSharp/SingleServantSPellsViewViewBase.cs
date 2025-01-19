using UnityEngine;

public class SingleServantSPellsViewViewBase : SingleServantViewBase
{
	[HideInInspector]
	public bool _BindSpellActiveComputedProperty;

	[HideInInspector]
	public bool _BindSpellPassive1ComputedProperty;

	[HideInInspector]
	public bool _BindSpellPassive2ComputedProperty;

	[HideInInspector]
	public bool _BindSpellPassive3mputedProperty;

	[HideInInspector]
	public bool _BindAddSpellActiveLevel;

	[HideInInspector]
	public bool _BindAddSpellPassiveLevel1;

	[HideInInspector]
	public bool _BindAddSpellPassiveLevel2;

	[HideInInspector]
	public bool _BindAddSpellPassiveLevel3;

	[HideInInspector]
	public bool _BindLv;

	public override ViewModel CreateModel()
	{
		return null;
	}

	public virtual void SpellActiveComputedPropertyChanged(Spell value)
	{
	}

	public virtual void SpellPassive1ComputedPropertyChanged(Spell value)
	{
	}

	public virtual void SpellPassive2ComputedPropertyChanged(Spell value)
	{
	}

	public virtual void SpellPassive3mputedPropertyChanged(Spell value)
	{
	}

	public virtual void AddSpellActiveLevelExecuted()
	{
	}

	public virtual void AddSpellPassiveLevel1Executed()
	{
	}

	public virtual void AddSpellPassiveLevel2Executed()
	{
	}

	public virtual void AddSpellPassiveLevel3Executed()
	{
	}

	public virtual void LvChanged(int value)
	{
	}

	public override void Bind()
	{
	}
}
