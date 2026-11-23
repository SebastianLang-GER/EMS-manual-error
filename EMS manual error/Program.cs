using System.ComponentModel;

/***
 * To do:
 * - SCPI server
 * - Autostart with Windows
 * - Always on top --> (on)/off, if known software (ELEKTRA) is open, permanent
 *   - List of Processes
 * - Window position
 *   - Window fixed/moveable
 *   - Coordinates or areas (corners, multiple screens etc.) with quick select buttons
 *   - Location related to program (ELEKTRA)
 * - Server settings
 *   - TCP-Port
 *   - Commands/responses Table
 *   - Value on error/no error
 * - Global shortcut
 */

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
            bool firstAppInstance = true;

            // single instance application
            using (new Mutex(initiallyOwned: true, "EMS manual error", out firstAppInstance))
            {
                if (firstAppInstance)
                {
                    ApplicationConfiguration.Initialize();
                    Application.Run(new TrayIconApp());
                }
            }
        }
    }
}