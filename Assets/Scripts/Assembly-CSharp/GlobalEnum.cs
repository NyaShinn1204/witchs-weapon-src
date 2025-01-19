public class GlobalEnum
{
	public enum InstanceType
	{
		OtherInstance = 0,
		CoreInstance = 1,
		NormalInstance = 2,
		EliteInstance = 3
	}

	public enum CombatAttrType
	{
		HP = 0,
		PATK = 1,
		MATK = 2,
		PDEF = 3,
		MDEF = 4,
		HR = 5,
		DR = 6,
		IPDR = 7,
		IMDR = 8,
		PCR = 9,
		MCR = 10,
		PCM = 11,
		MCM = 12
	}

	public enum PropertyType
	{
		HP = 0,
		PATK = 1,
		MATK = 2,
		PDEF = 3,
		MDEF = 4,
		HV = 5,
		DV = 6,
		IPDV = 7,
		IMDV = 8,
		PCV = 9,
		MCV = 10,
		PCMV = 11,
		MCMV = 12,
		HR = 13,
		DR = 14,
		IPDR = 15,
		IMDR = 16,
		PCR = 17,
		MCR = 18,
		PCM = 19,
		MCM = 20,
		EnergyRestoreTime = 99,
		EnergyRestoreKillingTime = 100,
		EnergyRestoreAttacked = 101,
		EnergyRestoreInjured = 102
	}

	public enum SpellType
	{
		CommonSpell = 1,
		ActiveSpell = 2,
		PassiveSpell = 3,
		WeaponSpell = 4
	}

	public enum ItemType
	{
		ServantPiece = 1,
		EquipPiece = 2,
		Supply = 3
	}

	public enum InstanceSetType
	{
		Test = 0,
		Main = 1,
		Daily = 2
	}

	public enum PackageTypes
	{
		Equip = 0,
		Item = 1
	}

	public enum ResItemType
	{
		None = 0,
		ServantShard = 1,
		EquipShard = 2,
		Consumable = 3,
		WeaponShard = 4,
		Curreny = 5,
		Goods = 6,
		Display = 9
	}

	public enum ResConsumableItemType
	{
		None = 0,
		WeaponExp = 1,
		ServantExp = 2,
		Stamina = 3,
		Gold = 4,
		Chest = 5,
		ActivityBuff = 6,
		ActivityCurrency = 7,
		Chest2 = 8,
		SPWeaponExp = 9,
		FashionChest = 13,
		ItemChest = 14,
		ChooseItemChest = 15,
		Ticket = 16
	}

	public enum ResType
	{
		Undefine = 0,
		Servant = 1,
		Equip = 2,
		Item = 3,
		Weapon = 4,
		Fashion = 5,
		Rune = 6,
		RoleExp = 10,
		ServantExp = 11,
		Stamina = 12,
		Gold = 13,
		Csc = 14,
		VC_Red = 15,
		VC_Yellow = 16,
		VC_Blue = 17,
		VC_Green = 18,
		Guild = 19,
		VipExp = 20,
		VipPoint = 21,
		ActivityStamina = 22,
		DrawCurrency = 23,
		ServantFavor = 24,
		StoryCurrency = 25,
		ActivityStoryCurrency = 26,
		BranchlineStoryCurrency = 27,
		RecycleCurrency = 28,
		GuildVitality = 70,
		Avatar = 80,
		AvatarFrame = 81,
		MonthCard = 82,
		CharacterGesture = 83,
		ServantDisplayGesture = 84,
		ServantStandPaint = 85,
		ServantWeaponFashion = 86,
		Title = 87,
		ServantFashion = 88,
		RealDiamond = 98,
		Diamond = 99,
		WeaponAwake = 1000,
		EnemyMob = 1001,
		WeaponAndServant = 1002
	}

	public enum ResQuality
	{
		None = 0,
		White = 1,
		Green = 2,
		Blue = 3,
		Purple = 4,
		Orange = 5
	}

	public enum ServantItemTypes
	{
		HAVENOTSERVANT = 0,
		HAVESERVANT = 1,
		CANHAVENSERVANT = 2
	}

	public enum MainItemType
	{
		Nomal = 0,
		Special = 1
	}

	public enum GuildPrivilege
	{
		Member = 1,
		Admin = 2,
		President = 4
	}

	public enum ResouceType
	{
		Stamina = 12,
		Gold = 13,
		Maze = 14,
		Red = 15,
		Yellow = 16,
		Blue = 17,
		Green = 18,
		Association = 19,
		Contribution = 20,
		Vip = 21,
		ActivityStamina = 22,
		Draw = 23,
		Story = 25,
		ActivityStory = 26,
		BranchLineStory = 27,
		RecycleCurrency = 28,
		Prestige = 70,
		Diamond = 99,
		ItemCurrency = 101,
		DrawItem = 200,
		Fashion = 201,
		ActivitySpeedUp = 202,
		ActivityCurrency = 999,
		ActivityCurrency2 = 1000
	}

	public enum ShopStyle
	{
		diamond = 1,
		gift = 2,
		resouce = 3,
		currency = 4,
		special = 5
	}
}
