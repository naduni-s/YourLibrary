using LibrarySystem.CLASSES;
using LibrarySystem.FORMS;
using MySql.Data.MySqlClient;

namespace LibrarySystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());
        }
    }
}