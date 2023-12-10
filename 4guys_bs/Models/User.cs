using System;
namespace _4guys_bs.Models
{
	public class User
	{
		public string usn { get; set; }
		public string pwd { get; set; }
		public string mail { get; set; }

        public User(string usn, string pwd, string mail)
        {
            this.usn = usn;
            this.pwd = pwd;
            this.mail = mail;
        }
    }
}

