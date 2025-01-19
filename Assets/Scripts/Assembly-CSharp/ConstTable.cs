using System.Collections.Generic;
using Combatmod;

public class ConstTable
{
	public static bool isCreated;

	public static List<Camp> campList;

	public static float DSPHR;

	public static float TWO_HANDED_WEAPON_MODULUS;

	public static float DUAL_WIELD_WEAPON_MODULUS;

	public static float SINGLE_HANDED_WEAPON_MODULUS;

	public static List<float> MEHMArr;

	public static Dictionary<int, float> HRLMDic;

	public static Dictionary<int, float> SPHRLMDic;

	public static Dictionary<int, float> CRLMDic;

	public static Dictionary<int, int> HLMDic;

	public static Dictionary<int, int> DLMDic;

	public static Dictionary<int, int> IPDLMDic;

	public static Dictionary<int, int> IMDLMDic;

	public static Dictionary<int, int> PCLMDic;

	public static Dictionary<int, int> MCLMDic;

	public static Dictionary<int, int> PCMLMDic;

	public static Dictionary<int, int> MCMLMDic;

	public static Dictionary<int, float> PDMDic;

	public static Dictionary<int, float> PDEFMDic;

	public static Dictionary<int, float> MDMDic;

	public static Dictionary<int, float> MDEFMDic;

	public static Dictionary<int, float> HMDic;

	public static Dictionary<int, long> COMSPELL;

	public static int TARGET_SELECT_POWER_TAUNT;

	public static int TARGET_SELECT_POWER_PRIORITY;

	public static int TARGET_SELECT_POWER_DAMAGE;

	public static int TARGET_SELECT_POWER_NEAREST;

	public static float HRLM(int levelDiff)
	{
		return 0f;
	}

	public static float SPHRLM(int levelDiff)
	{
		return 0f;
	}

	public static float CRLM(int levelDiff)
	{
		return 0f;
	}

	public static int HLM(int level)
	{
		return 0;
	}

	public static int DLM(int level)
	{
		return 0;
	}

	public static int IPDLM(int level)
	{
		return 0;
	}

	public static int IMDLM(int level)
	{
		return 0;
	}

	public static int PCLM(int level)
	{
		return 0;
	}

	public static int MCLM(int level)
	{
		return 0;
	}

	public static int PCMLM(int level)
	{
		return 0;
	}

	public static int MCMLM(int level)
	{
		return 0;
	}
}
