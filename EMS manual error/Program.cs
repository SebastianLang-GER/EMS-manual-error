using System.ComponentModel;

namespace EMSME
{
    internal static class Program
    {
        private static bool _error = false;

        public static event PropertyChangedEventHandler? PropertyChanged;

        public static bool Error
        {
            get => _error;
            set
            {
                if (_error == value)
                    return;

                _error = value;
                PropertyChanged?.Invoke(null, new PropertyChangedEventArgs(nameof(Error)));
            }
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Button());
        }
    }
}