namespace CourtBooking
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_Court = new System.Windows.Forms.PictureBox();
            this.label_SetDateAndTime = new System.Windows.Forms.Label();
            this.label_Time_Initial = new System.Windows.Forms.Label();
            this.label_Time_Final = new System.Windows.Forms.Label();
            this.label_Neighbor = new System.Windows.Forms.Label();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.listBox_Time_Initial = new System.Windows.Forms.ListBox();
            this.listBox_Time_Final = new System.Windows.Forms.ListBox();
            this.button_Book = new System.Windows.Forms.Button();
            this.label_Date_Book = new System.Windows.Forms.Label();
            this.label_Time_Initial_Book = new System.Windows.Forms.Label();
            this.label_Time_Final_Book = new System.Windows.Forms.Label();
            this.label_Naighbor_Book = new System.Windows.Forms.Label();
            this.label_Court_Book = new System.Windows.Forms.Label();
            this.listBox_Books = new System.Windows.Forms.ListBox();
            this.button_UnBook = new System.Windows.Forms.Button();
            this.comboBox_Users = new System.Windows.Forms.ComboBox();
            this.comboBox_Users_Passwords = new System.Windows.Forms.ComboBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_Access = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label_Court = new System.Windows.Forms.Label();
            this.comboBox_Courts = new System.Windows.Forms.ComboBox();
            this.label_Access = new System.Windows.Forms.Label();
            this.textBox_Conditions = new System.Windows.Forms.TextBox();
            this.listBox_Book_Temp = new System.Windows.Forms.ListBox();
            this.button_Save_and_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Court)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_Court
            // 
            this.pictureBox_Court.Location = new System.Drawing.Point(3, 156);
            this.pictureBox_Court.Name = "pictureBox_Court";
            this.pictureBox_Court.Size = new System.Drawing.Size(200, 215);
            this.pictureBox_Court.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_Court.TabIndex = 0;
            this.pictureBox_Court.TabStop = false;
            this.pictureBox_Court.Click += new System.EventHandler(this.pictureBox_Court_Click);
            // 
            // label_SetDateAndTime
            // 
            this.label_SetDateAndTime.AutoSize = true;
            this.label_SetDateAndTime.Location = new System.Drawing.Point(2, 112);
            this.label_SetDateAndTime.Name = "label_SetDateAndTime";
            this.label_SetDateAndTime.Size = new System.Drawing.Size(115, 13);
            this.label_SetDateAndTime.TabIndex = 5;
            this.label_SetDateAndTime.Text = "SET DATE AND TIME";
            // 
            // label_Time_Initial
            // 
            this.label_Time_Initial.AutoSize = true;
            this.label_Time_Initial.Location = new System.Drawing.Point(9, 377);
            this.label_Time_Initial.Name = "label_Time_Initial";
            this.label_Time_Initial.Size = new System.Drawing.Size(76, 13);
            this.label_Time_Initial.TabIndex = 6;
            this.label_Time_Initial.Text = "TIME_INITIAL";
            // 
            // label_Time_Final
            // 
            this.label_Time_Final.AutoSize = true;
            this.label_Time_Final.Location = new System.Drawing.Point(118, 377);
            this.label_Time_Final.Name = "label_Time_Final";
            this.label_Time_Final.Size = new System.Drawing.Size(69, 13);
            this.label_Time_Final.TabIndex = 7;
            this.label_Time_Final.Text = "TIME_FINAL";
            // 
            // label_Neighbor
            // 
            this.label_Neighbor.AutoSize = true;
            this.label_Neighbor.Location = new System.Drawing.Point(2, 9);
            this.label_Neighbor.Name = "label_Neighbor";
            this.label_Neighbor.Size = new System.Drawing.Size(64, 13);
            this.label_Neighbor.TabIndex = 8;
            this.label_Neighbor.Text = "NEIGHBOR";
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dateTimePicker_Date.Location = new System.Drawing.Point(3, 130);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Date.TabIndex = 15;
            this.dateTimePicker_Date.ValueChanged += new System.EventHandler(this.dateTimePicker_Date_ValueChanged);
            // 
            // listBox_Time_Initial
            // 
            this.listBox_Time_Initial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox_Time_Initial.FormattingEnabled = true;
            this.listBox_Time_Initial.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00"});
            this.listBox_Time_Initial.Location = new System.Drawing.Point(3, 394);
            this.listBox_Time_Initial.Name = "listBox_Time_Initial";
            this.listBox_Time_Initial.Size = new System.Drawing.Size(90, 43);
            this.listBox_Time_Initial.TabIndex = 16;
            this.listBox_Time_Initial.SelectedIndexChanged += new System.EventHandler(this.listBox_Time_Initial_SelectedIndexChanged);
            // 
            // listBox_Time_Final
            // 
            this.listBox_Time_Final.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox_Time_Final.FormattingEnabled = true;
            this.listBox_Time_Final.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00"});
            this.listBox_Time_Final.Location = new System.Drawing.Point(106, 393);
            this.listBox_Time_Final.Name = "listBox_Time_Final";
            this.listBox_Time_Final.Size = new System.Drawing.Size(97, 43);
            this.listBox_Time_Final.TabIndex = 17;
            this.listBox_Time_Final.SelectedIndexChanged += new System.EventHandler(this.listBox_Time_Final_SelectedIndexChanged);
            // 
            // button_Book
            // 
            this.button_Book.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.button_Book.Location = new System.Drawing.Point(3, 443);
            this.button_Book.Name = "button_Book";
            this.button_Book.Size = new System.Drawing.Size(200, 34);
            this.button_Book.TabIndex = 19;
            this.button_Book.Text = "BOOK";
            this.button_Book.UseVisualStyleBackColor = false;
            this.button_Book.Click += new System.EventHandler(this.button_Book_Click);
            // 
            // label_Date_Book
            // 
            this.label_Date_Book.AutoSize = true;
            this.label_Date_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Date_Book.Location = new System.Drawing.Point(319, 38);
            this.label_Date_Book.Name = "label_Date_Book";
            this.label_Date_Book.Size = new System.Drawing.Size(40, 13);
            this.label_Date_Book.TabIndex = 21;
            this.label_Date_Book.Text = "DATE";
            // 
            // label_Time_Initial_Book
            // 
            this.label_Time_Initial_Book.AutoSize = true;
            this.label_Time_Initial_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time_Initial_Book.Location = new System.Drawing.Point(465, 38);
            this.label_Time_Initial_Book.Name = "label_Time_Initial_Book";
            this.label_Time_Initial_Book.Size = new System.Drawing.Size(88, 13);
            this.label_Time_Initial_Book.TabIndex = 22;
            this.label_Time_Initial_Book.Text = "TIME_INITIAL";
            // 
            // label_Time_Final_Book
            // 
            this.label_Time_Final_Book.AutoSize = true;
            this.label_Time_Final_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Time_Final_Book.Location = new System.Drawing.Point(574, 38);
            this.label_Time_Final_Book.Name = "label_Time_Final_Book";
            this.label_Time_Final_Book.Size = new System.Drawing.Size(79, 13);
            this.label_Time_Final_Book.TabIndex = 23;
            this.label_Time_Final_Book.Text = "TIME_FINAL";
            // 
            // label_Naighbor_Book
            // 
            this.label_Naighbor_Book.AutoSize = true;
            this.label_Naighbor_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Naighbor_Book.Location = new System.Drawing.Point(679, 38);
            this.label_Naighbor_Book.Name = "label_Naighbor_Book";
            this.label_Naighbor_Book.Size = new System.Drawing.Size(72, 13);
            this.label_Naighbor_Book.TabIndex = 24;
            this.label_Naighbor_Book.Text = "NEIGHBOR";
            // 
            // label_Court_Book
            // 
            this.label_Court_Book.AutoSize = true;
            this.label_Court_Book.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Court_Book.Location = new System.Drawing.Point(214, 38);
            this.label_Court_Book.Name = "label_Court_Book";
            this.label_Court_Book.Size = new System.Drawing.Size(50, 13);
            this.label_Court_Book.TabIndex = 25;
            this.label_Court_Book.Text = "COURT";
            // 
            // listBox_Books
            // 
            this.listBox_Books.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox_Books.FormattingEnabled = true;
            this.listBox_Books.Location = new System.Drawing.Point(212, 55);
            this.listBox_Books.Name = "listBox_Books";
            this.listBox_Books.Size = new System.Drawing.Size(622, 173);
            this.listBox_Books.TabIndex = 26;
            this.listBox_Books.SelectedIndexChanged += new System.EventHandler(this.listBox_Books_SelectedIndexChanged);
            // 
            // button_UnBook
            // 
            this.button_UnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button_UnBook.Location = new System.Drawing.Point(3, 483);
            this.button_UnBook.Name = "button_UnBook";
            this.button_UnBook.Size = new System.Drawing.Size(200, 24);
            this.button_UnBook.TabIndex = 27;
            this.button_UnBook.Text = "UNBOOK";
            this.button_UnBook.UseVisualStyleBackColor = false;
            this.button_UnBook.Click += new System.EventHandler(this.button_UnBook_Click_1);
            // 
            // comboBox_Users
            // 
            this.comboBox_Users.FormattingEnabled = true;
            this.comboBox_Users.Location = new System.Drawing.Point(78, 3);
            this.comboBox_Users.Name = "comboBox_Users";
            this.comboBox_Users.Size = new System.Drawing.Size(125, 21);
            this.comboBox_Users.TabIndex = 28;
            this.comboBox_Users.SelectedIndexChanged += new System.EventHandler(this.comboBox_Users_SelectedIndexChanged);
            // 
            // comboBox_Users_Passwords
            // 
            this.comboBox_Users_Passwords.FormattingEnabled = true;
            this.comboBox_Users_Passwords.Location = new System.Drawing.Point(696, 6);
            this.comboBox_Users_Passwords.Name = "comboBox_Users_Passwords";
            this.comboBox_Users_Passwords.Size = new System.Drawing.Size(133, 21);
            this.comboBox_Users_Passwords.TabIndex = 29;
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(78, 29);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(125, 20);
            this.textBox_Password.TabIndex = 31;
            this.textBox_Password.TextChanged += new System.EventHandler(this.textBox_Password_TextChanged);
            // 
            // button_Access
            // 
            this.button_Access.BackColor = System.Drawing.Color.Silver;
            this.button_Access.Location = new System.Drawing.Point(3, 53);
            this.button_Access.Name = "button_Access";
            this.button_Access.Size = new System.Drawing.Size(200, 22);
            this.button_Access.TabIndex = 32;
            this.button_Access.Text = "ACCESS";
            this.button_Access.UseVisualStyleBackColor = false;
            this.button_Access.Click += new System.EventHandler(this.button_Access_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "PASSWORD";
            // 
            // label_Court
            // 
            this.label_Court.AutoSize = true;
            this.label_Court.Location = new System.Drawing.Point(2, 89);
            this.label_Court.Name = "label_Court";
            this.label_Court.Size = new System.Drawing.Size(45, 13);
            this.label_Court.TabIndex = 4;
            this.label_Court.Text = "COURT";
            // 
            // comboBox_Courts
            // 
            this.comboBox_Courts.FormattingEnabled = true;
            this.comboBox_Courts.Location = new System.Drawing.Point(78, 81);
            this.comboBox_Courts.Name = "comboBox_Courts";
            this.comboBox_Courts.Size = new System.Drawing.Size(125, 21);
            this.comboBox_Courts.TabIndex = 34;
            this.comboBox_Courts.SelectedIndexChanged += new System.EventHandler(this.comboBox_Courts_SelectedIndexChanged);
            // 
            // label_Access
            // 
            this.label_Access.AutoSize = true;
            this.label_Access.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label_Access.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Access.Location = new System.Drawing.Point(212, 6);
            this.label_Access.Name = "label_Access";
            this.label_Access.Size = new System.Drawing.Size(421, 13);
            this.label_Access.TabIndex = 35;
            this.label_Access.Text = "<---- PLEASE SELECT USER NEIGHBOR AND INTRODUCE PASSWORD";
            // 
            // textBox_Conditions
            // 
            this.textBox_Conditions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.textBox_Conditions.Location = new System.Drawing.Point(212, 260);
            this.textBox_Conditions.Multiline = true;
            this.textBox_Conditions.Name = "textBox_Conditions";
            this.textBox_Conditions.Size = new System.Drawing.Size(622, 247);
            this.textBox_Conditions.TabIndex = 36;
            // 
            // listBox_Book_Temp
            // 
            this.listBox_Book_Temp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.listBox_Book_Temp.FormattingEnabled = true;
            this.listBox_Book_Temp.Location = new System.Drawing.Point(212, 210);
            this.listBox_Book_Temp.Name = "listBox_Book_Temp";
            this.listBox_Book_Temp.Size = new System.Drawing.Size(621, 17);
            this.listBox_Book_Temp.TabIndex = 37;
            this.listBox_Book_Temp.SelectedIndexChanged += new System.EventHandler(this.listBox_Book_Temp_SelectedIndexChanged);
            // 
            // button_Save_and_Exit
            // 
            this.button_Save_and_Exit.BackColor = System.Drawing.Color.Silver;
            this.button_Save_and_Exit.Location = new System.Drawing.Point(212, 233);
            this.button_Save_and_Exit.Name = "button_Save_and_Exit";
            this.button_Save_and_Exit.Size = new System.Drawing.Size(621, 21);
            this.button_Save_and_Exit.TabIndex = 38;
            this.button_Save_and_Exit.Text = "SAVE and EXIT";
            this.button_Save_and_Exit.UseVisualStyleBackColor = false;
            this.button_Save_and_Exit.Click += new System.EventHandler(this.button_Save_and_Exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 519);
            this.Controls.Add(this.button_Save_and_Exit);
            this.Controls.Add(this.listBox_Book_Temp);
            this.Controls.Add(this.textBox_Conditions);
            this.Controls.Add(this.label_Access);
            this.Controls.Add(this.comboBox_Courts);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button_Access);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.comboBox_Users_Passwords);
            this.Controls.Add(this.comboBox_Users);
            this.Controls.Add(this.button_UnBook);
            this.Controls.Add(this.listBox_Books);
            this.Controls.Add(this.label_Court_Book);
            this.Controls.Add(this.label_Naighbor_Book);
            this.Controls.Add(this.label_Time_Final_Book);
            this.Controls.Add(this.label_Time_Initial_Book);
            this.Controls.Add(this.label_Date_Book);
            this.Controls.Add(this.button_Book);
            this.Controls.Add(this.listBox_Time_Final);
            this.Controls.Add(this.listBox_Time_Initial);
            this.Controls.Add(this.dateTimePicker_Date);
            this.Controls.Add(this.label_Neighbor);
            this.Controls.Add(this.label_Time_Final);
            this.Controls.Add(this.label_Time_Initial);
            this.Controls.Add(this.label_SetDateAndTime);
            this.Controls.Add(this.label_Court);
            this.Controls.Add(this.pictureBox_Court);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "CourtBooking";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Court)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_Court;
        private System.Windows.Forms.Label label_SetDateAndTime;
        private System.Windows.Forms.Label label_Time_Initial;
        private System.Windows.Forms.Label label_Time_Final;
        private System.Windows.Forms.Label label_Neighbor;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.ListBox listBox_Time_Initial;
        private System.Windows.Forms.ListBox listBox_Time_Final;
        private System.Windows.Forms.Button button_Book;
        private System.Windows.Forms.Label label_Date_Book;
        private System.Windows.Forms.Label label_Time_Initial_Book;
        private System.Windows.Forms.Label label_Time_Final_Book;
        private System.Windows.Forms.Label label_Naighbor_Book;
        private System.Windows.Forms.Label label_Court_Book;
        private System.Windows.Forms.ListBox listBox_Books;
        private System.Windows.Forms.Button button_UnBook;
        private System.Windows.Forms.ComboBox comboBox_Users;
        private System.Windows.Forms.ComboBox comboBox_Users_Passwords;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Button button_Access;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_Court;
        private System.Windows.Forms.ComboBox comboBox_Courts;
        private System.Windows.Forms.Label label_Access;
        private System.Windows.Forms.TextBox textBox_Conditions;
        private System.Windows.Forms.ListBox listBox_Book_Temp;
        private System.Windows.Forms.Button button_Save_and_Exit;
    }
}



