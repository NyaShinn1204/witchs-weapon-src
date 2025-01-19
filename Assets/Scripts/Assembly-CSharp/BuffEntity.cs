using UnityEngine;

public class BuffEntity : EffectMaster, IPausedComponent, ISharedObjectMaster
{
	public const string POINT_TYPE_ON_ADD_POINT = "OnAddPoint";

	public const string POINT_TYPE_ON_END_POINT = "OnEndPoint";

	public const string POINT_TYPE_ON_TICK_POINT = "OnTickPoint";

	public const string POINT_TYPE_ON_INTERRRUPT_POINT = "OnInterruptPoint";

	public const string POINT_TYPE_ON_EVENT_POINT = "OnEventPoint";

	public const string POINT_TYPE_ON_ADDLAYER_POINT = "OnAddLayerPoint";

	public const string POINT_TYPE_ON_SUBLAYER_POINT = "OnSubLayerPoint";

	public long UUID;

	public Entity source;

	public Entity entity;

	public Entity eventTarget;

	public BuffProperty property;

	public BuffEffect effect;

	public string prefabURI;

	private int _layerCount;

	public int layerCountMax;

	public float lifeTime;

	public float lifeTimeMax;

	public bool isPeriodicity;

	private float periodicityTime;

	private bool isPaused;

	public PauseType _PauseType;

	public BuffTPL buffTpl;

	public GEffectLine effectLine;

	private int hitCount;

	private int attackCount;

	private int damageCount;

	private int heroCommonAtkCount;

	private int layer;

	public NameSpace fileds;

	private bool tickPause;

	private float entityBlood;

	private float entityBloodLastFrame;

	private bool isDestroy;

	protected EventValueParam valueParam;

	public bool isNewBuff;

	public string currentReplaceShader;

	public GameObject shaderObj;

	public int startLifeFrame;

	public int targetLifeFrame;

	private int targetTriggerFrame;

	private bool isattached;

	public BuffSourcePropDTO rootSourceVO;

	public BuffDefined buffdefined;

	public int layerCount
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	public virtual void Start()
	{
	}

	private void initBlood()
	{
	}

	public void SubLayer(int count)
	{
	}

	public void SubLayerNoInterup(int count)
	{
	}

	public void OnInitialize(BuffProperty property, Entity entity, int layer, Entity source)
	{
	}

	public virtual void Update()
	{
	}

	private void checkHPChange()
	{
	}

	public virtual void OnStart()
	{
	}

	private void NotifyBehaviorTree(string evtName)
	{
	}

	public virtual void OnTrigger()
	{
	}

	public virtual void OnInterupt()
	{
	}

	protected virtual void _OnInterupt()
	{
	}

	public virtual void PauseTick()
	{
	}

	public virtual void OnEvent(BaseEvent evt)
	{
	}

	private void CheckInterupt(BaseEvent evt)
	{
	}

	private void CheckTickStart(BaseEvent evt)
	{
	}

	public virtual void OnEnd()
	{
	}

	public virtual void OnDestory()
	{
	}

	public virtual BuffEntity OverLying(long protoBuffID, int layerCount, Entity unit, Entity soruce, BuffSourcePropDTO rootSourceVO, BuffDefined buffdefined)
	{
		return null;
	}

	public virtual void ResetAndOverlay()
	{
	}

	protected virtual void AfterInit(int beforeLayerCount, int afterLayerCount)
	{
	}

	public BuffEntity Replace(long protoID, int layerCount, Entity source, BuffSourcePropDTO buffSourceVO, BuffDefined buffdefined)
	{
		return null;
	}

	public void TriggerSkill(long skillID)
	{
	}

	public void Pause()
	{
	}

	public void Resume()
	{
	}

	protected void SendBuffEvent(long buffId, int type)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
