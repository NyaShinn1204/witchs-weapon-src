public class BufferPack : BasePack
{
	public long[] ids;

	public int[] layers;

	public Entity source;

	public Entity target;

	public BuffSourcePropDTO buffSourceVO;

	public BuffDefined buffdefined;

	public BufferPack(long[] ids, int[] layers, int level, Entity source, BuffSourcePropDTO vo, Entity target, BuffDefined buffdefined)
	{
	}

	public override string ToString()
	{
		return null;
	}
}
