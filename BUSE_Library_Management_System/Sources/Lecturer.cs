/*-----------------------------------------------------------------------------------------
 * CS 112 Exam - BUSE_Library_Management_System
 * Lecturer class
 * Registration number:B1645266 and B1645267
 * Team : Leo and Walter
 -----------------------------------------------------------------------------------------*/

using System;

namespace BUSE_Library_Management_System
{
    // The Lecturer class
    public class Lecturer : User
	{
        // Attributes
		protected Departments department;


        // Constructor
        public Lecturer(  string name,
                          string email,
                          Gender gender,
                          string telephone,                      
                          DateTime dob,
                          string username,
                          Departments department )
            : base(name, email, gender, telephone, dob, username)
        {
            this.department = department;
        }

        // Properties
        public Departments Department
		{
			get
			{
                return department;
			}
			set
			{
                department = value; ;
			}
		}
	}
}
