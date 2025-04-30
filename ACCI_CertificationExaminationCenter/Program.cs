using Microsoft.VisualBasic.Logging;

namespace ACCI_CertificationExaminationCenter
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            bool isLoggedOut;

            do
            {
                isLoggedOut = false;

                using (DangNhap loginForm = new DangNhap())
                {
                    if (loginForm.ShowDialog() == DialogResult.OK)
                    {
                        string username = loginForm.LayTenDangNhap();
                        string role = loginForm.LayVaiTro();

                        MainForm mainForm = new MainForm(username, role);

                        // Gắn event Logout
                        if (mainForm is ILogoutable logoutableForm)
                        {
                            logoutableForm.LogoutRequested += () => isLoggedOut = true;
                        }

                        Application.Run(mainForm);
                    }
                    else
                    {
                        break;
                    }
                }

            } while (isLoggedOut);

        }
    }

    public interface ILogoutable
    {
        event Action LogoutRequested;
    }
}