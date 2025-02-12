namespace WaterBell.ProjX.Guide.Content
{
	public enum GuideCmd
	{
		FocusTrigger = 0,
		FocusTriggerAndShowTip = 1,
		ShowScreenMask0 = 2,
		ShowScreenMask1 = 3,
		MoveMainScene = 4,
		LockDragMainScene = 5,
		TryDisableUITriggerDragScrollView = 6,
		TryEnableUITriggerDragScrollView = 7,
		B_begin = 8,
		B_end = 9,
		B_speak = 10,
		B_changeBG = 11,
		B_insertPicBegin = 12,
		B_insertPicEnd = 13,
		C_begin = 14,
		C_end = 15,
		C_roleOut = 16,
		C_roleSpeak = 17,
		C_newRoleSpeakAtPos = 18,
		C_speakAside = 19,
		C_changeBG = 20,
		C_insertPicBegin = 21,
		C_changePic = 22,
		C_insertPicEnd = 23,
		D_begin = 24,
		D_end = 25,
		D_move = 26,
		D_speak = 27,
		D_insertPicBegin = 28,
		D_changePic = 29,
		D_insertPicEnd = 30,
		T_begin = 31,
		T_end = 32,
		T_changeBG = 33,
		T_showStep = 34,
		T_showLine = 35,
		T_hideLine = 36,
		T_hide = 37,
		FrontMaskFade = 38,
		EndLesson = 39,
		NextRound = 40,
		MarkLocalGuideFinish = 41,
		SetSkillIcon = 42,
		ShowBattleUI = 43,
		HideBattleUI = 44,
		ShowPauseBar = 45,
		HidePauseBar = 46,
		SetAutoNav = 47,
		WaitForBattle = 48,
		BattlePause = 49,
		BattleResume = 50,
		FillSlotEnergy = 51,
		EmptyWeaponSharp = 52,
		LockEnergy = 53,
		UnLockEnergy = 54,
		LockSharp = 55,
		UnLockSharp = 56,
		WaitForSec = 57,
		PlayBGM = 58,
		StopBGM = 59,
		PlaySndEff = 60,
		PushRecPointIfWin = 61,
		EndLessonAndStartNextLesson = 62,
		EndLessonAndFireGuideEvent = 63,
		EndLessonAndBeginGuideCombatBackGuide = 64,
		EndLessonAndBeginGuideCombatBackMain = 65,
		SwitchMainScene2SelectCards = 66
	}
}
