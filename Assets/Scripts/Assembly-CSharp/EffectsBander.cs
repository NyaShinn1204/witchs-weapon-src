using UnityEngine;

public class EffectsBander : MonoBehaviour
{
	public const int COUNT = 10;

	public const string EXTRA_EFF_PREV = "eff_";

	public const int ID_HEADTOP = -5;

	public const int ID_UPPER_FEET = -4;

	public const int ID_UPPER_CENTER = -3;

	public const int ID_FEET = -2;

	public const int ID_UPPERBODYCENTER = -1;

	public const int ID_HEAD = 0;

	public const int ID_LEFT_HAND = 1;

	public const int ID_RIGHT_HAND = 2;

	public const int ID_WEAPON = 3;

	public const int ID_SUB_WEAPON = 4;

	public const int ID_CHEST = 5;

	public const int ID_EFFECT_POINT = 6;

	public const string EFF_DRAW = "eff_draw";

	public const string EFF_DASH = "eff_dash";

	public const string EFF_ATTACK = "eff_attack";

	public const string EFF_SPAWN = "eff_spawn";

	public const string EFF_SKILL = "eff_skill";

	public const string EFF_DEAD = "eff_dead";

	public const string EFF_ATTACKED = "eff_attcked";

	public const string EFF_HIT = "eff_hit";

	public AudioClip[] sound_attack;

	public AudioClip[] sound_hit;

	public string effect_spawn;

	public string effect_attack;

	public string projectile;

	public string effect_hit;

	public string effect_heal_hit;

	public string effect_attacked;

	public string effect_dead;

	public string[] effect_always;

	public string[] extra_effets;

	public EffectBase[] extra_effets_content;

	public string effect_draw;

	public string effect_skill;

	public string effect_dash;

	public Transform[] BindPoints;

	[HideInInspector]
	public CharacterBase characterBase;

	public virtual void Awake()
	{
	}

	public virtual void InitEvents()
	{
	}

	public virtual void OnEffEvent(string eventName)
	{
	}

	private void BindMaster(EffectBase eff, Entity en)
	{
	}

	public virtual Transform GetBindPoint(int ID, out Vector3 pos)
	{
		pos = default(Vector3);
		return null;
	}

	private Transform findChild(Transform sTransform, string sName)
	{
		return null;
	}

	public virtual void NTR(EffectsBander lastBander)
	{
	}
}
