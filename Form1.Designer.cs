namespace SearchTextBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            searchTextBox1 = new custom.SearchTextBox();
            searchTextBox2 = new custom.SearchTextBox();
            searchTextBox3 = new custom.SearchTextBox();
            searchTextBox4 = new custom.SearchTextBox();
            searchTextBox5 = new custom.SearchTextBox();
            SuspendLayout();
            // 
            // searchTextBox1
            // 
            searchTextBox1.allowSearch = true;
            searchTextBox1.Location = new Point(12, 12);
            searchTextBox1.MinimumSize = new Size(100, 55);
            searchTextBox1.Name = "searchTextBox1";
            searchTextBox1.readOnly = false;
            searchTextBox1.Size = new Size(200, 55);
            searchTextBox1.subtitleShow = true;
            searchTextBox1.subtitleText = "Subtitle";
            searchTextBox1.TabIndex = 0;
            searchTextBox1.text = "";
            searchTextBox1.titleText = "Title";
            // 
            // searchTextBox2
            // 
            searchTextBox2.allowSearch = false;
            searchTextBox2.Location = new Point(12, 200);
            searchTextBox2.MinimumSize = new Size(100, 55);
            searchTextBox2.Name = "searchTextBox2";
            searchTextBox2.readOnly = false;
            searchTextBox2.Size = new Size(200, 55);
            searchTextBox2.subtitleShow = true;
            searchTextBox2.subtitleText = "age: 20";
            searchTextBox2.TabIndex = 1;
            searchTextBox2.text = "Amir Reza Shalviri";
            searchTextBox2.titleText = "Student Name:";
            // 
            // searchTextBox3
            // 
            searchTextBox3.allowSearch = true;
            searchTextBox3.Location = new Point(272, 12);
            searchTextBox3.MinimumSize = new Size(100, 55);
            searchTextBox3.Name = "searchTextBox3";
            searchTextBox3.readOnly = true;
            searchTextBox3.Size = new Size(200, 55);
            searchTextBox3.subtitleShow = false;
            searchTextBox3.subtitleText = "Subtitle";
            searchTextBox3.TabIndex = 2;
            searchTextBox3.text = "";
            searchTextBox3.titleText = "Title";
            searchTextBox3.UserSearchClick += searchTextBox1_UserSearchClick;
            // 
            // searchTextBox4
            // 
            searchTextBox4.allowSearch = false;
            searchTextBox4.Location = new Point(272, 106);
            searchTextBox4.MinimumSize = new Size(100, 55);
            searchTextBox4.Name = "searchTextBox4";
            searchTextBox4.readOnly = false;
            searchTextBox4.Size = new Size(200, 55);
            searchTextBox4.subtitleShow = false;
            searchTextBox4.subtitleText = "Subtitle";
            searchTextBox4.TabIndex = 3;
            searchTextBox4.text = "";
            searchTextBox4.titleText = "Title";
            // 
            // searchTextBox5
            // 
            searchTextBox5.allowSearch = false;
            searchTextBox5.Location = new Point(12, 106);
            searchTextBox5.MinimumSize = new Size(100, 55);
            searchTextBox5.Name = "searchTextBox5";
            searchTextBox5.readOnly = false;
            searchTextBox5.Size = new Size(200, 55);
            searchTextBox5.subtitleShow = true;
            searchTextBox5.subtitleText = "Subtitle";
            searchTextBox5.TabIndex = 4;
            searchTextBox5.text = "";
            searchTextBox5.titleText = "Title";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 461);
            Controls.Add(searchTextBox5);
            Controls.Add(searchTextBox4);
            Controls.Add(searchTextBox3);
            Controls.Add(searchTextBox2);
            Controls.Add(searchTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private custom.SearchTextBox searchTextBox1;
        private custom.SearchTextBox searchTextBox2;
        private custom.SearchTextBox searchTextBox3;
        private custom.SearchTextBox searchTextBox4;
        private custom.SearchTextBox searchTextBox5;
    }
}
