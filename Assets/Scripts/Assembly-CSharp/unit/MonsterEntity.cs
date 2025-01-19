using NodeCanvas.BehaviourTrees;
using WaterBell.ProjX.Guide.Event;
using WaterBell.ProjX.Level;

namespace unit
{
	public class MonsterEntity : Entity
	{
		private static int _signID;

		private static float _defaultHeight;

		public MonsterActionMngr actMngr;

		public MonsterVO monsterVO;

		public float warningRange;

		public MonsterBornInfo bornInfo;

		public float lifeTime;

		public AIExt aiTree;

		public bool isMonserPause;

		public BehaviourTree bTree;

		public bool isrelife__;

		private static int signID
		{
			get
			{
				return 0;
			}
		}

		public override int entityPowerRank
		{
			get
			{
				return 0;
			}
		}

		public override MonsterEntityHPUIType entityTypeHPUI
		{
			get
			{
				return default(MonsterEntityHPUIType);
			}
		}

		public override bool isNative
		{
			get
			{
				return false;
			}
		}

		public static void ResetMobSignID()
		{
		}

		public override void Awake()
		{
		}

		private void CombatFinishHandler(CombatFinishEvent finishEvt)
		{
		}

		private void CombatBeginHandler(CombatBeginEvent finishEvt)
		{
		}

		private void checkTags()
		{
		}

		public void InitAIParam()
		{
		}

		public override void Start()
		{
		}

		private void InitSelectTarget()
		{
		}

		private void SendInitSelectTarget()
		{
		}

		private Entity checkSelectCurrentTargetFirst()
		{
			return null;
		}

		private void checkSelectCurrentTarget(bool sCheckDis = true)
		{
		}

		public override void InitTriggers()
		{
		}

		protected override void CallSpawn()
		{
		}

		protected override void CallSpawnEnd()
		{
		}

		private void StatBlood()
		{
		}

		private void StatCount()
		{
		}

		public override void AddSpawnBuffs()
		{
		}

		private BuffSourcePropDTO createBuffDTO()
		{
			return null;
		}

		protected override void AddSpawnEvent()
		{
		}

		protected override void BindActionMngr()
		{
		}

		public override PropertiesVO GetProperty()
		{
			return null;
		}

		protected override void UpdateTargetSelection()
		{
		}

		public void OnFightOver()
		{
		}

		public override long GetID()
		{
			return 0L;
		}

		public override void ExecDashAttack()
		{
		}

		public override int GetLevel()
		{
			return 0;
		}

		public override int GetSkillReleaseLevel()
		{
			return 0;
		}

		public override Entity GetFollowTarget()
		{
			return null;
		}

		public override bool ExecDeath()
		{
			return false;
		}

		private void StatInfo()
		{
		}

		public void ReturnAITree()
		{
		}
	}
}
