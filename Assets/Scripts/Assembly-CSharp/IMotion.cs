public interface IMotion
{
	void StartMoveToTarget(AgentEntity entity, Entity target);

	void DoMotion();

	void ResetTarget(Entity target);
}
