namespace QueuingApplication
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            QueuingForm qForm = new QueuingForm();
            CashierWindowQueueForm cForm = new CashierWindowQueueForm();

            qForm.Show();
            cForm.Show();

            Application.Run();
        }
    }
}