/*-----------------------------------------------------------------------------------------
 * CS 112 Exam - BUSE_Library_Management_System
 * MainWindow class
 * Registration number: 
 * Date: _____ / _____ / ______
 -----------------------------------------------------------------------------------------*/

using System.Windows.Forms;

namespace BUSE_Library_Management_System
{
    public partial class MainWindow : Form
    {
        // My attributes 
        private LibraryManagementSystem lms;

        // Constructor
        public MainWindow()
        {
            // Do not touch...
            InitializeComponent();
            // Creating the things
            lms = new LibraryManagementSystem();
        }

        private void aboutToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("BUSE Libary Management System. \n CS 112 Final Exam",
                              "BUSE LMS",
                              MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            const string message = "Are you sure that you would like to close the application ?";
            const string caption = "Application Closing";
            var result = MessageBox.Show(message, caption,
                                          MessageBoxButtons.YesNo,
                                          MessageBoxIcon.Question);
            // If the "yes" button was pressed ... exit the application
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
