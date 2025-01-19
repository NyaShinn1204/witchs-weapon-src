using System.Collections.Generic;

namespace WaterBell.ProjX.Data.Entity
{
	public class InstanceManager
	{
		private static readonly InstanceManager instance;

		private ProgressDetail globalProgressDetail;

		private PackageDetail globalPackageDetail;

		private AchievementDetail globalAchievementDetail;

		private UserPlayerManagerController globalUPlaMC;

		private UserServantManagerViewModel globalUSMVM;

		private UserProgressManagerViewModel globalUProMVM;

		private UserPackageManagerViewModel globalUPacMVM;

		private UserPlayerManagerViewModel globalUPlaMVM;

		private PurchaseSystemManagerViewModel globalPurchaseVM;

		private DrawSystemManagerViewModel globalDrawVM;

		private MailSystemManagerViewModel globalMailMVM;

		private UserAchievementManagerViewModel globalAchieveMVM;

		private ExpeditionManagerViewModel globalExpeditionVM;

		private ServantListManagerViewModel globalSvListVM;

		private List<long> selectedServantsForNormal;

		static InstanceManager()
		{
		}

		private InstanceManager()
		{
		}

		public static InstanceManager GetInstance()
		{
			return null;
		}

		public int SetProgressDetail(ProgressDetail origin)
		{
			return 0;
		}

		public ProgressDetail GetProgressDetail()
		{
			return null;
		}

		public int SetPackageDetail(PackageDetail origin)
		{
			return 0;
		}

		public PackageDetail GetPackageDetail()
		{
			return null;
		}

		public AchievementDetail GetAchievementDetail()
		{
			return null;
		}

		public int SetAchievementDetail(AchievementDetail origin)
		{
			return 0;
		}

		public int SetUSMVM(UserServantManagerViewModel origin)
		{
			return 0;
		}

		public int SetUProMVM(UserProgressManagerViewModel origin)
		{
			return 0;
		}

		public int SetMailMVM(MailSystemManagerViewModel origin)
		{
			return 0;
		}

		public int SetUPacMVM(UserPackageManagerViewModel origin)
		{
			return 0;
		}

		public int SetUPlaMVM(UserPlayerManagerViewModel origin)
		{
			return 0;
		}

		public int SetAchieveMVM(UserAchievementManagerViewModel origin)
		{
			return 0;
		}

		public int SetPurchaseVM(PurchaseSystemManagerViewModel origin)
		{
			return 0;
		}

		public int SetDrawVM(DrawSystemManagerViewModel origin)
		{
			return 0;
		}

		public int SetExpeditionVM(ExpeditionManagerViewModel origin)
		{
			return 0;
		}

		private void init(AchievementDetail temp, UserAchievementManagerViewModel userAchievementManager)
		{
		}

		public UserServantManagerViewModel GetUSMVM()
		{
			return null;
		}

		public UserProgressManagerViewModel GetUProMVM()
		{
			return null;
		}

		public UserPackageManagerViewModel GetUPacMVM()
		{
			return null;
		}

		public UserPlayerManagerViewModel GetUPlaMVM()
		{
			return null;
		}

		public PurchaseSystemManagerViewModel GetPurchaseMVM()
		{
			return null;
		}

		public DrawSystemManagerViewModel GetDrawMVM()
		{
			return null;
		}

		public ExpeditionManagerViewModel GetExpeditionMVM()
		{
			return null;
		}

		public UserAchievementManagerViewModel GetAchieveMVM()
		{
			return null;
		}

		public MailSystemManagerViewModel GetMailMVM()
		{
			return null;
		}

		public List<long> GetSelectedServantsForNormal()
		{
			return null;
		}

		public void SetSelectedServantsForNormal(List<long> ids)
		{
		}

		public int SetSvListVM(ServantListManagerViewModel origin)
		{
			return 0;
		}

		public ServantListManagerViewModel GetSvListVM()
		{
			return null;
		}
	}
}
