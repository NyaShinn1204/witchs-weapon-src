using System.Collections.Generic;
using Levelmod;
using Lootmod;
using WaterBell.ProjX.Data.Entity;

public class BattleResult
{
	public const int ServantType = 1;

	public const int UserExpType = 10;

	public const int ServantExpType = 11;

	public const int StaminaType = 12;

	public const int GoldType = 13;

	public int BeforeBattleUserLV;

	public int BeforeBattleUserStamina;

	public bool Pass;

	public bool isFirstTimeWinCurrInstance;

	public LootList lootList;

	public LootList weaponSpecifiedLootList;

	public List<long> weaponRandomLootList;

	public long currentRandomLootID;

	public List<long> UserReceiveRandomItem;

	public int RoleStamina;

	public bool isAssignedValue;

	public bool isDirty;

	public void Reset()
	{
	}

	public void Parse(Levelmod.BattleResult result)
	{
	}

	public void ParseForExpeditionAndAP(Lootmod.LootResult LootResult)
	{
	}

	public void AddRMBForChallenge(int diamond)
	{
	}
}
