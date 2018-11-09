/*-----------------------------------------------------------------------------------------
 * CS 112 Exam - BUSE_Library_Management_System
 * Book class
 * Registration number:B1645266 and B1645267
 * Team : Leo and Walter
 -----------------------------------------------------------------------------------------*/

 using System;

namespace BUSE_Library_Management_System
{
    // The Book class
	public class Book : SourceOfInformation
	{
        // Attributes
		protected string editorial;     // Editorial
		protected int year;             // Published in
		protected int pages;            // Number of pages
        protected string author;        // Author of the book

        // Constructor
		public Book(  string id, string title, 
                      Subjects subject, 
                      float acqPrice, int exemplars,
                      string mainAuthor,
                      string editorial, 
                      int year, int pages)
          : base(id,title,subject,acqPrice,exemplars) 
        {
            author = mainAuthor;
            this.editorial = editorial;
            this.year = year;
            this.pages = pages;
		}

        // The fine method...
        public override double Fine()
        {
            return 5; 
        }

        // Properties

		public string Editorial
		{
			get
			{
                return editorial;
			}
		}

		public int Year
		{
			get
			{
                return year;
			}
		}

		public int Pages
		{
			get
			{
                return pages;
			}
		}

        public string Author {
           get {
                return author;
           }
           set {
                author = value;
           }
        }

	}
}
