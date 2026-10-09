using NetAssist.Tickets.MenuPrincipal;
using NetAssist.Tickets.RegistrarTicket;

namespace NetAssist.Tickets
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new RegistrarTicketForm());
        }
    }
}
