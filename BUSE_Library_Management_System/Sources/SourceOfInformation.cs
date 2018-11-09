/*-----------------------------------------------------------------------------------------
 * CS 112 Exam - BUSE_Library_Management_System
 * SourceOfInformation class
 * Registration number: 
 * Date: _____ / _____ / ______
 -----------------------------------------------------------------------------------------*/

namespace BUSE_Library_Management_System
{
    // The SourceOfInformation class
    public abstract class SourceOfInformation
	{
        // Attributes
		protected string id;            // Source's id
		protected float acqPrice;       // Acquisition price
		protected string title;         // Title
		protected Subjects subject;     // Main  subject
        protected uint copies;          // The number of copies..
        private int exemplars;

        public SourceOfInformation( string id, 
                                    string title, 
                                    Subjects subject,
                                    float acqPrice,
                                    uint copies ) {
            this.id = id;
            this.title = title;
            this.acqPrice = acqPrice;
            this.subject = subject;
            this.copies = copies;
         }

        public SourceOfInformation(string id, string title, Subjects subject, float acqPrice, int exemplars)
        {
            this.id = id;
            this.title = title;
            this.subject = subject;
            this.acqPrice = acqPrice;
            this.exemplars = exemplars;
        }

        // Properties

        public uint NumberOfCopies {
            get {
                return copies;
            }
        }

		public string Identifier
		{
			get
			{
                return id;
			}
		}

		public string Title
		{
			get
			{
                return title;
			}
		}

		public float AcquisitionPrice
		{
			get
			{
				return acqPrice;
			}
			set
			{
                acqPrice = value;
			}
		}

		public Subjects Subject
		{
			get
			{
                return subject;
			}
		}

        // The method to return the fine...
        public abstract float Fine();

        public void ReturnOne() {
            copies++;
        }
	}
}
