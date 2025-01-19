using System.Runtime.InteropServices;

public class EventDelegates
{
	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void SkillDelegate(SkillEvent evt);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void BuffDelegate(BuffEvent evt);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void BattleStateDelegate(BattleStateEvent evt);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void BattleAreaDelegate(BattleAreaEvent evt);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void AttackDelegate(AttackEvent evt);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void HitDelegate(HitEvent evt);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void DamageDelegate(DamageEvent evt);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void Damage2Delegate(DamageEvent2 evt);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void HealthDelegate(HealEvent evt);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void WeaponDelegate(WeaponEvent evt);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void AnegyDelegate(AnegyStateEvent evt);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void PowerDelegate(PowerEvent evt);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void WeaponSharpDelegate(WeaponSharpEvent evt);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void WeaponSharpRedDelegate(WeaponSharpRedEvent evt);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void WeaponSharpGreenDelegate(WeaponSharpGreenEvent evt);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void WeaponSharpYellowDelegate(WeaponSharpYellowEvent evt);

	[StructLayout(LayoutKind.Auto, Size = 8)]
	public delegate void WeaponSharChangepDelegate(WeaponSharpChangeEvent evt);
}
