using BarCitizenKR;

namespace DDayTimer
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // ����� �μ��� frmDdayTimer�� ����
            Application.Run(new frmDdayTimer(args));
        }
    }
}