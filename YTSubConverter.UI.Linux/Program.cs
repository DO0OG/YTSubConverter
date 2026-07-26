using YTSubConverter.Shared;
using Gtk;

namespace YTSubConverter.UI.Linux
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                using GtkTextMeasurer textMeasurer = new();
                CommandLineHandler.Handle(args, textMeasurer);
                return;
            }

            // Initialize application only after checking checking if the application is run as a command line app.
            // Useful in headless environments, e.g. VMs.
            Application.Init("ytsubconverter", ref args);
            using var window = new MainWindow();
            window.Show();
            Application.Run();
        }
    }
}
