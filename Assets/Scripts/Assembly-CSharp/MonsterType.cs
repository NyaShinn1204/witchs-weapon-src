public class MonsterType
{
	public const int SKILL_COUNT = 10;

	public const int BUFF_COUNT = 2;

	public const int TRIGGER_COUNT = 5;

	public long ID;

	public long[] skillIDs;

	public long[] buffIDs;

	public int[] buffLayer;

	public long[] triggerIDs;

	public long behaviorTreeId;

	public float first_attack_interval_lower;

	public float first_attack_interval_upper;

	public float attack_interval_lower;

	public float attack_interval_upper;
}
