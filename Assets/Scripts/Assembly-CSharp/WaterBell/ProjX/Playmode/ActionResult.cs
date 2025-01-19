namespace WaterBell.ProjX.Playmode
{
	public enum ActionResult
	{
		succ = 0,
		succButNeedMoreCheck = 1,
		playmodeStateCondFail = 2,
		notSweepLevel = 3,
		notCleraInstance = 4,
		staminaCondFail = 5,
		enterLimitEqualZero = 6,
		enterLimitCountNotEnough = 7,
		heroHpEquals0 = 8,
		battleCountFail = 9,
		EliteResetCountFail = 10,
		notAllowSweep = 11,
		notSatisfyCondition = 12,
		notMultiSweepEliteInstanceFail = 13,
		starCondFail = 14,
		svSelectCondFail = 15,
		wpSelectCondFail = 16,
		undefinedException = 17,
		actvitiyRule3BossStageNeedToWin = 18,
		actvitiyRule1NoLeveLPass = 19,
		actvitiyRule4NoProfit = 20,
		actvitiyRule4FloorCannotOverMaxFloor = 21,
		ApAccelerateSweep2Tickets = 22,
		ApAccelerateSweep1Tickets = 23,
		ApAccelerateSNoTickets = 24
	}
}
