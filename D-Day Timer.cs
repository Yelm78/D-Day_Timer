using System.Drawing.Text;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace BarCitizenKR
{
    public partial class frmDdayTimer : Form
    {
        public DateTime dday;
        public PrivateFontCollection privateFonts;
        public bool blBoarder = false;
        public double oppacity = 1;
        public bool bctzkr = true;

        public frmDdayTimer(string[] args)
        {
            InitializeComponent();
            ui_Switch();
            this.Focus(); // ���� ��Ŀ�� ����

            //�⺻�� : �� ��Ƽ�� �ڸ��� D-Day
            this.dday = new DateTime(2025, 05, 03, 19, 00, 00);

            //LoadCustomFont();
            //ApplyCustomFont();

            // ����� �μ� ó��(argument)
            if (args.Length > 0)
            {
                foreach (var arg in args)
                {
                    string msg = "������ : " + "��������.exe" + """ "YYYY-MM-DD_hh:mm:ss" """;
                    if (arg.Length == 19)
                    {
                        try
                        {
                            this.dday = new DateTime(
                                int_Parse(StringMid(arg, 0, 4)),
                                int_Parse(StringMid(arg, 5, 2)),
                                int_Parse(StringMid(arg, 8, 2)),
                                int_Parse(StringMid(arg, 11, 2)),
                                int_Parse(StringMid(arg, 14, 2)),
                                int_Parse(StringMid(arg, 17, 2)));
                            bctzkr = false;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(msg);
                        }
                    }
                    else
                    {
                        MessageBox.Show(msg);                        
                    }
                }
            }

            if (bctzkr)
            {
                this.Text = "Bar Citizen Korea";
            }
            else
            {
                this.Text = "D-Day Timer";
            }

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(0, 0);

            untilDate.Text = StringRight("0000" + dday.Year.ToString(), 4) + "-"
                + StringRight("00" + dday.Month.ToString(), 2) + "-"
                + StringRight("00" + dday.Day.ToString(), 2);
            untilTime.Text = StringRight("00" + dday.Hour.ToString(), 2) + ":"
                + StringRight("00" + dday.Minute.ToString(), 2) + ":"
                + StringRight("00" + dday.Second.ToString(), 2);

            timer.Start();
        }

        private int int_Parse(string str)
        {
            try
            {
                int result = int.Parse(str);
                return result;
            }
            catch
            {
                return -1; // ���� �߻� �� -1 ��ȯ
            }
        }
        
        private void timer_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now; // Moved 'now' here to fix scope issue
            TimeSpan timeLeft;
            if (dday > now)
            {
                timeLeft = dday - now;
            }
            else
            {
                timeLeft = now - dday;
                lblRemaining.Text = "after";
                lblUntil.Text = "from";
            }

            leftDate.Text = StringRight("0000" + (timeLeft.Days / 365).ToString(), 4) + "-"
                + StringRight("00" + ((timeLeft.Days % 365) / 30).ToString(), 2) + "-"
                + StringRight("00" + ((timeLeft.Days % 365) % 30).ToString(), 2);
            leftTime.Text = StringRight("00" + (timeLeft.Hours).ToString(), 2) + ":"
                + StringRight("00" + (timeLeft.Minutes).ToString(), 2) + ":"
                + StringRight("00" + (timeLeft.Seconds).ToString(), 2) + "."
                + StringRight("00" + (timeLeft.Milliseconds).ToString(), 2);
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            base.OnMouseWheel(e);

            oppacity = ((double)this.Opacity);
            if (e.Delta > 0)
            {
                // ���콺 �� ��
                if (oppacity < 1)
                {
                    this.Opacity = oppacity + 0.05;//�ִ� 100% ���� ���� ����
                }
            }
            else if (e.Delta < 0)
            {
                // ���콺 �� �ٿ�                
                if (oppacity > 0.1)
                {
                    this.Opacity = oppacity - 0.05;
                }
                else
                {
                    this.Opacity = 0.01;           //�ּ� 1% ���� ���� ����
                }
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.Focus(); // ���� ��Ŀ�� ����
        }

        private void frmDdayTimer_MouseHover(object sender, EventArgs e)//���콺 �� �̺�Ʈ�� �ٲٸ鼭 ��� ����
        {
            //this.Opacity = 1;
        }

        private void frmDdayTimer_MouseLeave(object sender, EventArgs e)//���콺 �� �̺�Ʈ�� �ٲٸ鼭 ��� ����
        {
            //this.Opacity = 0.3;
        }

        private void frmDdayTimer_DoubleClick(object sender, EventArgs e)
        {
            ui_Switch();
        }

        private void ui_Switch()
        {
            if (!blBoarder)
            {
                this.FormBorderStyle = FormBorderStyle.None;
                this.ForeColor = Color.Snow;
                this.BackColor = Color.Black;
                blBoarder = true;
            }
            else
            {
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.ShowIcon = true;
                this.ForeColor = SystemColors.ControlText;
                this.BackColor = SystemColors.Control;
                blBoarder = false;
            }
        }

        #region ���ڿ� ó�� �Լ���
        // ���ڿ� �ڸ��� (Right)
        private string StringRight(string text, int length)
        {
            if (string.IsNullOrEmpty(text)) return string.Empty;
            return text.Length <= length ? text : text.Substring(text.Length - length);
        }

        // ���ڿ� �ڸ��� (Left)
        private string StringLeft(string text, int length)
        {
            if (string.IsNullOrEmpty(text)) return string.Empty;
            return text.Length <= length ? text : text.Substring(0, length);
        }

        // ���ڿ� �ڸ��� (Mid)
        private string StringMid(string text, int start, int length)
        {
            if (string.IsNullOrEmpty(text) || start >= text.Length) return string.Empty;
            if (start + length > text.Length) length = text.Length - start;
            return text.Substring(start, length);
        }

        // ���ڿ� ã�� (Find)
        private List<int> StringFind(string text, string findText)
        {
            if (string.IsNullOrEmpty(text) || string.IsNullOrEmpty(findText)) return new List<int>();

            var findPlaces = new List<int>();
            int index = text.IndexOf(findText, StringComparison.Ordinal);
            while (index != -1)
            {
                findPlaces.Add(index);
                index = text.IndexOf(findText, index + 1, StringComparison.Ordinal);
            }
            return findPlaces;
        }
        #endregion
    }
}
