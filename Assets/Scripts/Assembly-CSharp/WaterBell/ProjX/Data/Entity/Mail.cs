using System.Collections.Generic;
using System.Collections.ObjectModel;
using Mailmod;

namespace WaterBell.ProjX.Data.Entity
{
	public class Mail
	{
		public int CommonMailNum;

		public int SpecialMailNum;

		private P<int> _NewMailNum;

		private ObservableCollection<ObservableSingleMail> CommonMails;

		private ObservableCollection<ObservableSingleMail> SpecialMails;

		private P<bool> haveNewMail;

		public int NewMailNum
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public bool HaveNewMail
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public P<int> ObservarNewMailNum
		{
			get
			{
				return null;
			}
		}

		public P<bool> ObservarHaveNewMail
		{
			get
			{
				return null;
			}
		}

		public ObservableCollection<ObservableSingleMail> getCommonMails()
		{
			return null;
		}

		public ObservableCollection<ObservableSingleMail> getSpecialMails()
		{
			return null;
		}

		public void UpdateMail(List<MailDetail> MailContents, List<MailDetail> SpecialMailContents)
		{
		}

		private void UpdateCommonMail(List<MailDetail> MailContents)
		{
		}

		private void UpdateSpecialMail(List<MailDetail> SpecialMailContents)
		{
		}

		public void ReceiveAttachAndRemove(string id)
		{
		}

		public void RemoveNormal(string id)
		{
		}

		public void Dispose()
		{
		}
	}
}
