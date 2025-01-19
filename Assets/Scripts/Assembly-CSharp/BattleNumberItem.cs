using System.Collections.Generic;
using UnityEngine;

public class BattleNumberItem : MonoBehaviour, IPausedComponent
{
	private enum DisplayTypes
	{
		None = 0,
		Num = 2,
		Symbols = 4,
		Chars = 8,
		Icon = 16,
		All = -1
	}

	private enum AnimTypes
	{
		None = 0,
		General = 1,
		Text = 2,
		Critical = 3,
		HeroHurt = 4
	}

	private const float SPACE_SCALE = 0.19f;

	private const string MISS = "Num_Text_Miss";

	private const string DODGE = "Num_Text_Dodge";

	private const string IMMUNE = "Num_Text_Immune";

	private const string ASSIMILATE = "Num_Text_Assimilate";

	private const string THORNS = "Num_Icon_Beat_Back_Injured";

	private const string INVALID_HEAL = "Num_Text_Forbidden_Therapy";

	private const string HEMOPHAGIA = "Num_Icon_Suck_Blood";

	private const string RESIST = "Num_Text_Resist";

	private const string COMA = "Num_Text_Coma";

	private const string SILENCE = "Num_Text_Silence";

	private const string IMMOBILIZE = "Num_Text_Immobilize";

	private const string LIFE_LINK = "Num_Text_Life_Link";

	private const string INJURED_NUM_ATTACT_SUBTRACT = "Injured_Num_Attact_Subtract";

	private const string INJURED_NUM_HEAL_ADD = "Cure_Num_Heal_Add";

	private const string INJURED_NUM_HOLY_SUBTRACT = "Injured_Num_Holy_Subtract";

	private const string INJURED_NUM_MAGIE_SUBTRACT = "Injured_Num_Magie_Subtract";

	private const string TOP_NUM_ICON_CIRTICAL = "Num_Icon_Critical";

	private const string DAMAGE_NUM_ATTACT = "Damage_Num_Attact_";

	private const string DAMAGE_NUM_HOLY = "Damage_Num_Holy_";

	private const string DAMAGE_NUM_MAGIE = "Damage_Num_Magie_";

	private const string INJURED_NUM_ATTACT = "Injured_Num_Attact_";

	private const string INJURED_NUM_HEAL = "Cure_Num_Heal_";

	private const string INJURED_NUM_HOLY = "Injured_Num_Holy_";

	private const string INJURED_NUM_MAGIE = "Injured_Num_Magie_";

	private static readonly Dictionary<string, string> charsDict;

	private static readonly List<string> symbolsList;

	private static readonly List<string> iconList;

	public Vector3 speed;

	public Vector3 offset;

	public bool useGravity;

	public UISprite cloneSource;

	public int depth;

	public UISprite topIcon;

	public long numValue;

	private string numPrefix;

	private UITable m_Table;

	[SerializeField]
	private List<UISprite> poolList;

	private Animator m_Anim;

	[SerializeField]
	private DamageInfo m_DamageInfo;

	private AnimTypes animType;

	private DisplayTypes displayType;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void FixedUpdate()
	{
	}

	private void OnDestroy()
	{
	}

	public void Init(DamageInfo damageInfo)
	{
	}

	private int Comparison(Transform a, Transform b)
	{
		return 0;
	}

	private void UpdateImage()
	{
	}

	private string CreateStyleStr(string head, long num, string numPrefix, string end)
	{
		return null;
	}

	private static string StyleStrWrap(object obj)
	{
		return null;
	}

	private void SetAnimation()
	{
	}

	private UISprite GetItem()
	{
		return null;
	}

	public void Hide()
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}
}
