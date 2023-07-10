using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using GamePlayer;

namespace ChessMazeWinFrom
{
    public interface IView
    {
        Button[,] GridOfButtons { get; set; }
        // Button[,] GridOfButtons;
        // void loadButtonGrid();
        //int GetTestWidth();

        void HideKnightMovement();
        void ShowKnightMovement();
        void HidePieceMovement();
        void ShowPieceMovement();

        void ShowWin();
        void HideWin();
        void ShowInvalidMessage();
        void HideInvalidMessage();
        void UpdateMoveCount(string moves);

    }
}
