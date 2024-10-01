using SearchTextBox.Properties;

namespace SearchTextBox.custom
{
    partial class SearchTextBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_title = new Label();
            tb_text = new TextBox();
            lb_subtitle = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lb_title
            // 
            lb_title.AutoSize = true;
            lb_title.Dock = DockStyle.Top;
            lb_title.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_title.Location = new Point(0, 0);
            lb_title.Name = "lb_title";
            lb_title.Size = new Size(36, 17);
            lb_title.TabIndex = 0;
            lb_title.Text = "Title";
            // 
            // tb_text
            // 
            tb_text.BorderStyle = BorderStyle.FixedSingle;
            tb_text.Dock = DockStyle.Top;
            tb_text.Location = new Point(0, 17);
            tb_text.Name = "tb_text";
            tb_text.Size = new Size(172, 23);
            tb_text.TabIndex = 1;
            // 
            // lb_subtitle
            // 
            lb_subtitle.AutoSize = true;
            lb_subtitle.Dock = DockStyle.Top;
            lb_subtitle.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lb_subtitle.Location = new Point(0, 40);
            lb_subtitle.Name = "lb_subtitle";
            lb_subtitle.Size = new Size(47, 13);
            lb_subtitle.TabIndex = 2;
            lb_subtitle.Text = "Subtitle";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Right;
            pictureBox1.Image = Resources.search;
            pictureBox1.Location = new Point(172, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // SearchTextBox
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lb_subtitle);
            Controls.Add(tb_text);
            Controls.Add(lb_title);
            Controls.Add(pictureBox1);
            Name = "SearchTextBox";
            Size = new Size(200, 60);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_title;
        private TextBox tb_text;
        private Label lb_subtitle;
        private PictureBox pictureBox1;
    }
}
