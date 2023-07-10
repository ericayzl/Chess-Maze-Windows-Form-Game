using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayer
{
    class Rook : Piece
    {
        public Rook(int yValue, int xValue, int boardSize) {
            YCoordinate = yValue;
            XCoordinate = xValue;
            Name = FilerNS.Part.Rook;
            BoardWidth = boardSize;
            SetAllowedUpMoves();
            SetAllowedDownMoves();
            SetAllowedLeftMoves();
            SetAllowedRightMoves();
        }

        override public void ActiveTile()
        {
            Name = FilerNS.Part.PlayerOnRook;
        }

        override public void NotActiveTile()
        {
            Name = FilerNS.Part.Rook;
        }

        override protected bool SetAllowedUpMoves() {           
            AllowedUpMoves.Clear();
            for (int i = YCoordinate - 1; i >= BoardMin; i--) {
                string allowedMove = $"{i} : {XCoordinate}";
                AllowedUpMoves.Add(allowedMove);
            }
            bool moveIsSet = true;
            return moveIsSet;
        }

        override protected bool SetAllowedDownMoves() {           
            AllowedDownMoves.Clear();
            for (int i = YCoordinate + 1; i < BoardWidth; i++)
            {
                string allowedMove = $"{i} : {XCoordinate}";
                AllowedDownMoves.Add(allowedMove);
            }
            bool moveIsSet = true;
            return moveIsSet;
        }

        override protected bool SetAllowedLeftMoves() {            
            AllowedLeftMoves.Clear();
            for (int i = XCoordinate - 1; i >= BoardMin; i--)
            {
                string allowedMove = $"{YCoordinate} : {i}";
                AllowedLeftMoves.Add(allowedMove);
            }
            bool moveIsSet = true;
            return moveIsSet;
        }

        override protected bool SetAllowedRightMoves() {           
            AllowedRightMoves.Clear();
            for (int i = XCoordinate + 1; i < BoardWidth; i++)
            {
                string allowedMove = $"{YCoordinate} : {i}";
                AllowedRightMoves.Add(allowedMove);
            }
            bool moveIsSet = true;
            return moveIsSet;
        }

        override protected bool SetAllowedUpLeftMoves() {
            bool moveIsSet = false;
            return moveIsSet;
        }

        override protected bool SetAllowedUpRightMoves() {
            bool moveIsSet = false;
            return moveIsSet;
        }

        override protected bool SetAllowedDownLeftMoves() {
            bool moveIsSet = false;
            return moveIsSet;
        }

        override protected bool SetAllowedDownRightMoves()
        {
            bool moveIsSet = false;
            return moveIsSet;
        }
    }
}
