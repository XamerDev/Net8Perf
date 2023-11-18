using Microsoft.Win32;
using Net8Perf.Views;

namespace Net8Perf
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("/details", typeof(DetailsView));
        }
    }
}
