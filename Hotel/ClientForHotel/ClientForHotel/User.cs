using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientForHotel
{
	public class User
	{
		public string id { get; private set; }
		public string login { get; private set; }
		public string name { get; private set; }
		public string lName { get; private set; }
		public string mName { get; private set; }
		public string phone { get; set; }
		public string seria { get; private set; }
		public string number { get; private set; }
		public string eMail { get; set; }
		public User(string id_,string login_, string name_, string lName_, string mName_, string phone_, string seria_, string number_, string eMail_)
		{
			id = id_;
			login = login_;
			name = name_;
			lName = lName_;
			mName = mName_;
			phone = phone_;
			seria = seria_;
			number = number_;
			eMail = eMail_;
		}
	}
}
