using System.ComponentModel;

namespace SearchTextBox.custom
{
    [DefaultEvent("UserSearchClick")]
    public partial class SearchTextBox : UserControl
    {
        public event EventHandler UserSearchClick;

        private bool selectFlag = true;

        private bool subtitleFlag = true;

        public SearchTextBox()
        {
            InitializeComponent();

            this.MinimumSize = new System.Drawing.Size(100, 60);
        }

        public bool allowSearch
        {
            get
            {
                return selectFlag;
            }
            set
            {
                selectFlag = value;

                if (selectFlag)
                {
                    pictureBox1.Visible = true;
                }
                else
                {
                    pictureBox1.Visible = false;
                }
            }
        }

        public string titleText
        {
            get
            {
                return lb_title.Text;
            }
            set
            {
                lb_title.Text = value;
            }
        }

        public string text
        {
            get
            {
                return tb_text.Text;
            }
            set
            {
                tb_text.Text = value;
            }
        }

        public string subtitleText
        {
            get
            {
                return lb_subtitle.Text;
            }
            set
            {
                lb_subtitle.Text = value;
            }
        }

        public bool subtitleShow
        {
            get
            {
                return subtitleFlag;
            }
            set
            {
                subtitleFlag = value;

                if (subtitleFlag)
                {
                    lb_subtitle.Visible = true;
                }
                else
                {
                    lb_subtitle.Visible = false;
                }
            }
        }

        public bool readOnly
        {
            get
            {
                return tb_text.ReadOnly;
            }
            set
            {
                tb_text.ReadOnly = value;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (selectFlag)
            {
                if (this.UserSearchClick != null)
                    this.UserSearchClick(this, e);
            }
        }

        public bool isEmpty()
        {
            return string.IsNullOrEmpty(tb_text.Text);
        }
    }
}
