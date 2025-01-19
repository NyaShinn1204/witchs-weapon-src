namespace WaterBell.ProjX.Playmode
{
	public interface CoreBattleSubManager
	{
		void OnLoadIn();

		void OnPreCombatBegin();

		void OnCoreCombatBegin();

		void OnCombatExit();

		void OnCombatRestart();
	}
}
