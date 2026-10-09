using OfiCentral.PedidoMateriales.Formularios;

namespace OfiCentral.PedidoMateriales
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMenuPrincipal());
        }
    }
}
