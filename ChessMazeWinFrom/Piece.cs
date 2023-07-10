using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FilerNS;

namespace GamePlayer
{
    public abstract class Piece
    {
        public int YCoordinate;
        public int XCoordinate;
        public Part Name;

        public List<string> AllowedUpMoves = new List<string>();
        public List<string> AllowedDownMoves = new List<string>();
        public List<string> AllowedLeftMoves = new List<string>();
        public List<string> AllowedRightMoves = new List<string>();
        public List<string> AllowedUpLeftMoves = new List<string>();
        public List<string> AllowedUpRightMoves = new List<string>();
        public List<string> AllowedDownLeftMoves = new List<string>();
        public List<string> AllowedDownRightMoves = new List<string>();

        protected int BoardWidth;
        protected int BoardMin = 0;

        public abstract void ActiveTile();
        
        public abstract void NotActiveTile();

        protected abstract bool SetAllowedUpMoves();
        protected abstract bool SetAllowedDownMoves();
        protected abstract bool SetAllowedLeftMoves();
        protected abstract bool SetAllowedRightMoves();
        protected abstract bool SetAllowedUpLeftMoves();
        protected abstract bool SetAllowedUpRightMoves();
        protected abstract bool SetAllowedDownLeftMoves();
        protected abstract bool SetAllowedDownRightMoves();
    }
}
