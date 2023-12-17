using System;
namespace _4guys_bs.Models
{
	public class User
	{
        // internal object Account;
        public string Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Usn { get; set; }
		public string Psw { get; set; }
        public string RePsw {get; set;}
		public string Mail { get; set; }

        public User(string FirstName, string LastName, string Usn, string Psw, string RePsw, string Mail)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Usn = Usn;
            this.Psw = Psw;
            this.RePsw = RePsw;
            this.Mail = Mail;
        }
    }
}

