using ClinicaCAI.Atencion.MenuPrincipal;

namespace ClinicaCAI.Atencion
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new MenuPrincipalForm());
        }
    }
}
