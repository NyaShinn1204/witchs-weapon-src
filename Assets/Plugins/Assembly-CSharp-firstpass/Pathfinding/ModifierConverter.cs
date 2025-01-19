namespace Pathfinding
{
	public class ModifierConverter
	{
		public static bool AllBits(ModifierData a, ModifierData b)
		{
			return false;
		}

		public static bool AnyBits(ModifierData a, ModifierData b)
		{
			return false;
		}

		public static ModifierData Convert(Path p, ModifierData input, ModifierData output)
		{
			return default(ModifierData);
		}

		public static bool CanConvert(ModifierData input, ModifierData output)
		{
			return false;
		}

		public static ModifierData CanConvertTo(ModifierData a)
		{
			return default(ModifierData);
		}
	}
}
