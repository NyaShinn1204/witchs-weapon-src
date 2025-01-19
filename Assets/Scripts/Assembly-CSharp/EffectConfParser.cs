using System.Xml;

public class EffectConfParser
{
	private const string CONST_KEY_FRAME = "keyframe";

	private const string CONST_TRIGGER = "trigger";

	private const string CONST_REF = "ref";

	private const string KEYFRAME_ATTACK = "eff_attack";

	private const string KEYFRAME_SPAWN = "eff_spawn";

	private const string KEYFRAME_SKILL = "eff_skill";

	private const string KEYFRAME_DASH = "eff_dash";

	private const string KEYFRAME_DEAD = "eff_dead";

	private const string TRIGGER_HIT = "eff_hit";

	private const string TRIGGER_HEAL_HIT = "eff_heal_hit";

	private const string TRIGGER_ATTACKED = "eff_attacked";

	private const string TRIGGER_PROJECTILE = "eff_projectile";

	private static XmlDocument doc;

	private static XmlReaderSettings set;

	private static XmlDocument bander_doc;

	private static XmlReaderSettings bander_set;

	private static bool isLoadedEffect;

	private static bool isLoadedBander;

	private static string xmlDataPath;

	private static string eff_root;

	private static string prop_url;

	private static string prop_bind;

	private static string prop_bindPoint;

	public static void Init()
	{
	}

	private static void LoadEffectsBanderFile()
	{
	}

	private static void LoadEffectsFile()
	{
	}

	public static void FullFillProperties(string url, EffectBase eb)
	{
	}

	public static void FullFillEffectsBanderProperties(string prefabName, Entity unit)
	{
	}

	public static void PreLoad(string prefab)
	{
	}

	private static void SetKeyFrameURL(XmlElement xl2, EffectsBander bander)
	{
	}

	private static int ExtractIndexOfExtraEffect(string extraEffName)
	{
		return 0;
	}

	private static void SetTriggerURL(XmlElement xl2, EffectsBander bander)
	{
	}
}
