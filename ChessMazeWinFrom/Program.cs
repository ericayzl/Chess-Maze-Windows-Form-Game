using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GamePlayer;

namespace ChessMazeWinFrom
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            FormMain formMain = new FormMain();
            // formMain.SetController(new GameController(formMain.SmallGameChild, new Game()));
            Application.Run(formMain);
        }
    }
}
