/*-----------------------------------------------------------------------------------------
 * CS 112 Exam - BUSE_Library_Management_System
 * Lending class
 * Registration number:B1645266 and B1645267
 * Team : Leo and Walter
 -----------------------------------------------------------------------------------------*/

using System;

namespace BUSE_Library_Management_System
{
    // The Lending class
	public class Lending
	{
        // Attributes
		protected readonly DateTime lendDate;
		protected readonly SourceOfInformation material;
		protected readonly User luser;
		protected readonly DateTime returnDate;
		protected bool returnedInGoodState;
		protected DateTime returnedDate;
		protected float fine;

        // Constreuctor
        public Lending( DateTime ld, 
                        User u, 
                        SourceOfInformation m, 
                        DateTime rd )
		{
            // Initializing the attibutes
            lendDate = ld;
            material = m;
            luser = u;
            returnDate = rd;
            returnedDate = rd;
            returnedInGoodState = false;
		}

        // Properties

		public User LUser
		{
			get
			{
                return luser;
			}
		}

		public SourceOfInformation LMaterial
		{
			get
			{
                return material;
			}
		}

		public float Fine
		{
			get
			{
                return fine;
			}
			set
			{
                fine = value;
			}
		}

		public DateTime ReturnDate
		{
			get
			{
                return returnDate;
			}
		}

		public DateTime LendDate
		{
			get
			{
                return lendDate;
			}
		}

		public bool ReturnedInGoodState
		{
			get
			{
                return returnedInGoodState;
			}
			set
			{
                returnedInGoodState = value;
			}
		}

		public DateTime ReturnedDate
		{
			get
			{
                return returnedDate;
			}
			set
			{
                returnedDate = value;
			}
		}
	}
}
