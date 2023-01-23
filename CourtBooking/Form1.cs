using CourtBooking.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourtBooking
{
    public partial class Form1 : Form
    {
        public string last_Book; // Last book inserted

        public Form1()
        {
            string directory = "C:\\Courtbooking\\";

            InitializeComponent();

            // Charge Users. Read line by line from file C:\\Courtbooking\Courts.txt
            Charge_Users(directory + "Users.txt"); // Charge the Users Combo with the file users
            comboBox_Users_Passwords.Visible = false; // This is a combo for internal manage of password to validate checking password

            // Charge Courts. Read line by line from file C:\\Courtbooking\Courts.txt
            Charge_Courts(directory + "Courts.txt"); // Charge the Courts Combo with the file courts

            // Charge Conditions. Conditions for the use of sports facilities and Paddle Courts. Read line by line from file C:\\Courtbooking\Conditions.txt
            Charge_Conditions(directory + "Conditions.txt"); // Charge and print on console the condition for the use of sports facilities and Paddle Courts

            // Charge Books. Clean list of books and charge the books from file C:\\Courtbooking\CourtBooksPaddle_(1/2).txt
            Charge_Books_List("C:\\CourtBooking", "Paddle_1"); // Clean on console the list of books wirh Paddle_1 option
            listBox_Book_Temp.Visible = false; // This is a list for internal manage of booking to not repeat book 

            comboBox_Users.Focus();

        }

        // Form Load. Disable operation options (Book, UnBook)
        private void Form1_Load(object sender, EventArgs e)
        {
            button_Book.Enabled = false;
            button_UnBook.Enabled = false;
        }

        // Charge Users. Read line by line from file C:\\Courtbooking\Courts.txt  
        private void Charge_Users(string path)
        {
            int index = 0;
            string neighbor = "";
            string password = "";

            foreach (string line in System.IO.File.ReadLines(path))
            {
                neighbor = line.Remove(12); // Display only the neighbor user excludin password
                password = line.Substring(line.Length - 4, 4); // Get the neighbor password
                comboBox_Users_Passwords.Items.Add(line); // Get the complete line // MessageBox.Show(line);
                comboBox_Users.Items.Add(neighbor); // Fill the neighbor user // MessageBox.Show(neighbor);
                index++;
            }
        }

        // Charge Courts. Read line by line from file C:\\Courtbooking\Courts.txt  
        private void Charge_Courts(string path)
        {
            int index = 0;

            foreach (string line in System.IO.File.ReadLines(path))
            {
                comboBox_Courts.Items.Add(line); // Fill the court
                index++;
            }
        }

        // Charge Conditions. Conditions for the use of sports facilities and Paddle Courts. Read line by line from file C:\\Courtbooking\Conditions.txt
        private void Charge_Conditions(string path)
        {
            int index = 0;

            foreach (string line in System.IO.File.ReadLines(path))
            {
                textBox_Conditions.Text = textBox_Conditions.Text + line + "\r\n";
                index++;
            }

        }

        // Charge Books. Clean list of books and charge the books from file C:\\Courtbooking\CourtBooksPaddle_(1/2).txt
        private void Charge_Books_List(string directory, string court)
        {
            comboBox_Courts.Text = court;

            if (!File.Exists(directory + "\\CourtBooks" + court + ".txt"))
            {
                last_Book = comboBox_Courts.Text + "                      " + "08/10/2023" + "                              " + "08:00" + "                          " + "09:00" + "                           " + "Libertad_14";
                listBox_Books.Items.Clear();
                listBox_Books.Items.Add(last_Book);
                listBox_Book_Temp.Items.Add(last_Book);
            }

            listBox_Books.Items.Clear();
            readBooks(directory, comboBox_Courts.Text); // Read the books from current file
        }

        // User and password. Access to the application functionality previous identification with user and password
        private void button_Access_Click(object sender, EventArgs e)
        {
            string user_Neighbor;
            string pass_Neighnor;
            string pass_Introduced;

            user_Neighbor = comboBox_Users.Text.Replace(" ", ""); // MessageBox.Show(user_Neighbor);
           
            if (user_Neighbor.Length == 11)
            {
                pass_Neighnor = comboBox_Users_Passwords.Text.Substring(comboBox_Users_Passwords.Text.Length - 4, 4); // Password from file
                pass_Introduced = textBox_Password.Text; // Password introduced by console

                if (pass_Neighnor == pass_Introduced) // User will book or unbook courts
                {
                    button_Book.Enabled = true;
                    button_UnBook.Enabled = true;
                    label_Access.Text = "PLEASE SELECT DATE AND TIME_INITIAL FOR YOUR BOOKING";
                    label_Access.BackColor = Color.GhostWhite;
                    textBox_Password.Text = "****";
                    dateTimePicker_Date.Focus();
                }
                else // User won't book any court
                {
                    button_Book.Enabled = false;
                    button_UnBook.Enabled = false;
                    textBox_Password.Text = "";
                    MessageBox.Show("Acces NOK. Please try again with another password");
                    label_Access.Text = "PLEASE SELECT USER NEIGHBOR AND INTRODUCE PASSWORD";
                    label_Access.BackColor = Color.IndianRed;
                }
            }
            else
            {
                MessageBox.Show("Please select a valid user from the list and introduce your correct password", "CourtBooking");
            }
        }

        // Courts. Change Paddle court selected
        private void comboBox_Courts_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox_Courts.Text)
            {
                case "Paddle_1":
                    // Paddle_1 court selected
                    Charge_Books_List("C:\\CourtBooking", "Paddle_1"); // Clean on console the list of books wirh Paddle_1 option
                    pictureBox_Court.Image = Image.FromFile("C:\\CourtBooking\\Paddle_1.jpg");
                    break;
                case "Paddle_2":
                    // Paddle_2 court selected
                    Charge_Books_List("C:\\CourtBooking", "Paddle_2"); // Clean on console the list of books wirh Paddle_2 option
                    pictureBox_Court.Image = Image.FromFile("C:\\CourtBooking\\Paddle_2.jpg");
                    break;
                default:
                    MessageBox.Show("Please select a correct court from the list court");
                    break;
            }
        }

        // Calendar. Select date
        private void dateTimePicker_Date_ValueChanged(object sender, EventArgs e)
        {
            listBox_Time_Initial.Focus();
        }

        // Time. Select Time_Initial 
        private void listBox_Time_Initial_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Time_Final.SelectedIndex = listBox_Time_Initial.SelectedIndex + 1;
        }
        // Time. Select Time_Final
        private void listBox_Time_Final_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox_Time_Initial.SelectedIndex = listBox_Time_Final.SelectedIndex - 1;
        }

        // Book. Insert book
        private void button_Book_Click(object sender, EventArgs e)
        {
            string date_Book = dateTimePicker_Date.Value.ToShortDateString(); // Date selected on console calendar by user for a new book
            string current_Book = comboBox_Courts.Text + "                      " + date_Book + "                              " + listBox_Time_Initial.Text + "                          " + listBox_Time_Final.Text + "                           " + comboBox_Users.Text;
            string last_Book = listBox_Book_Temp.Items[0].ToString();
            string select_Date = dateTimePicker_Date.Value.ToShortDateString();
            string year1 = select_Date.Substring(6, 4); // Selected date formated as yyyy
            string month1 = select_Date.Substring(3, 2); // Selected date formated as MM
            string day1 = select_Date.Substring(0, 2); // Selected date formated as dd
            string date1 = year1 + month1 + day1; // Composes date formated as yyyyMMdd              // MessageBox.Show(date1);
            string date2 = DateTime.Now.ToString("yyyyMMdd"); // Current date formated as yyyyMMdd   // MessageBox.Show(date2);

            int result = string.Compare(date1, date2);

            if (result != -1) // day1 is greater than or equal to day2
            {
                if (listBox_Time_Initial.Text != "") // The user has selected time book
                {
                    //current_Book = current_Book.Replace(" ","");
                    //last_Book = last_Book.Replace(" ","");    
                    if (current_Book.Trim() != last_Book.Trim()) // The user is inserting a new and different book 
                    {
                        listBox_Books.Items.Add(current_Book.Trim());
                        listBox_Book_Temp.Items.Clear(); // Clean the temporal book listBox that will content the last book inserted
                        listBox_Book_Temp.Items.Add(current_Book.Trim()); // Insert into temp listBox the last book registered
                        last_Book = current_Book;
                    }
                    else // The user is trying to insert the same book
                    {
                        MessageBox.Show("Please select a different book", "CourtBooking");
                    }
                }
                else // The user hasn't selected time book
                {
                    MessageBox.Show("Please select time of book", "CourtBooking");
                }
            }
            else // day 1 is less than day2
            {
                MessageBox.Show("Sorry you can't make a book with a previous date", "CourtBooking");
            }
        }

        // UnBook. UnBook a book (button_UnBook). The user can only delete his own book
        private void button_UnBook_Click_1(object sender, EventArgs e)
        {
            string selected_Book = listBox_Books.Text.Replace(" ", "");    //Line selected for unbooking
            string user_Neighbor = comboBox_Users.Text.Replace(" ", "");  //User neighbor

            bool exist = selected_Book.Contains(user_Neighbor); //Does the selected line contains the userNeighbor?

            if (exist) // The user has selected one of his books
                listBox_Books.Items.RemoveAt(listBox_Books.SelectedIndex); //We can delete the selected book
            else //The selected book won't be delete
                MessageBox.Show("Please select one of your books", "CourtBooking"); // + selected_Book + listBox_Books.SelectedItem);
        }

        // Select user neighbor and get combo password index
        private void comboBox_Users_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBox_Users_Passwords.FindString(comboBox_Users.Text);
            comboBox_Users_Passwords.SelectedIndex = index;
            textBox_Password.Focus();
        }

        // Procedure to record the books into a text file to plannification control. File C:\CourtBooking\CourtBooksPaddle(1/2).txt
        // To invoke the procedure uses: recordBooks("C:\\CourtBooking", comboBox_Courts.Text);
        private void recordBooks(string directory, string court)
        {
            // Declare path: compose directory and file 
            string path_Book = directory + "\\" + "CourtBooks" + court + ".txt"; // Books file;

            // Create the book line to insert into the books file
            string text = "Paddle_1 08/01/2023 10:00 11:00 Libertad_14"; // numberReceipString + " " + DateTime.Now + " " + textBoxTicketNumer.Text + " " + textBoxPersonID.Text + " " + textBoxTotalTicket.Text;

            // If don´t exists the directory we need to create first
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory); // Create the directory where we will put the books file
            }

            // Rename current books file for have old information
            string currentName = directory + "\\" + "CourtBooks" + court + ".txt"; // Courrent file
            string oldName = directory + "\\" + "CourtBooks" + court + "_" + DateTime.Now.ToString("yyyyMMddhhmmss") + ".txt"; // Old file

            // If file exist we need to rename to save the old books
            if (File.Exists(currentName))
            {
                System.IO.File.Move(currentName, oldName);
            }

            // Create the current file and write the books into the file  
            using (StreamWriter sw = File.CreateText(path_Book))
            {
                //Write the books and close file
                int j = listBox_Books.Items.Count - 1;
                for (int i = 0; i <= listBox_Books.Items.Count - 1; i++)
                {
                    sw.WriteLine(listBox_Books.Items[i].ToString());
                }
                sw.Close();
            }

            // User information on console about de insert info
            MessageBox.Show("The book information has been recorded in Books file", "CourtsBooking");
        }

        // Procedure to read the books file into the console listBox
        // To invoke the procedure uses: readBooks("C:\\CourtBooking", comboBox_Courts.Text);
        private void readBooks(string directory, string court)
        {
            // Declare path: compose directory and file 
            string path_Book = directory + "\\" + "CourtBooks" + court + ".txt"; // Books file;

            // If don´t exists the directory we need to create first
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory); // Create the directory where we will put the books file
            }

            // Open the current file and read the books from file to listBox
            try
            {
                using (StreamReader sr = new StreamReader(path_Book))
                {
                    while (sr.Peek() > -1)
                    {
                        string linea = sr.ReadLine();
                        if (!String.IsNullOrEmpty(linea))
                        {
                            listBox_Books.Items.Add(linea);
                        }
                        listBox_Book_Temp.Items.Clear();
                        listBox_Book_Temp.Items.Add(linea); //lastBook
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            // User information on console about de insert info
            //MessageBox.Show("The book information has been readed from Books file", "CourtsBooking");
        }

        // Save books and exit
        private void button_Save_and_Exit_Click(object sender, EventArgs e)
        {
            // Record books in a text file. I would have liked to use for this functionality a SQL DB like Oracle or SQL SERVER
            recordBooks("C:\\CourtBooking", comboBox_Courts.Text);
            Application.Exit(); // Exit of the aplicacion
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_Court_Click(object sender, EventArgs e)
        {

        }

        private void listBox_Books_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_Book_Temp_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

