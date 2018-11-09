/*-----------------------------------------------------------------------------------------
 * CS 112 Exam - BUSE_Library_Management_System
 * Student class
 * Registration number: 
 * Date: _____ / _____ / ______
 -----------------------------------------------------------------------------------------*/

using System;

namespace BUSE_Library_Management_System
{
    // The Student class
	public class Student : User
	{
        // Attributes 
		protected string program; 
		protected ProgramParts currentPart;

        // Constructor...
        public Student(string name,
                      string email,
                      Gender gender,
                      string telephone,
                      DateTime dob,
                      string username,
                      string program, 
                      ProgramParts currentPart ) 
            : base ( name,email,gender,telephone,dob,username )
        {
            this.program = program;
            this.currentPart = currentPart;
        }

        // Properties
		public string Program
		{
			get
			{
				return program;
			}
		}

		public ProgramParts CurrentPart
		{
			get
			{
                return currentPart;
			}
			set
			{
                currentPart = value;
            }
		}
	}
}
