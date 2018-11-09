/*-----------------------------------------------------------------------------------------
 * CS 112 Exam - BUSE_Library_Management_System
 * ScientificJournal class
 * Registration number:B1645266 and B1645267
 * Team : Leo and Walter
 -----------------------------------------------------------------------------------------*/

using System;

namespace BUSE_Library_Management_System
{
    // The ScientificJournal class
    public class ScientificJournal
                    : SourceOfInformation
    {
        // Attributes
		protected int volume;
		protected int issue;

        // Constructor 
		public ScientificJournal( string id, string title,
                                  Subjects subject,
                                  float acqPrice, int exemplars,
                                  int volume, int issue )
           : base(id, title, subject, acqPrice, exemplars)
        {
            this.volume = volume;
            this.issue = issue;
		}

        //
        public override double Fine()
        {
            return 3;
        }

        // Properties
		public int Volume
		{
			get
			{
                return volume;
			}
		}

		public int Issue
		{
			get
			{
                return issue;
			}
		}

	}
}
