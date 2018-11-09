/*-----------------------------------------------------------------------------------------
 * CS 112 Exam - BUSE_Library_Management_System
 * User class
 * Registration number: 
 * Date: _____ / _____ / ______
 -----------------------------------------------------------------------------------------*/

using System;

namespace BUSE_Library_Management_System
{
    // The user class
    public class User
	{
		protected string name;          // User's name
		protected string email;         // User's email
		protected Gender gender;        // Gender
		protected string telephone;     // Phone
		protected DateTime DOB;         // Day of birth
		protected string username;      // user-name (login name)
		protected bool banned;          // true if the user is banned
		protected DateTime banedDate;   // Ban date

        // Constructor
		public User(  string name, 
                      string email, 
                      Gender gender, 
                      string telephone, 
                      DateTime dob, 
                      string username )
		{
            // Initializing the fields (attributes)
            this.name = name;
            this.email = email;
            this.gender = gender;
            this.telephone = telephone;
            this.DOB = dob;
            this.username = username;
            banned = false;
            banedDate = new DateTime();
		}

        // Properties
        public string Name
		{
			get
			{
                return name;
			}
		}

		public string EMailAdress
		{
			get
			{
                return email;
			}
			set
			{
                email = value;
			}
		}

		public Gender Gender
		{
			get
			{
                return gender;
			}
		}

		public string Telephone
		{
			get
			{
                return telephone;
			}
			set
			{
                telephone = value;
			}
		}

		public DateTime DateOfBirth
		{
			get
			{
                return DOB;
			}
		}

		public string UserName
		{
			get
			{
                return username;
			}
		}
	}
}
