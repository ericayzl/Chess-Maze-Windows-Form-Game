﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using GamePlayer;
using FilerNS;
using GameNS;

namespace ChessMazeWinFrom
{
    public partial class FormGame3 : Form, IView
    {
        public const int GridWidthNumber = 5;
        public const int GridLengthNumber = 5;
        private readonly string _fileString = "NQEQB\nEEKEK\nERBBB\nNEEKE\nEBERQ";

        public Button[,] _gridOfButtons;

        public Button[,] GridOfButtons
        {
            get { return _gridOfButtons; }
            set
            {
                _gridOfButtons = value;
            }
        }

        private GameController _controller;

        public FormGame3()
        {
            InitializeComponent();
            loadButtonGrid();
            HideWin();
            HideInvalidMessage();
            HideKnightMovement();
            HidePieceMovement();
        }

        public void loadButtonGrid()
        {
            _gridOfButtons = new Button[GridWidthNumber, GridLengthNumber]
                            {
                                {button00, button01, button02, button03, button04},
                                {button10, button11, button12, button13, button14},
                                {button20, button21, button22, button23, button24},
                                {button30, button31, button32, button33, button34},
                                {button40, button41, button42, button43, button44}
                            };
        }

        public void SetController()
        {
            _controller = new GameController(this, new Game());
        }

        private void FormGame3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            _controller.SetLoadString(_fileString);
            _controller.GridWidthNumber = GridWidthNumber;
            _controller.GridLengthNumber = GridLengthNumber;
            _controller.Go();
        }

        public void HideKnightMovement()
        {
            labelKnight.Hide();
            labelVertical.Hide();
            comboBoxKnightVertical.Hide();
            labelHorizontal.Hide();
            comboBoxKnightHorizontal.Hide();
            buttonMoveKnight.Hide();
        }

        public void ShowKnightMovement()
        {
            labelKnight.Show();
            labelVertical.Show();
            comboBoxKnightVertical.Show();
            labelHorizontal.Show();
            comboBoxKnightHorizontal.Show();
            buttonMoveKnight.Show();
        }

        public void HidePieceMovement()
        {
            labelPiece.Hide();
            labelDirection.Hide();
            comboBoxPieceDirection.Hide();
            labelSteps.Hide();
            comboBoxPieceSteps.Hide();
            buttonMovePiece.Hide();
        }

        public void ShowPieceMovement()
        {
            labelPiece.Show();
            labelDirection.Show();
            comboBoxPieceDirection.Show();
            labelSteps.Show();
            comboBoxPieceSteps.Show();
            buttonMovePiece.Show();
        }

        private void buttonMovePiece_Click(object sender, EventArgs e)
        {
            Direction? directionTestVariable = GenerateDirectionEnum(comboBoxPieceDirection.Text);
            int? stepsTestVariable = GenerateStepsToInt(comboBoxPieceSteps.Text);

            if ((directionTestVariable != null) && (stepsTestVariable != null))
            {
                Direction directionParameter = (Direction)directionTestVariable;
                int stepsParameter = (int)stepsTestVariable;
                _controller.MovePiece(directionParameter, stepsParameter);
            }
        }

        public Direction? GenerateDirectionEnum(string direction)
        {
            Direction? directionEnum = null;
            switch (direction)
            {
                case "Up":
                    directionEnum = Direction.Up;
                    break;
                case "Down":
                    directionEnum = Direction.Down;
                    break;
                case "Left":
                    directionEnum = Direction.Left;
                    break;
                case "Right":
                    directionEnum = Direction.Right;
                    break;
                case "Up left":
                    directionEnum = Direction.UpLeft;
                    break;
                case "Up right":
                    directionEnum = Direction.UpRight;
                    break;
                case "Down left":
                    directionEnum = Direction.DownLeft;
                    break;
                case "Down right":
                    directionEnum = Direction.DownRight;
                    break;
                case "":
                    directionEnum = null;
                    break;
            }
            return directionEnum;
        }

        public int? GenerateStepsToInt(string steps)
        {
            int? stepsToInt = null;
            switch (steps)
            {
                case "1":
                    stepsToInt = 1;
                    break;
                case "2":
                    stepsToInt = 2;
                    break;
                case "3":
                    stepsToInt = 3;
                    break;
                case "4":
                    stepsToInt = 4;
                    break;
                case "":
                    stepsToInt = null;
                    break;
            }
            return stepsToInt;
        }

        private void buttonMoveKnight_Click(object sender, EventArgs e)
        {
            int? verticalTestVariable = GenerateVerticalToInt(comboBoxKnightVertical.Text);
            int? horizontalTestVariable = GenerateHorizontalToInt(comboBoxKnightHorizontal.Text);

            if ((verticalTestVariable != null) && (horizontalTestVariable != null))
            {
                int verticalParameter = (int)verticalTestVariable;
                int horizontalParameter = (int)horizontalTestVariable;
                _controller.MoveKnight(verticalParameter, horizontalParameter);
                // Debug.WriteLine("In the if statement.");
            }
        }

        public int? GenerateVerticalToInt(string move)
        {
            int? moveToInt = null;
            switch (move)
            {
                case "Up 1":
                    moveToInt = -1;
                    break;
                case "Up 2":
                    moveToInt = -2;
                    break;
                case "Down 1":
                    moveToInt = 1;
                    break;
                case "Down 2":
                    moveToInt = 2;
                    break;
            }
            return moveToInt;
        }

        public int? GenerateHorizontalToInt(string move)
        {
            int? moveToInt = null;
            switch (move)
            {
                case "Left 1":
                    moveToInt = -1;
                    break;
                case "Left 2":
                    moveToInt = -2;
                    break;
                case "Right 1":
                    moveToInt = 1;
                    break;
                case "Right 2":
                    moveToInt = 2;
                    break;
            }
            return moveToInt;
        }

        public void ShowWin()
        {
            labelGameWon.Show();
        }

        public void HideWin()
        {
            labelGameWon.Hide();
        }

        public void ShowInvalidMessage()
        {
            labelInvalidMove.Show();
        }

        public void HideInvalidMessage()
        {
            labelInvalidMove.Hide();
        }

        public void UpdateMoveCount(string moves)
        {
            labelActualCount.Text = moves;
        }

        

        private void buttonUndo_Click(object sender, EventArgs e)
        {
            _controller.GameUndoMove();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            _controller.RestartGame();
        }
    }
}
