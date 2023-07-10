using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamePlayer
{
    class King : Piece
    {
        public King(int yValue, int xValue, int boardSize)
        {
            YCoordinate = yValue;
            XCoordinate = xValue;
            Name = FilerNS.Part.King;
            BoardWidth = boardSize;
            SetAllowedUpMoves();
            SetAllowedDownMoves();
            SetAllowedLeftMoves();
            SetAllowedRightMoves();
            SetAllowedUpLeftMoves();
            SetAllowedUpRightMoves();
            SetAllowedDownLeftMoves();
            SetAllowedDownRightMoves();
        }

        override public void ActiveTile() {
            Name = FilerNS.Part.PlayerOnKing;
        }

        override public void NotActiveTile() {
            Name = FilerNS.Part.King;
        }

        override protected bool SetAllowedUpMoves()
        {
            AllowedUpMoves.Clear();
            string allowedMove = $"{YCoordinate - 1} : {XCoordinate}";
            AllowedUpMoves.Add(allowedMove);
            bool moveIsSet = true;
            return moveIsSet;
        }

        override protected bool SetAllowedDownMoves()
        {
            AllowedDownMoves.Clear();
            string allowedMove = $"{YCoordinate + 1} : {XCoordinate}";
            AllowedDownMoves.Add(allowedMove);
            bool moveIsSet = true;
            return moveIsSet;
        }

        override protected bool SetAllowedLeftMoves()
        {
            AllowedLeftMoves.Clear();
            string allowedMove = $"{YCoordinate} : {XCoordinate - 1}";
            AllowedLeftMoves.Add(allowedMove);
            bool moveIsSet = true;
            return moveIsSet;
        }

        override protected bool SetAllowedRightMoves()
        {
            AllowedRightMoves.Clear();
            string allowedMove = $"{YCoordinate} : {XCoordinate + 1}";
            AllowedRightMoves.Add(allowedMove);
            bool moveIsSet = true;
            return moveIsSet;
        }

        override protected bool SetAllowedUpLeftMoves()
        {
            AllowedUpLeftMoves.Clear();
            string allowedMove = $"{YCoordinate - 1} : {XCoordinate - 1}";
            AllowedUpLeftMoves.Add(allowedMove);
            bool moveIsSet = true;
            return moveIsSet;
        }

        override protected bool SetAllowedUpRightMoves()
        {
            AllowedUpRightMoves.Clear();
            string allowedMove = $"{YCoordinate - 1} : {XCoordinate + 1}";
            AllowedUpRightMoves.Add(allowedMove);
            bool moveIsSet = true;
            return moveIsSet;
        }
        override protected bool SetAllowedDownLeftMoves()
        {
            AllowedDownLeftMoves.Clear();
            string allowedMove = $"{YCoordinate + 1} : {XCoordinate - 1}";
            AllowedDownLeftMoves.Add(allowedMove);
            bool moveIsSet = true;
            return moveIsSet;
        }
        override protected bool SetAllowedDownRightMoves()
        {
            AllowedDownRightMoves.Clear();
            string allowedMove = $"{YCoordinate + 1} : {XCoordinate + 1}";
            AllowedDownRightMoves.Add(allowedMove);
            bool moveIsSet = true;
            return moveIsSet;
        }
    }
}
