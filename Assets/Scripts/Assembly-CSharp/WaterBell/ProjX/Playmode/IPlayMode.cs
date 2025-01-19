using System.Collections.Generic;
using Levelmod;
using UnityEngine;
using WaterBell.ProjX.Data.Entity;
using WaterBell.ProjX.Data.NetIO;

namespace WaterBell.ProjX.Playmode
{
	public interface IPlayMode
	{
		ModeType GetModeType();

		PlayModeState GetState();

		long GetInstanceID();

		bool IsSameDay();

		long GetChapterID();

		long[] GetSelectedSvCardIDArr();

		long[] GetSelectedSvBelongToRoleArr();

		long[] GetSelectedWpCardIDArr();

		UserInfoSimple GetUserInfoSimple();

		void GenerateUserInfoSimpleWhenQuit();

		BattleResult GetBattleResult();

		long GetStartBattleTime();

		string GetSelectedSvCardIDArrCompactStr();

		void Renew(long instID);

		ActionResult IsAble2SelectCard();

		ActionResult IsAble2BeginGame();

		ActionResult IsAllowShowSweepGameOnce();

		ActionResult IsAllowShowSweepGameMultiTime();

		ActionResult IsAble2SweepGameOnce();

		ActionResult IsAble2SweepGameMultiTime();

		void DeselectCard(int slotIdx);

		long[] SelectCards(long[] svCardIDArr, long[] roleID);

		void SwitchWeapon(int slotIdx, long svWeaponID);

		void SetQuickWin(bool isQuickWin);

		List<NetMsgBase> BuildInitialNetMsgList();

		void ParseInstanceSettingData(string jsonStr);

		void ParseBattleResult(Levelmod.BattleResult result);

		void OnShowDetailBegin();

		void OnShowDetailReturn();

		void OnSelectCardBegin();

		void OnSelectCardReturn();

		void OnTryStartBegin();

		void OnLoadInBegin();

		void OnLoadOutBegin();

		void OnLoadOutEnd();

		void OnPreCombatBegin();

		void OnCoreCombatBegin();

		void UpdateLoop4CoreCombat();

		void OnCombatExit();

		void OnCombatRestart();

		Vector4 GetHeroEntryPR(int areaIdx, int zoneIdx);

		Vector3 GetNavPoint(int areaIdx, int zoneIdx);

		void Dispose();
	}
}
