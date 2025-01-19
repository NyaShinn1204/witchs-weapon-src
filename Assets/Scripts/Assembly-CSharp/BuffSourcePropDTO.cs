public class BuffSourcePropDTO
{
	public PropertiesVO buffSourceVO;

	public int buffLevel;

	public int camp;

	public Entity source;

	public BuffSourcePropDTO(PropertiesVO vo)
	{
	}

	public static BuffSourcePropDTO CreateBuffSourceWrapper(PropertiesVO vo, int level, int camp, Entity source = null)
	{
		return null;
	}

	public override string ToString()
	{
		return null;
	}
}
