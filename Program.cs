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

            // 명령줄 인수를 frmDdayTimer로 전달
            Application.Run(new frmDdayTimer(args));
        }
    }
}