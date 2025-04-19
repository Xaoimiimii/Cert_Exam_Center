namespace ACCI_CertificationExaminationCenter
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //Application.Run(new MainForm());
            MainForm mainForm = new MainForm(); // create MainForm instance
            Form wrapperForm = new Form();      // host window for the UserControl

            var control = new QuanLyNhanVien(mainForm); // pass it to the constructor
            control.Dock = DockStyle.Fill;

            wrapperForm.Controls.Add(control);
            wrapperForm.StartPosition = FormStartPosition.CenterScreen;

            Application.Run(wrapperForm);

        }
    }
}