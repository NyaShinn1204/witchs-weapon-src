using System.Collections.Generic;

namespace WaterBell.ProjX.Data.Entity
{
	public class ProgressDetail : Progress
	{
		public class SingleProgressDetail : SingleProgress
		{
			public class Item
			{
				private long _ID;

				private long itemClientID;

				private int itemType;

				public long ID
				{
					get
					{
						return 0L;
					}
				}

				public long ItemClientID
				{
					get
					{
						return 0L;
					}
				}

				public int ItemType
				{
					get
					{
						return 0;
					}
				}

				public Item()
				{
				}

				public Item(TypeCsvItem arguments)
				{
				}
			}

			public class ItemClient
			{
				private string itemIcon;

				private int itemQuality;

				public string ItemIcon
				{
					get
					{
						return null;
					}
				}

				public int ItemQuality
				{
					get
					{
						return 0;
					}
				}

				public ItemClient()
				{
				}

				public ItemClient(TypeCsvItemClient arguments)
				{
				}
			}

			public class Equip
			{
				private long _ID;

				private long clientID;

				private int[] attributeType;

				private int[] attributeValue;

				private long[] compoundEquip;

				private int favorability;

				public long ID
				{
					get
					{
						return 0L;
					}
				}

				public long ClientID
				{
					get
					{
						return 0L;
					}
				}

				public Equip()
				{
				}

				public Equip(TypeCsvServantEquip arguments)
				{
				}
			}

			public class EquipClient
			{
				private long name;

				private long description;

				private string icon;

				private int quality;

				private long equipGainInstance1;

				private long equipGainInstance2;

				private long equipGainInstance3;

				public long Name
				{
					get
					{
						return 0L;
					}
				}

				public long Description
				{
					get
					{
						return 0L;
					}
				}

				public string Icon
				{
					get
					{
						return null;
					}
				}

				public int Quality
				{
					get
					{
						return 0;
					}
				}

				public long EquipGainInstance1
				{
					get
					{
						return 0L;
					}
				}

				public long EquipGainInstance2
				{
					get
					{
						return 0L;
					}
				}

				public long EquipGainInstance3
				{
					get
					{
						return 0L;
					}
				}

				public EquipClient()
				{
				}

				public EquipClient(TypeCsvServantEquipClient arguments)
				{
				}
			}

			public class InstanceSet
			{
				private long instanceSetChineseName;

				private long instanceSetEnglishName;

				private int instanceSetType;

				private int instanceSetEnterLimit;

				private long firstInstance;

				private string instance_set_prefab;

				public long InstanceSetChineseName
				{
					get
					{
						return 0L;
					}
				}

				public long InstanceSetEnglishName
				{
					get
					{
						return 0L;
					}
				}

				public int InstanceSetEnterLimit
				{
					get
					{
						return 0;
					}
				}

				public long FirstInstance
				{
					get
					{
						return 0L;
					}
				}

				public int InstaceSetType
				{
					get
					{
						return 0;
					}
				}

				public string InstanceSetPrefab
				{
					get
					{
						return null;
					}
				}

				public InstanceSet()
				{
				}

				public InstanceSet(TypeCsvInstanceSet arguments)
				{
				}
			}

			public class Instance
			{
				private long _ID;

				private long instanceName;

				private long instanceDesc;

				private string instanceIcon;

				private int instanceType;

				private long instanceReward;

				private long instanceSpecialReward;

				private int instanceSpecialEnterLevel;

				private int instanceEnterLimit;

				private int instanceStaminaVictory;

				private int instanceStaminaEnter;

				private long instanceBuff1;

				private long instanceBuff2;

				private long instanceBuff3;

				private long instanceLootEquip1;

				private long instanceLootEquip2;

				private long instanceLootEquip3;

				private long instanceLootItem1;

				private long instanceLootItem2;

				private long instanceLootItem3;

				private long instanceLootItem4;

				private long instanceLootItem5;

				private long instanceLootItem6;

				public long ID
				{
					get
					{
						return 0L;
					}
				}

				public long InstanceName
				{
					get
					{
						return 0L;
					}
				}

				public long InstanceDesc
				{
					get
					{
						return 0L;
					}
				}

				public string InstanceIcon
				{
					get
					{
						return null;
					}
				}

				public int InstanceType
				{
					get
					{
						return 0;
					}
				}

				public int InstanceEnterLimit
				{
					get
					{
						return 0;
					}
				}

				public int InstanceStaminaVictory
				{
					get
					{
						return 0;
					}
				}

				public int InstanceStaminaEnter
				{
					get
					{
						return 0;
					}
				}

				public long InstanceLootEquip1
				{
					get
					{
						return 0L;
					}
				}

				public long InstanceLootEquip2
				{
					get
					{
						return 0L;
					}
				}

				public long InstanceLootEquip3
				{
					get
					{
						return 0L;
					}
				}

				public long InstanceLootItem1
				{
					get
					{
						return 0L;
					}
				}

				public long InstanceLootItem2
				{
					get
					{
						return 0L;
					}
				}

				public long InstanceLootItem3
				{
					get
					{
						return 0L;
					}
				}

				public long InstanceLootItem4
				{
					get
					{
						return 0L;
					}
				}

				public long InstanceLootItem5
				{
					get
					{
						return 0L;
					}
				}

				public long InstanceLootItem6
				{
					get
					{
						return 0L;
					}
				}

				public Instance()
				{
				}

				public Instance(TypeCsvInstance arguments)
				{
				}
			}

			public class InstanceExtension
			{
				public class EnemyInfo
				{
					public long enemyID;

					public string icon;

					public int enemyType;

					public string desc;

					public EnemyInfo()
					{
					}

					public EnemyInfo(long id, int type, string ic)
					{
					}
				}

				public List<EnemyInfo> enemiesInfo;

				public List<Item> itemsList;

				public List<ItemClient> itemClientsList;

				public List<Equip> equipsList;

				public List<EquipClient> equipClientsList;

				public InstanceExtension()
				{
				}

				public InstanceExtension(Instance ins)
				{
				}
			}

			private Chapter chapter;

			private InstanceSet instanceSet;

			private List<Level> levelsList;

			private List<Instance> instancesList;

			private List<InstanceExtension> instancesExtList;

			public SingleProgressDetail()
			{
			}

			public SingleProgressDetail(SingleProgress clone)
			{
			}

			public new Chapter GetChapter()
			{
				return null;
			}

			public InstanceSet GetInstanceSet()
			{
				return null;
			}

			public new int GetLength()
			{
				return 0;
			}

			public Level GetLevelByIndex(int i)
			{
				return null;
			}

			public Instance GetInstanceByIndex(int i)
			{
				return null;
			}

			public InstanceExtension GetInstanceExtensionByIndex(int i)
			{
				return null;
			}
		}

		private List<SingleProgressDetail> progressDetailList;

		public int GetLength()
		{
			return 0;
		}

		public SingleProgressDetail GetProgressDetailByIndex(int i)
		{
			return null;
		}
	}
}
