using Google.Protobuf.Collections;
using Lootmod;
using WaterBell.ProjX.Data.Entity;

public class Response
{
	public byte[] bytes;

	public int length;

	public string url;

	public string tag;

	public object data;

	public Lootmod.LootResult lootResult;

	public RepeatedField<LootObject> repeatedField;

	public LootList loots;

	public override string ToString()
	{
		return null;
	}
}
