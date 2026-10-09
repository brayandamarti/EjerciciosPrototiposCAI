using NetAssist.Tickets.MenuPrincipal;

namespace NetAssist.Tickets
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
