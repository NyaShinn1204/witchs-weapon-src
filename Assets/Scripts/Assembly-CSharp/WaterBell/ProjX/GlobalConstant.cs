using System;
using System.Collections.Generic;
using UnityEngine;

namespace WaterBell.ProjX
{
	public class GlobalConstant
	{
		public const int CLIENT_VERSION_NORMAL = 0;

		public const int CLIENT_VERSION_YIJIE = 1;

		public const int CLIENT_VERSION_EFUN = 2;

		public const int CLIENT_VERSION_LEITING = 3;

		public const int CLIENT_VERSION_DMM_PC = 4;

		public const string LEBIAN_UPDATE_RESULT_NOT_READY = "-2";

		public const string LEBIAN_UPDATE_RESULT_REQUEST_ERROR = "-1";

		public const string LEBIAN_UPDATE_RESULT_UNKOWN = "1";

		public const string LEBIAN_UPDATE_RESULT_NO_UPDATE = "2";

		public const string LEBIAN_UPDATE_RESULT_UPDATE_NOT_FORCE = "3";

		public const string LEBIAN_UPDATE_RESULT_UPDATE_FORCE = "4";

		public const int SHOP_NUM_NO_LIMIT = -1;

		public const int SHOP_TOTAL_NUM_NO_LIMIT = -1;

		public const string LOG_FILE_PATH = "D:\\ZZZ\\";

		public const int USER_LEVEL_NOT_ENOUGH_ADD_WEAPON_LEVEL = 6;

		public const int USER_TYPE_GUEST = 0;

		public const int USER_TYPE_PHONE = 1;

		public const int USER_TYPE_MAIL = 2;

		public const string PLATFORM_TYPE_IOS = "1";

		public const string PLATFORM_TYPE_ANDROID = "2";

		public const string ZONE_PLATFORM_STRATEGY_ALL = "0";

		public const string ZONE_PLATFORM_STRATEGY_ONLY_IOS = "1";

		public const string ZONE_PLATFORM_STRATEGY_ONLY_ANDROID = "2";

		public const string ZONE_PLATFORM_STRATEGY_EXCLUSIVE = "10";

		public const int SMS_LENGH_MIN = 4;

		public const int PASS_LENGH_MIN = 6;

		public const int PASS_LENGH_MAX = 16;

		public const int EMAIL_LENGH_MIN = 6;

		public const int EMAIL_LENGH_MAX = 50;

		public const int EMAIL_NAME_SHOW_LENGH_MAX = 24;

		public const int EMAIL_NAME_POPLIST_SHOW_LENGH_MAX = 16;

		public const int EMAIL_NAME_DEFAULT_SHOW_LENGH_MAX = 16;

		public const int frameRate = 60;

		public const string VISUAL_SERVER_SCRIPT = "VisualServer";

		public const string DYNAMIC_SKILL_SCRIPT = "DynamicSkillScript";

		public const string MAIN_SCENE_NAME = "ceshi";

		public const string URL_LOGIN = "http://10.0.0.3:8080/public/crolelogin";

		public const string URL_SYNC_ACCOUNT = "http://10.0.0.3:8080/public/getuserbasic";

		public const string URL_SYNC_SERVANT = "http://10.0.0.3:8080/public/getservants";

		public const string FILE_NAME_EFFECTSBANDER = "effectsBander.xml";

		public const string FILE_NAME_EFFECTS = "effects.xml";

		public const string FILE_NAME_SKILL = "Spells.xml";

		public const string FILE_NAME_BUFF = "Buffs.xml";

		public const string FILE_NAME_NET_ROUTER = "netrouter.xml";

		public const string URL_BUFF_BASE = "";

		public const string BATTLE_NUMBER_PANEL = "UI/Prefab/Battle/NumberPanel/NumberPanel";

		public const string BATTLE_CENTER_TIP_PANEL = "UI/Prefab/Fighting/LabelTipsPanel";

		public const int FARAWAY_X = -10000;

		public const int FARAWAY_Z = -10000;

		public const int HIRE_MODE_EXPEDITION = 0;

		public const int HIRE_MODE_AP = 1;

		public const int BUFF_ADD_GOLD = 1;

		public const int BUFF_ADD_GUILD_CURRENCY = 2;

		public const int BUFF_ADD_EXPEDITION_CURRENCY = 3;

		public const int BUFF_ADD_HP = 4;

		public const int BUFF_ADD_ATK = 5;

		public const int BUFF_ADD_DEF = 6;

		public static List<Color> FrameColor;

		public static List<Color> ShadingColor;

		public static List<Color> ImgColor;

		public const string LOADING_SCENE_NAME = "Loading";

		public const string LOADINGBACK_SCENE_NAME = "LoadingBackFromBattle";

		public const string LOADING_OBJ_NAME = "Loading";

		public const string LOADING_CAMERA_NAME = "Camera";

		public const string LOG_SKILL = "SKILL:";

		public const string PREFAB_CHARACTERS_BASE_URL = "prefab/3d/characters/";

		public const string PREFAB_DBLOCK_BASE_URL = "prefab/3d/dynBlock/";

		public const string PREFAB_TRIGGERS_BASE_URL = "prefab/3d/triggers/";

		public const string PREFAB_DITEM_BASE_URL = "prefab/3d/dynItems/";

		public const string PREFAB_SERVENT_NAME_PRE = "5_m_";

		public const string PREFAB_SERVENT_NAME_TAIL = "-b";

		public const string SKILL_SCRIPT_NAME = "DynamicSkillScript.";

		public const string MESSAGE_TYPE_GAME_ANIMATION_START = "game_animation_start";

		public const string MESSAGE_TYPE_GAME_ANIMATION_END = "game_animation_end";

		public const string MESSAGE_TYPE_BUFF_START = "buff_buffStart";

		public const string MESSAGE_TYPE_BUFF_END = "buff_lifeEnd";

		public const string MESSAGE_TYPE_BUFF_INTERRUPT = "buff_interrupt";

		public const string MESSAGE_TYPE_BUFF_TRIGGER = "buff_trigger";

		public const string TAG_DETERMIN_POINT = "determin_point";

		public const string TAG_START_POINT = "start_point";

		public const string TAG_START_LOCK_POINT = "start_lock_point";

		public const string TAG_END_LOCK_POINT = "resume";

		public const string TAG_RELEASE_POINT = "eff_0";

		public const string TAG_EFFECT_POINT = "effect_point";

		public const string TAG_NO_MOVE_START_POINT = "no_move_start_point";

		public const string TAG_NO_MOVE_END_POINT = "action_end";

		public const string HTTP_TAG_LOGIN = "LOGIN";

		public const string HTTP_TAG_SYNC = "SYNC";

		public const string HTTP_TAG_ROLE = "ROLE";

		public const string HTTP_TAG_GET_SERVANTS = "GET_SERVANTS";

		public const string NAME_SPACE = "DynamicSkillScript.New";

		public const string STANDARD_EFF_URL = "prefab/3d/characters/effects/1_e_skill";

		public const string STANDARD_RELEASE_SND_URL = "prefab/parts/battle/soundEff/ReleaseSkill";

		public const string GAMEOBJECT_TAG_BEAR = "bear";

		public const int LEVEL_ICON_ALREADY_UNLOCK = 0;

		public const int LEVEL_ICON_NEW_UNLOCK = 1;

		public const int LEVEL_ICON_LOCK = 2;

		public const string URL_BASE = "http://10.0.0.3:8080/";

		public const int DRAW_TYPE_GOLD_SINGLE = 1;

		public const int DRAW_TYPE_GOLD_TEN = 2;

		public const int DRAW_TYPE_RMB_SINGLE = 3;

		public const int DRAW_TYPE_RMB_TEN = 4;

		public const int DRAW_TYPE_GOLD_FREE = 5;

		public const int DRAW_TYPE_RMB_FREE = 6;

		public const int DRAW_TYPE_GUIDE_FREE = 7;

		public const int DRAW_TYPE_ACTIVITY_SINGLE = 8;

		public const int DRAW_TYPE_ACTIVITY_TEN = 9;

		public const int DRAW_TYPE_AP_SINGLE = 10;

		public const int DRAW_TYPE_AP_TEN = 11;

		public const int DRAW_DEFAULT_DIAMOND_TITLE = 12;

		public const int DRAW_TYPE_GOLD_FREE_TEN = 13;

		public const int DRAW_TYPE_PERSON_SINGLE = 14;

		public const int DRAW_TYPE_PERSON_TEN = 15;

		public const int ACTIVITY_TYPE_SPECIAL_DRAW = 6;

		public const int DRAW_ACT_DRAW_TYPE_AP = 1;

		public const int DRAW_ACT_DRAW_TYPE_GOLD = 2;

		public const int DRAW_ACT_DRAW_TYPE_DIMOND = 3;

		public const int DRAW_ACT_DRAW_TYPE_NEW = 4;

		public const int DRAW_ACT_DRAW_TYPE_GOLD_TEN_DRAW = 23;

		public const int ACTIVITY_TYPE_PERSONAL_DRAW = 27;

		public const int INSTANCE_SET_TYPE_MAIN = 1;

		public const int INSTANCE_SET_TYPE_DAILY = 2;

		public const int INSTANCE_SET_TYPE_TEST = 0;

		public const int INSTANCE_SET_TYPE_ACTIVITY_INSTANCE_SET = 7;

		public const int INSTANCE_TYPE_EXPEDITION = 1;

		public const int INSTANCE_TYPE_MAIN = 2;

		public const int INSTANCE_TYPE_ELITE = 3;

		public const int INSTANCE_TYPE_OTHER = 0;

		public const int INSTANCE_TYPE_CHALLENGE = 4;

		public const int INSTANCE_TYPE_DAILY_1 = 5;

		public const int INSTANCE_TYPE_DAILY_2 = 6;

		public const int INSTANCE_TYPE_TEST = 9;

		public const int INSTANCE_TYPE_ACTIVITY_PLAY_3_HARD = 10;

		public const int INSTANCE_TYPE_ACTIVITY_PLAY_3_EASY = 11;

		public const int INSTANCE_TYPE_ACTIVITY_PLAY_1 = 12;

		public const int INSTANCE_TYPE_ACTIVITY_PLAY_2 = 13;

		public const int INSTANCE_TYPE_ACTIVITY_PLAY_4 = 16;

		public const int INSTANCE_TYPE_ACTIVITY_PLAY_5_COMMON = 17;

		public const int INSTANCE_TYPE_ACTIVITY_PLAY_5_SPECIAL = 18;

		public const int INSTANCE_TYPE_WEAPON = 14;

		public const int INSTANCE_TYPE_ACTIVITY_ACCELERATE = 15;

		public const int INSTANCE_TYPE_ACTIVITY_PROGRESS_LINE = 21;

		public const int ACHIEVE_REWARD_ITEM_TYPE_SERVANTDEBRIS = 1;

		public const int ACHIEVE_REWARD_ITEM_TYPE_EQUIPDEBRIS = 2;

		public const int ACHIEVE_REWARD_ITEM_TYPE_CONSUMABLE = 3;

		public const int ACHIEVE_REWARD_TYPE_EQUIP = 2;

		public const int ACHIEVE_REWARD_TYPE_ITEM = 3;

		public const int ACHIEVE_REWARD_TYPE_EXP = 10;

		public const int ACHIEVE_REWARD_TYPE_STAMINA = 12;

		public const int ACHIEVE_REWARD_TYPE_GOLD = 13;

		public const int ACHIEVE_REWARD_TYPE_CSC = 14;

		public const int ACHIEVE_REWARD_TYPE_RED = 15;

		public const int ACHIEVE_REWARD_TYPE_YELLOW = 16;

		public const int ACHIEVE_REWARD_TYPE_BLUE = 17;

		public const int ACHIEVE_REWARD_TYPE_GRENN = 18;

		public const int ACHIEVE_REWARD_TYPE_ASSOCIATION = 19;

		public const int ACHIEVE_REWARD_TYPE_VIP_EXP = 20;

		public const int ACHIEVE_REWARD_TYPE_VIP_SCORE = 21;

		public const int ACHIEVE_REWARD_TYPE_ACTIVITY_STAMINA = 22;

		public const int ACHIEVE_REWARD_TYPE_STORY = 25;

		public const int ACHIEVE_REWARD_TYPE_ACTIVITY_STORY = 26;

		public const int ACHIEVE_REWARD_TYPE_ACTIVITY_REPUTATION = 70;

		public const int ACHIEVE_REWARD_TYPE_DIAMOND = 99;

		public const int ACHIEVE_TYPE_ROLE_LV = 1;

		public const int ACHIEVE_TYPE_SV_NUM = 10;

		public const int ACHIEVE_TYPE_SV_LV = 11;

		public const int ACHIEVE_TYPE_SV_RANK = 12;

		public const int ACHIEVE_TYPE_SV_STAR_RANK = 13;

		public const int ACHIEVE_TYPE_FAVOURITE = 14;

		public const int ACHIEVE_TYPE_SV_DELTA_LV = 15;

		public const int ACHIEVE_TYPE_SV_DELTA_START_POINT = 16;

		public const int ACHIEVE_TYPE_SV_DELTA_SPELL_LV = 17;

		public const int ACHIEVE_TYPE_SV_DELTA_WEAPON_LV = 18;

		public const int ACHIEVE_TYPE_SV_ADD_EQUIP = 19;

		public const int ACHIEVE_TYPE_FINISH_INSTANCE_SET = 20;

		public const int ACHIEVE_TYPE_FINISH_INSTANCE = 21;

		public const int ACHIEVE_TYPE_FINISH_INSTANCE_LIMIT_TYPE = 22;

		public const int ACHIEVE_TYPE_EXPEDITION = 23;

		public const int ACHIEVE_TYPE_GOLD_DRAW_SERVANT = 30;

		public const int ACHIEVE_TYPE_GOLD_DRAW = 31;

		public const int ACHIEVE_TYPE_GOLD_DRAW_TEN_TIMES = 32;

		public const int ACHIEVE_TYPE_RMB_DRAW_SERVANT = 33;

		public const int ACHIEVE_TYPE_RMB_DRAW = 34;

		public const int ACHIEVE_TYPE_RMB_DRAW_TEN_TIMES = 35;

		public const int ACHIEVE_TYPE_SHOPING_TYPE = 40;

		public const int ACHIEVE_TYPE_BUY_GOLD_TYPE = 41;

		public const int ACHIEVE_TYPE_BUY_STANIMA_TYPE = 42;

		public const int ACHIEVE_TYPE_GET_ITEM = 50;

		public const int ACHIEVE_TYPE_GET_EQUIP = 51;

		public const int ACHIEVE_TYPE_KILL = 60;

		public const int ACHIEVE_TYPE_ATTACK_DAMAGE = 61;

		public const int ACHIEVE_TYPE_BE_ATTACKED_DAMAGE = 62;

		public const int ACHIEVE_TYPE_TOTAL_HEAL = 63;

		public const int ACHIEVE_TYPE_SAVE_NPC = 64;

		public const int ACHIEVEMENT_OPEN_NOT_FINISH = -1;

		public const int ACHIEVEMENT_FINISH_REWARD_NOT_RECEIVE = 0;

		public const int ACHIEVEMENT_FINISH_REWARD_HAVE_RECEIVE = 1;

		public const int ACHIEVEMENT_IS_DAILY = 1;

		public const int ACHIEVEMENT_IS_NOT_DAILY = 0;

		public const int ACHIEVEMENT_INSTANCE_FINISH_TYPE = 21;

		public const int COMPOSE_TYPE_FRAG = 1;

		public const int COMPOSE_TYPE_EQUIP = 2;

		public const int ITEM_TYPE = 3;

		public const string FIGHT_BGM_SOUND_PREFIX = "Sounds/MainFight/Fight";

		public const string MAINUI_BGM_SOUND = "Sounds/MainUI/mainBgm";

		public const string COMMON_CLICK_SOUNDEFF = "Sounds/MainUI/commonClick";

		public const string COMMON_RETURN_SOUNDEFF = "Sounds/MainUI/commonReturn";

		public static Dictionary<Type, UIPanelBaseCfg> UI_SPRITE_CFG;

		public const int SELL_ITEM = 0;

		public const int SELL_EQUIP = 1;

		public const int HP = 1;

		public const int PATK = 2;

		public const int MATK = 3;

		public const int PDEF = 4;

		public const int MDEF = 5;

		public const int BATTLE_ATTRIBUTE_TYPE_MAX = 103;

		public const int BASE_ATTRIBUTE_TYPE_MAX = 13;

		public const int MAIN_ATTRIBUTE_TYPE_MAX = 5;

		public const int ITEM_TYPE_SERVANT_DEBRIS = 1;

		public const int ITEM_TYPE_EQUIP_DEBRIS = 2;

		public const int ITEM_TYPE_CONSUMABLE = 3;

		public const int ITEM_TYPE_WEAPON_DEBRIS = 4;

		public const int ITEM_TYPE_CURRENCY = 5;

		public const int ITEM_TYPE_GOOD = 6;

		public const int ITEM_TYPE_DISPLAY = 9;

		public const int ITEM_SUB_TYPE_SERVANT_WEAPON_EXP = 1;

		public const int ITEM_SUB_TYPE_SERVANT_EXP = 2;

		public const int ITEM_SUB_TYPE_STAMINA = 3;

		public const int ITEM_SUB_TYPE_GOLD = 4;

		public const int ITEM_SUB_TYPE_CHEST = 5;

		public const int ITEM_ACTIVITY_BUFF = 6;

		public const int ITEM_ACTIVITY_CURRENCY = 7;

		public const int ITEM_SUB_TYPE_CHEST2 = 8;

		public const int ITEM_SUB_TYPE_SP_SERVANT_WEAPON_EXP = 9;

		public const int ITEM_SUB_TYPE_SV_FASHION_CHEST = 13;

		public const int ITEM_SUB_TYPE_ITEM_CHEST = 14;

		public const int ITEM_SUB_TYPE_CHOOSE_ITEM_CHEST = 15;

		public const int ITEM_SUB_TYPE_TICKET = 16;

		public const int ITEM_SUB_TYPE_SP_STAMINA = 10;

		public const int ITEM_SUB_TYPE_CHEST3 = 11;

		public const int ITEM_SUB_TYPE_DENTIFY_ITEM = 12;

		public const string TEXT_EQUIP = "-原";

		public const string TEXT_EQUIP_DEBRIS = "-原\ufffd";

		public const string TEXT_ITEM = "-消\ufffd";

		public const string TEXT_SERVANT_DEBRIS = "-魔\ufffd";

		public const string TEXT_DIAMOND = "-货";

		public const string TEXT_GOLD = "-货";

		public const string TEXT_WEAPON = "-刻\ufffd";

		public const string TEXT_GOOD = "\ufffd";

		public const string TEXT_CHEST = "\ufffd";

		public const string TEXT_ACTIVITY_BUFF = "\ufffd";

		public const string TEXT_ACTIVITY_CURRENCY = "\ufffd";

		public const string TEXT_EXP = "\ufffd";

		public const int QUEST_STATUS_NOT_FINISH = -1;

		public const int QUEST_STATUS_FINISH_NOT_RECEIVE = 0;

		public const int QUEST_STATUS_RECEIVE = 1;

		public const int QUEST_VALID = 1;

		public const int QUEST_VALID_NOT = 0;

		public const int QUEST_TYPE_HIDE = 0;

		public const int QUEST_TYPE_ACHIEVEMENT = 1;

		public const int QUEST_TYPE_DAILY = 2;

		public const int QUEST_TYPE_SIDE = 3;

		public const int QUEST_TYPE_RANDOM = 4;

		public const int QUEST_TYPE_GUIDE = 5;

		public const int QUEST_TYPE_MAIN_STORY = 6;

		public const int QUEST_TYPE_ACTIVITY = 7;

		public const int QUEST_TYPE_FAVOR = 8;

		public const int QUEST_TYPE_ACTIVITY_DAILY = 9;

		public const int AP_RULE_1 = 1;

		public const int AP_RULE_2 = 2;

		public const int AP_RULE_3 = 3;

		public const int AP_RULE_4 = 4;

		public const int AP_RULE_5 = 5;

		public const int AP_R_5_ROUND_LOWER_COMMON = 1;

		public const int AP_R_5_ROUND_LOWER_FINAL = 2;

		public const int AP_R_5_ROUND_UPPER_COMMON = 3;

		public const int AP_R_5_ROUND_UPPER_FINAL = 4;

		public const int AP_R_5_ROUND_DIFFICULT_LOWER = 1;

		public const int AP_R_5_ROUND_DIFFICULT_UPPER = 2;

		public const string AP_MobEnhance_hp = "hp";

		public const string AP_MobEnhance_attack = "attack";

		public const string AP_MobEnhance_PHYDEF = "phydef";

		public const string AP_MobEnhance_MAGICPDF = "magicdef";

		public const int AP_ACCELERATE_TICKET_MULTIPLE_USE = 2;

		public const int STORY_TYPE_MAINLINE = 1;

		public const int STORY_TYPE_SUBLINE = 2;

		public const int STORY_TYPE_ACTIVITY = 3;

		public const int STORY_TYPE_TUITION = 4;

		public const int SERVANT_PROMOTE_LEVEL_MAX = 2;

		public const int WEAPON_TYPE_TWO = 1;

		public const int WEAPON_TYPE_DUAL = 2;

		public const int WEAPON_TYPE_SINGLE = 3;

		public const int SHOP_PRICE_TYPE_GOLD = 1;

		public const int SHOP_PRICE_TYPE_EXPEDITION = 2;

		public const int SHOP_PRICE_TYPE_RED = 3;

		public const int SHOP_PRICE_TYPE_YELLOW = 4;

		public const int SHOP_PRICE_TYPE_BLUE = 5;

		public const int SHOP_PRICE_TYPE_GREEN = 6;

		public const int SHOP_PRICE_TYPE_GUILD = 7;

		public const int SHOP_PRICE_TYPE_VIP = 8;

		public const int SHOP_PRICE_TYPE_DRAW = 9;

		public const int SHOP_PRICE_TYPE_RECYCLE = 10;

		public const int SHOP_PRICE_TYPE_DIAMOND = 50;

		public const int SHOP_PRICE_TYPE_REAL_DIAMOND = 51;

		public const int SHOP_PRICE_TYPE_ITEM = 90;

		public const int SHOP_PRICE_TYPE_RMB = 99;

		public const int SHOP_RMB_BUY_SUCCESS_AND_ADD_PLUS = 131415926;

		public const int PAY_TYPE_WEIXIN = 1;

		public const int PAY_TYPE_ALI = 2;

		public const int PAY_TYPE_EFUN = 4;

		public const int ChannelID_ALIPAY = 101;

		public const int ChannelID_WEIXIN = 102;

		public const int EXPEDITION_FORM_INDXE = 1;

		public const int EXPEDITION_TO_INDEX = 16;

		public const int RECEIVE_STAMINA_1_BEGIN = 8;

		public const int RECEIVE_STAMINA_1_END = 11;

		public const int RECEIVE_STAMINA_2_BEGIN = 12;

		public const int RECEIVE_STAMINA_2_END = 15;

		public const int RECEIVE_STAMINA_3_BEGIN = 18;

		public const int RECEIVE_STAMINA_3_END = 21;

		public const int WEAPON_RARE_N = 1;

		public const int WEAPON_RARE_R = 2;

		public const int WEAPON_RARE_SR = 3;

		public const int WEAPON_RARE_SSR = 4;

		public const int WEAPON_RARE_UR = 5;

		public const int SIGN_ACTIVITY_START_COUNT = 0;

		public const int SIGN_ACTIVITY_END_COUNT = 14;

		public const int SIGN_TIME_TIME_PERIOD = 86400;

		public const int SERVANT_COMBATSCORE_NEED_SV_NUM = 30;

		public const int SERVANT_PROMOTE_SPELL_SKIN_INDEX = 2;

		public const int SERVANT_DEFAULT_WEAPON_PROMOTE_LV = 0;

		public const int SERVANT_DEFAULT_WEAPON_PROMOTE_SPELL_LV = 1;

		public const int SIGN_FINISHDAY = 14;

		public const int SHOP_NEVERSHOW = -1;

		public const int QUEST_JUMP_TYPE_TO_MAIN_SCENE = 100;

		public const int QUEST_JUMP_TYPE_TO_MAIN_STORY = 101;

		public const int QUEST_JUMP_TYPE_TO_SERVANT_LIST = 202;

		public const int QUEST_JUMP_TYPE_TO_EXPEDITION_SCENE = 301;

		public const int QUEST_JUMP_TYPE_TO_DAILY_SCENE = 401;

		public const int QUEST_JUMP_TYPE_TO_GUILD_SCENE = 501;

		public const int QUEST_JUMP_TYPE_TO_DRAW_SCENE = 601;

		public const int QUEST_JUMP_TYPE_TO_SHOP_SCENE = 701;

		public const int QUEST_JUMP_TYPE_TO_WEAPONDAILY_SCENE = 801;

		public const int VIP_2_RECEIVE_LEVEL = 2;

		public const int VIP_GOLD_DRAW_LEVEL = 1;

		public const int VIP_RMB_DRAW_LEVEL = 3;

		public const int VIP_5_RECEIVE_LEVEL = 5;

		public const int PAY_RESULT_ALI_SUCCESS = 9000;

		public const int PAY_RESULT_ALI_SUCCESS_AND_WAIT = 8000;

		public const int PAY_RESULT_WEIXIN_SUCCESS = 0;

		public const int PAY_RESULT_WEIXIN_SUCCESS_TRANS = 8888;

		public const int PAY_RESULT_YIJIE_SUCCESS = 1000;

		public const int PAY_RESULT_YIJIE_FAIL = 1001;

		public const long DRAW_PROBABILITY_GOLD = 10400L;

		public const long DRAW_PROBABILITY_DIAMONDS = 10401L;

		public const long DRAW_PROBABILITY_ACTIVITY = 10402L;

		public const long DRAW_PROBABILITY_ACTIVITY_UP = 10403L;

		public const string _FASHION = "com.shuiqinling.fashion_";

		public const string _SERVANT = "com.shuiqinling.servant_";

		public const string _SERVANT_IMAGE = "com.shuiqinling.servantImage_";

		public const string _AP_MULTY_TIME = "com.shuiqinling.ap3MultyTime_";

		public const int DEFAUT_AP_MULTY_TIME = 1;

		public const long FASHION_EXCHANGE_CERTIFICATE = 40350013L;

		public const long WEAPON_MATERIAL_TIPS_1 = 12000L;

		public const long WEAPON_MATERIAL_TIPS_2 = 12001L;

		public const long WEAPON_MATERIAL_TIPS_3 = 12002L;

		public const int WEAPON_MATERAIL_CHOOSE_TIME_MAX = 4;

		public const int RANK_LIST_TYPE_AP_CURRENCY = 1;

		public const int RANK_LIST_TYPE_AP_BATTLE_SCORE = 2;

		public const int RANK_ACTIVITY_GAME_SERIAL_EXPEDITION = 20000;

		public const int DAILY_MONEYGAME = 1;

		public static int CLIENT_VERSION
		{
			get
			{
				return 0;
			}
		}

		public static string PACKAGE_NAME_FOR_ANDROID
		{
			get
			{
				return null;
			}
		}

		public static string DeviceIdentifier
		{
			get
			{
				return null;
			}
		}
	}
}
