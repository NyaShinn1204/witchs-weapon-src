using System.Collections.Generic;

public class AgentVO
{
	public long ID;

	public int be_selected;

	public int can_move;

	public int can_turn;

	public string prefab;

	public string turnBone;

	public long buff_id1;

	public long buff_id2;

	public int buff_level1;

	public int buff_level2;

	public bool shadow;

	public int spawn_type;

	public int spawn_argu1;

	public int spawn_argu2;

	public int spawn_argu3;

	public int spawn_argu4;

	public int movement_type;

	public int max_palstance;

	public int track_type;

	public int speed;

	public float life_time;

	public int max_distance;

	public int destroy_by_hit_num;

	public int destroy_by_hit_time;

	public int target_type;

	public int target_argu1;

	public int target_argu2;

	public int target_argu3;

	public int target_argu4;

	public long target_argu5;

	public int destroy_by_block;

	public string script_id;

	public int position_type;

	public int center_type;

	public float radius;

	public int max_angle;

	public int right_angle;

	public int orientation_type;

	public int orientation_angle;

	public int combat_const_type;

	public long spellCastSpawnID;

	public long spellCastHitID;

	public long spellCastDeadID;

	public PropertiesVO property;

	public bool isFollowMaster;

	public float followDistance;

	public float destroyByHitTime;

	public float hit_distance;

	public int ajustType;

	public float colliderRadius;

	public string spawnAction;

	public string deadAction;

	public int spawn_direction;

	public int spawn_angle;

	public bool isCanChangeCurrentTarget;

	public List<long> summonBuffList;

	public List<int> summonBuffListLayer;

	public string motionId;

	public void SetFollow(bool followMaster, float distance)
	{
	}
}
