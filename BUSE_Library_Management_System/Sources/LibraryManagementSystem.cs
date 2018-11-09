/*-----------------------------------------------------------------------------------------
 * CS 112 Exam - BUSE_Library_Management_System
 * LibraryManagementSystem class
 * Registration number:B1645266 and B1645267
 * Team : Leo and Walter
 -----------------------------------------------------------------------------------------*/

using System;

namespace BUSE_Library_Management_System
{
    //  The BUSE LMS Main class
	public class LibraryManagementSystem
	{
        // Attributes
		private SourceOfInformation[] materials;    // Library items
		private User[] users;                       // Library users
        private Lending[] lending_act;              // Active lending
		private Lending[] lending_returned;         // Closed lending
        private uint c_user,                        // User counter
                     c_materials,                   // Materials counter
                     c_lending_act,                 // Active lending counter
                     c_lending_returned;            // Returned lending counter

        // Constructor 
        public LibraryManagementSystem()
		{
            // Arrays creation
            materials = new SourceOfInformation[1000];
            users = new User[500];
            lending_act = new Lending[100];
            lending_returned = new Lending[100];
            // Counter initialization
            c_user = c_materials = c_lending_act = c_lending_returned = 0;
        }

        // Adding a new user
		public void AddNewUser(User u)
		{
            // If we have space in the users array
            if (c_user < users.Length)
            {
                // Add the new user
                users[c_user++] = u;
            }
            else
                // Tell the user that we found an error...
                throw new Exception("The user list is full.");
		}

        // To add a new source
		public void AddNewSourceOfInformation(SourceOfInformation soi)
		{
            //  TO DO
            throw new NotImplementedException();
		}

        // To lend a source
		public bool LendASource(User u, SourceOfInformation s, DateTime d)
		{
            //  TO DO
			return false;
		}

        // To return a lending
		public Lending ReturnASource(User u, SourceOfInformation s, DateTime d)
		{
            // TO DO
			throw new NotImplementedException();
		}

        // To determine the books to be returned after a date
		public Book[] BooksToBeReturnedAfter(DateTime d)
		{
            // TO DO
			throw new NotImplementedException();
		}
        
	}
}
