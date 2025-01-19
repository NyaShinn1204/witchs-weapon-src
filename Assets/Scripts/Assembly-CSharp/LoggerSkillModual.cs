public class LoggerSkillModual : LoggerModual
{
	public const string FUNC_RUN = "=====>>  ";

	public const string NAME = " SKILL";

	public const string FUNC_NAME_SKILL_TAG_RANGE_SELECT = "RangeSelect";

	public const string FUNC_NAME_SKILL_TAG_TARGET_SELECT = "TargetSelect";

	public const string FUNC_NAME_SKILL_SEND_EVENT = "[Skill: SendSillEvent]";

	public const string FUNC_NAME_SKILL_ON_DETERMIN_POINT = "[Skill: OnDeterminPoint]";

	public const string FUNC_NAME_SKILL_ON_DETERMIN_POINT_CHECK_STATE = "[Skill: OnDeterminPoint_Check_State]";

	public const string FUNC_NAME_SKILL_ON_DETERMIN_POINT_CHECK_CD = "[Skill: OnDeterminPoint_Check_CD]";

	public const string FUNC_NAME_SKILL_ON_DETERMIN_POINT_NULL = "[Skill: OnDeterminPoint_Warn]";

	public const string FUNC_NAME_SKILL_ON_DETERMIN_POINT_CHECK = "[Skill: OnDeterminPoint_Check]";

	public const string FUNC_NAME_SKILL_ON_START_POINT = "[Skill: OnStartPoint]";

	public const string FUNC_NAME_SKILL_ON_START_POINT_NULL = "[Skill: OnStartPoint_Warn]";

	public const string FUNC_NAME_SKILL_ON_DP_TO_SP = "[Skill: CheckDPToSP]";

	public const string FUNC_NAME_SKILL_ON_RELEASE_POINT = "[Skill: OnReleasePoint]";

	public const string FUNC_NAME_SKILL_ON_RELEASE_POINT_NULL = "[Skill: OnReleasePoint_Warn]";

	public const string FUNC_NAME_SKILL_ON_EFFECT_POINT = "[Skill: OnEffectPoint]";

	public const string FUNC_NAME_SKILL_ON_EFFECT_POINT_ERROR = "[Skill: OnEffectPoint_Error]";

	public const string FUNC_NAME_SKILL_ON_PERFORMANCE_POINT = "[Skill: OnPerformancePoint]";

	public const string FUNC_NAME_SKILL_ON_INTERUPT_POINT = "[Skill: OnInteruptPoint]";

	public const string FUNC_NAME_SKILL_ON_END_POINT = "[Skill: OnEndPoint]";

	public const string FUNC_NAME_SKILL_SYS_ERROR = "[Skill: SYS_ERROR]";

	public const string FUNC_NAME_SKILL_SYS_PARAM_DISTANCE_ERROR = "[Skill: SYS_distance_ERROR]";

	public const string FUNC_NAME_SKILL_SYS_PARAM_DISTANCE = "[Skill: SYS_distance]";

	public const string FUNC_NAME_SKILL_RANGE_LIST = "<RangeList>";

	public const string FUNC_NAME_SKILL_EFFECT_LIST = "<EffectList>";

	public const string FUNC_NAME_SKILL_RANGE_SELECT = "<RangeSelect>";

	public const string FUNC_NAME_SKILL_TARGET_SELECT = "<TargetSelect>";

	public const string FUNC_NAME_SKILL_CREATE_DAMAGE_PACK = "<CreateDamagePack>";

	public const string FUNC_NAME_SKILL_CREATE_HEAL_PACK = "<CreateHealPack>";

	public const string FUNC_NAME_SKILL_CREATE_BUFF_PACK = "<CreateBuffPack>";

	public const string FUNC_NAME_SKILL_CREATE_DISPIEL_PACK = "<CreateDispelPack>";

	public const string FUNC_NAME_SKILL_CREATE_SHIFT_PACK = "<CreateShiftPack>";

	public const string FUNC_NAME_SKILL_CREATE_SHIFT_PACK_INTERRUPT = "<CreateShiftPack_Interrupt>";

	public const string FUNC_NAME_SKILL_CREATE_TAUNT_PACK = "<CreateTauntPack>";

	public const string FUNC_NAME_SKILL_CREATE_TAUNT_PACK_NO_TARGET = "<CreateTauntPack_No_target>";

	public const string FUNC_NAME_SKILL_CREATE_MOB = "<CreateMob>";

	public const string FUNC_NAME_SKILL_CREATE_AGENT = "<CreateAgent>";

	public const string FUNC_NAME_SKILL_ADJUST_PROCESS = "<AdjustProcess>";

	public const string FUNC_NAME_SKILL_APPOINT_POSITION = "<AppointPosition>";

	public const string FUNC_NAME_SKILL_APPOINT_ORIENTATION = "<AppointOrientation>";

	public const string FUNC_NAME_SKILL_RELEASE_TARGET_SELECT = "<ReleaseTargetSelect>";

	public const string FUNC_NAME_SKILL_DASH = "<Dash>";

	public const string FUNC_NAME_SKILL_CAN_DIE = "<CanDie>";

	public const string FUNC_NAME_SKILL_CAN_NOT_DIE = "<CanNotDie>";

	public const string FUNC_NAME_SKILL_GET_TARGET_ATTR = "<GetTargetAttr>";

	public const string FUNC_NAME_SKILL_SET_TARGET_ATTR = "<SetTargetAttr>";

	public const string FUNC_NAME_SKILL_GET_REALTIME_INFO = "<GetRealTimeInfo>";

	public const string FUNC_NAME_SKILL_SET_REALTIME_INFO = "<SetRealTimeInfo>";

	public const string FUNC_NAME_SKILL_GET_TARGET = "<GetTarget>";

	public const string FUNC_NAME_SKILL_GET_NEXT = "<GetNext>";

	public const string FUNC_NAME_SKILL_INTERRUPT_SPELL = "<InterruptSpell>";

	public const string FUNC_NAME_SKILL_LINK_STRING = "<LinkString>";

	public const string FUNC_NAME_SKILL_SHOCK = "<Shock>";

	public const string FUNC_NAME_SKILL_GET_BUFF_LAYER = "<GetBuffLayer>";

	public const string FUNC_NAME_SKILL_MODIFY_SHARPNESS = "<ModifySharpness>";

	public const string FUNC_NAME_SKILL_SENTENCE_TO_DEATH = "<SentenceToDeath>";

	public const string FUNC_NAME_SKILL_CAST_SPELL = "<CastSpell>";

	public const string FUNC_NAME_SKILL_MODIFY_CURRENT_TARGET = "<ModifyCurrentTarget>";

	public const string FUNC_NAME_SKILL_MODIFY_ENEGY = "<ModifyEnegy>";

	public const string FUNC_NAME_SKILL_ADDEFFECT = "<AddEffect>";

	public const string FUNC_NAME_SKILL_ADDEFFECT_ERROR = "<AddEffect_Error>";

	public const string FUNC_NAME_SKILL_ACTIVEEFFECT = "<ActiveEffect>";

	public const string FUNC_NAME_SKILL_ACTIVEEFFECT_ERROR = "<ActiveEffect_error>";

	public const string FUNC_NAME_SKILL_REMOVEEFFECT = "<RemoveEffect>";

	public const string FUNC_NAME_SKILL_PLAYACTION = "<PlayAction>";

	public const string FUNC_NAME_SKILL_PLAYSOUND = "<PlaySound>";

	public const string FUNC_NAME_SKILL_BINDTOBONE = "<BindToBone>";

	public const string FUNC_NAME_SKILL_BINDTOBONE_ERROR = "<BindToBone_ERROR>";

	public const string FUNC_NAME_SKILL_UNBINDFROMBONE = "<UnBindFromBone>";

	public const string FUNC_NAME_SKILL_UNBINDFROMBONE_ERROR = "<UnBindFromBone_ERROR>";

	public const string FUNC_NAME_SKILL_MODIFYMASS = "<ModifyMass>";

	public const string FUNC_NAME_SKILL_PLAYSPECIALANIMATION = "<PlaySpecialAnimation>";

	public const string FUNC_NAME_SKILL_GET_CONTROL_STATE = "<GetTargetControlState>";

	public const string FUNC_NAME_SKILL_GET_OTHER_STATE = "<GetTargetOtherState>";

	public const string FUNC_NAME_SKILL_CREATE_AGENT_CURRENT_TARGET_NULL = "<CreateAgent:current_target_null";

	public const string FUNC_NAME_SKILL_CREATE_AGENT_ERR_NO_ID = "<CreateAgent:error_no_id";

	public const string FUNC_NAME_SKILL_CREATE_AGENT_ERR_NO_VO = "<CreateAgent:error_no_agentvo";

	public const string FUNC_NAME_SKILL_CREATE_AGENT_POSITION_OFFSET = "<CreateAgent_Position_Offset>";

	public const string FUNC_NAME_SKILL_CREATE_AGENT_POSITION = "<CreateAgent_Position>";

	public const string FUNC_NAME_SKILL_CREATE_AGENT_POSITION_COMMON = "<CreateAgent_Position_Common>";

	public const string FUNC_NAME_SKILL_CREATE_AGENT_ROTATION = "<CreateAgent_Rotation>";

	public const string FUNC_NAME_SKILL_CREATE_CONDITION = "<Condition>";

	public LoggerSkillModual(string name, int outputType)
	{
	}

	public override string RunFunction(int loglevel, string funcName, object self, params object[] obj)
	{
		return null;
	}

	private string LinkPhase(object self, params object[] obj)
	{
		return null;
	}

	private string SysParamError(object self, params object[] obj)
	{
		return null;
	}

	private string GetRealtimeInfo(object self, params object[] obj)
	{
		return null;
	}

	private string SetRealtimeInfo(object self, params object[] obj)
	{
		return null;
	}

	private string GetTargetAttr(object self, params object[] obj)
	{
		return null;
	}

	private string SetTargetAttr(object self, params object[] obj)
	{
		return null;
	}

	private string GetTarget(object self, params object[] obj)
	{
		return null;
	}

	private string GetBuff(object self, params object[] obj)
	{
		return null;
	}

	private string SysParam(object self, params object[] obj)
	{
		return null;
	}

	private string ActiveEffectError(object self, params object[] obj)
	{
		return null;
	}

	private string AddEffectError(object self, params object[] obj)
	{
		return null;
	}

	private string CreateAgentNoID(object self, params object[] obj)
	{
		return null;
	}

	private string CreateAgentNoVO(object self, params object[] obj)
	{
		return null;
	}

	private string SendEventLog(object self)
	{
		return null;
	}

	private string OnDeterminPoint(object self, params object[] obj)
	{
		return null;
	}

	private string OnDeterminPointNull(object self, params object[] obj)
	{
		return null;
	}

	private string OnDeterminPointCheck(object self, params object[] obj)
	{
		return null;
	}

	private string OnDeterminPointCheckState(object self, params object[] obj)
	{
		return null;
	}

	private string OnDeterminPointCheckCD(object self, params object[] obj)
	{
		return null;
	}

	private string OnStartPointNull(object self, params object[] obj)
	{
		return null;
	}

	private string OnReleasePointNull(object self, params object[] obj)
	{
		return null;
	}

	private string OnStartPoint(object self)
	{
		return null;
	}

	private string OnReleasePoint(object self)
	{
		return null;
	}

	private string OnEffectPoint(object self)
	{
		return null;
	}

	private string OnEffectPointError(object self, params object[] obj)
	{
		return null;
	}

	private string OnPerformancePoint(object self)
	{
		return null;
	}

	private string OnInteruptPoint(object self)
	{
		return null;
	}

	private string OnEndPoint(object self)
	{
		return null;
	}

	private string OnCheckPoint(object self, params object[] obj)
	{
		return null;
	}

	private string OnSysError(object self, params object[] obj)
	{
		return null;
	}

	private string CreateDamagePack(object self, params object[] obj)
	{
		return null;
	}

	private string CreateHealPack(object self, params object[] obj)
	{
		return null;
	}

	private string CreateBuffPack(object self, params object[] obj)
	{
		return null;
	}

	private string CreateDispeilPack(object self, params object[] obj)
	{
		return null;
	}

	private string CreateShiftPack(object self, params object[] obj)
	{
		return null;
	}

	private string CreateAgent(object self, params object[] obj)
	{
		return null;
	}

	private string CreateAgentPosition(object self, params object[] obj)
	{
		return null;
	}

	private string CreateAgentPositionOffset(object self, params object[] obj)
	{
		return null;
	}

	private string CreateAgentPositionCommon(object self, params object[] obj)
	{
		return null;
	}

	private string CreateAgentRotation(object self, params object[] obj)
	{
		return null;
	}

	private string RangeSelect(object self, params object[] obj)
	{
		return null;
	}

	private string TargetSelect(object self, params object[] obj)
	{
		return null;
	}
}
