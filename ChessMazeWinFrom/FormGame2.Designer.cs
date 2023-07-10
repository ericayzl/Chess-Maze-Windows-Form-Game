
namespace ChessMazeWinFrom
{
    partial class FormGame2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.buttonUndo = new System.Windows.Forms.Button();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelInvalidMove = new System.Windows.Forms.Label();
            this.labelGameWon = new System.Windows.Forms.Label();
            this.labelActualCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPiece = new System.Windows.Forms.Label();
            this.buttonLoad = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.button33 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button30 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button03 = new System.Windows.Forms.Button();
            this.button00 = new System.Windows.Forms.Button();
            this.button01 = new System.Windows.Forms.Button();
            this.button02 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.labelDirection = new System.Windows.Forms.Label();
            this.comboBoxPieceDirection = new System.Windows.Forms.ComboBox();
            this.labelSteps = new System.Windows.Forms.Label();
            this.comboBoxPieceSteps = new System.Windows.Forms.ComboBox();
            this.buttonMovePiece = new System.Windows.Forms.Button();
            this.labelKnight = new System.Windows.Forms.Label();
            this.labelVertical = new System.Windows.Forms.Label();
            this.comboBoxKnightVertical = new System.Windows.Forms.ComboBox();
            this.labelHorizontal = new System.Windows.Forms.Label();
            this.buttonMoveKnight = new System.Windows.Forms.Button();
            this.comboBoxKnightHorizontal = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 54);
            this.label2.TabIndex = 41;
            this.label2.Text = "Chess Maze Game II";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonUndo
            // 
            this.buttonUndo.Location = new System.Drawing.Point(104, 445);
            this.buttonUndo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUndo.Name = "buttonUndo";
            this.buttonUndo.Size = new System.Drawing.Size(59, 27);
            this.buttonUndo.TabIndex = 40;
            this.buttonUndo.Text = "Undo";
            this.buttonUndo.UseVisualStyleBackColor = true;
            this.buttonUndo.Click += new System.EventHandler(this.buttonUndo_Click);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Location = new System.Drawing.Point(104, 480);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(59, 27);
            this.buttonRestart.TabIndex = 39;
            this.buttonRestart.Text = "Restart";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
            // 
            // labelInvalidMove
            // 
            this.labelInvalidMove.BackColor = System.Drawing.Color.Pink;
            this.labelInvalidMove.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInvalidMove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvalidMove.Location = new System.Drawing.Point(467, 28);
            this.labelInvalidMove.Name = "labelInvalidMove";
            this.labelInvalidMove.Size = new System.Drawing.Size(100, 32);
            this.labelInvalidMove.TabIndex = 38;
            this.labelInvalidMove.Text = "Invalid move!";
            this.labelInvalidMove.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelInvalidMove.Click += new System.EventHandler(this.labelInvalidMove_Click);
            // 
            // labelGameWon
            // 
            this.labelGameWon.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.labelGameWon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelGameWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGameWon.Location = new System.Drawing.Point(74, 232);
            this.labelGameWon.Name = "labelGameWon";
            this.labelGameWon.Size = new System.Drawing.Size(120, 59);
            this.labelGameWon.TabIndex = 37;
            this.labelGameWon.Text = "You have won! Congratualtions!";
            this.labelGameWon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelActualCount
            // 
            this.labelActualCount.BackColor = System.Drawing.Color.White;
            this.labelActualCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelActualCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelActualCount.Location = new System.Drawing.Point(153, 348);
            this.labelActualCount.Name = "labelActualCount";
            this.labelActualCount.Size = new System.Drawing.Size(60, 30);
            this.labelActualCount.TabIndex = 36;
            this.labelActualCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Move Count";
            // 
            // labelPiece
            // 
            this.labelPiece.AutoSize = true;
            this.labelPiece.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPiece.Location = new System.Drawing.Point(807, 85);
            this.labelPiece.Name = "labelPiece";
            this.labelPiece.Size = new System.Drawing.Size(101, 18);
            this.labelPiece.TabIndex = 23;
            this.labelPiece.Text = "Move Piece:";
            // 
            // buttonLoad
            // 
            this.buttonLoad.Location = new System.Drawing.Point(104, 410);
            this.buttonLoad.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoad.Name = "buttonLoad";
            this.buttonLoad.Size = new System.Drawing.Size(59, 27);
            this.buttonLoad.TabIndex = 22;
            this.buttonLoad.Text = "Load";
            this.buttonLoad.UseVisualStyleBackColor = true;
            this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.button33, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.button32, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.button31, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.button30, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.button23, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.button13, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.button03, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button00, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button01, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button02, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.button10, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button11, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button12, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.button20, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.button21, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.button22, 2, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(299, 85);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(424, 439);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // button33
            // 
            this.button33.BackColor = System.Drawing.Color.White;
            this.button33.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button33.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button33.FlatAppearance.BorderSize = 0;
            this.button33.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button33.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button33.Location = new System.Drawing.Point(319, 331);
            this.button33.Margin = new System.Windows.Forms.Padding(2);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(101, 104);
            this.button33.TabIndex = 15;
            this.button33.UseVisualStyleBackColor = false;
            // 
            // button32
            // 
            this.button32.BackColor = System.Drawing.Color.White;
            this.button32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button32.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button32.FlatAppearance.BorderSize = 0;
            this.button32.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button32.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button32.Location = new System.Drawing.Point(214, 331);
            this.button32.Margin = new System.Windows.Forms.Padding(2);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(99, 104);
            this.button32.TabIndex = 14;
            this.button32.UseVisualStyleBackColor = false;
            // 
            // button31
            // 
            this.button31.BackColor = System.Drawing.Color.White;
            this.button31.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button31.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button31.FlatAppearance.BorderSize = 0;
            this.button31.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button31.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button31.Location = new System.Drawing.Point(109, 331);
            this.button31.Margin = new System.Windows.Forms.Padding(2);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(99, 104);
            this.button31.TabIndex = 13;
            this.button31.UseVisualStyleBackColor = false;
            // 
            // button30
            // 
            this.button30.BackColor = System.Drawing.Color.White;
            this.button30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button30.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button30.FlatAppearance.BorderSize = 0;
            this.button30.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button30.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button30.Location = new System.Drawing.Point(4, 331);
            this.button30.Margin = new System.Windows.Forms.Padding(2);
            this.button30.Name = "button30";
            this.button30.Size = new System.Drawing.Size(99, 104);
            this.button30.TabIndex = 12;
            this.button30.UseVisualStyleBackColor = false;
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.White;
            this.button23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button23.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button23.FlatAppearance.BorderSize = 0;
            this.button23.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button23.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button23.Location = new System.Drawing.Point(319, 222);
            this.button23.Margin = new System.Windows.Forms.Padding(2);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(101, 103);
            this.button23.TabIndex = 11;
            this.button23.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.White;
            this.button13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button13.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(319, 113);
            this.button13.Margin = new System.Windows.Forms.Padding(2);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(101, 103);
            this.button13.TabIndex = 10;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button03
            // 
            this.button03.BackColor = System.Drawing.Color.White;
            this.button03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button03.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button03.FlatAppearance.BorderSize = 0;
            this.button03.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button03.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button03.Location = new System.Drawing.Point(319, 4);
            this.button03.Margin = new System.Windows.Forms.Padding(2);
            this.button03.Name = "button03";
            this.button03.Size = new System.Drawing.Size(101, 103);
            this.button03.TabIndex = 9;
            this.button03.UseVisualStyleBackColor = false;
            // 
            // button00
            // 
            this.button00.BackColor = System.Drawing.Color.White;
            this.button00.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button00.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button00.FlatAppearance.BorderSize = 0;
            this.button00.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button00.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button00.Location = new System.Drawing.Point(4, 4);
            this.button00.Margin = new System.Windows.Forms.Padding(2);
            this.button00.Name = "button00";
            this.button00.Size = new System.Drawing.Size(99, 103);
            this.button00.TabIndex = 0;
            this.button00.UseVisualStyleBackColor = false;
            // 
            // button01
            // 
            this.button01.BackColor = System.Drawing.Color.White;
            this.button01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button01.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button01.FlatAppearance.BorderSize = 0;
            this.button01.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button01.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button01.Location = new System.Drawing.Point(109, 4);
            this.button01.Margin = new System.Windows.Forms.Padding(2);
            this.button01.Name = "button01";
            this.button01.Size = new System.Drawing.Size(99, 103);
            this.button01.TabIndex = 1;
            this.button01.UseVisualStyleBackColor = false;
            // 
            // button02
            // 
            this.button02.BackColor = System.Drawing.Color.White;
            this.button02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button02.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button02.FlatAppearance.BorderSize = 0;
            this.button02.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button02.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button02.Location = new System.Drawing.Point(214, 4);
            this.button02.Margin = new System.Windows.Forms.Padding(2);
            this.button02.Name = "button02";
            this.button02.Size = new System.Drawing.Size(99, 103);
            this.button02.TabIndex = 2;
            this.button02.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.White;
            this.button10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Location = new System.Drawing.Point(4, 113);
            this.button10.Margin = new System.Windows.Forms.Padding(2);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(99, 103);
            this.button10.TabIndex = 3;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.White;
            this.button11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button11.FlatAppearance.BorderSize = 0;
            this.button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button11.Location = new System.Drawing.Point(109, 113);
            this.button11.Margin = new System.Windows.Forms.Padding(2);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(99, 103);
            this.button11.TabIndex = 4;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.White;
            this.button12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button12.FlatAppearance.BorderSize = 0;
            this.button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button12.Location = new System.Drawing.Point(214, 113);
            this.button12.Margin = new System.Windows.Forms.Padding(2);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(99, 103);
            this.button12.TabIndex = 5;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.White;
            this.button20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button20.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(4, 222);
            this.button20.Margin = new System.Windows.Forms.Padding(2);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(99, 103);
            this.button20.TabIndex = 6;
            this.button20.UseVisualStyleBackColor = false;
            // 
            // button21
            // 
            this.button21.BackColor = System.Drawing.Color.White;
            this.button21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button21.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button21.FlatAppearance.BorderSize = 0;
            this.button21.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button21.Location = new System.Drawing.Point(109, 222);
            this.button21.Margin = new System.Windows.Forms.Padding(2);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(99, 103);
            this.button21.TabIndex = 7;
            this.button21.UseVisualStyleBackColor = false;
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.White;
            this.button22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button22.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button22.FlatAppearance.BorderSize = 0;
            this.button22.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button22.Location = new System.Drawing.Point(214, 222);
            this.button22.Margin = new System.Windows.Forms.Padding(2);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(99, 103);
            this.button22.TabIndex = 8;
            this.button22.UseVisualStyleBackColor = false;
            // 
            // labelDirection
            // 
            this.labelDirection.AutoSize = true;
            this.labelDirection.Location = new System.Drawing.Point(807, 123);
            this.labelDirection.Name = "labelDirection";
            this.labelDirection.Size = new System.Drawing.Size(52, 13);
            this.labelDirection.TabIndex = 42;
            this.labelDirection.Text = "Direction:";
            // 
            // comboBoxPieceDirection
            // 
            this.comboBoxPieceDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPieceDirection.FormattingEnabled = true;
            this.comboBoxPieceDirection.Items.AddRange(new object[] {
            "Up",
            "Down",
            "Left",
            "Right",
            "Up left",
            "Up right",
            "Down left",
            "Down right"});
            this.comboBoxPieceDirection.Location = new System.Drawing.Point(810, 149);
            this.comboBoxPieceDirection.Name = "comboBoxPieceDirection";
            this.comboBoxPieceDirection.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPieceDirection.TabIndex = 43;
            // 
            // labelSteps
            // 
            this.labelSteps.AutoSize = true;
            this.labelSteps.Location = new System.Drawing.Point(807, 185);
            this.labelSteps.Name = "labelSteps";
            this.labelSteps.Size = new System.Drawing.Size(37, 13);
            this.labelSteps.TabIndex = 44;
            this.labelSteps.Text = "Steps:";
            // 
            // comboBoxPieceSteps
            // 
            this.comboBoxPieceSteps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPieceSteps.FormattingEnabled = true;
            this.comboBoxPieceSteps.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBoxPieceSteps.Location = new System.Drawing.Point(810, 211);
            this.comboBoxPieceSteps.Name = "comboBoxPieceSteps";
            this.comboBoxPieceSteps.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPieceSteps.TabIndex = 45;
            // 
            // buttonMovePiece
            // 
            this.buttonMovePiece.Location = new System.Drawing.Point(810, 250);
            this.buttonMovePiece.Name = "buttonMovePiece";
            this.buttonMovePiece.Size = new System.Drawing.Size(34, 24);
            this.buttonMovePiece.TabIndex = 46;
            this.buttonMovePiece.Text = "Go";
            this.buttonMovePiece.UseVisualStyleBackColor = true;
            this.buttonMovePiece.Click += new System.EventHandler(this.buttonMovePiece_Click);
            // 
            // labelKnight
            // 
            this.labelKnight.AutoSize = true;
            this.labelKnight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKnight.Location = new System.Drawing.Point(807, 323);
            this.labelKnight.Name = "labelKnight";
            this.labelKnight.Size = new System.Drawing.Size(106, 18);
            this.labelKnight.TabIndex = 47;
            this.labelKnight.Text = "Move Knight:";
            // 
            // labelVertical
            // 
            this.labelVertical.AutoSize = true;
            this.labelVertical.Location = new System.Drawing.Point(807, 361);
            this.labelVertical.Name = "labelVertical";
            this.labelVertical.Size = new System.Drawing.Size(90, 13);
            this.labelVertical.TabIndex = 48;
            this.labelVertical.Text = "Vertical Direction:";
            // 
            // comboBoxKnightVertical
            // 
            this.comboBoxKnightVertical.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKnightVertical.FormattingEnabled = true;
            this.comboBoxKnightVertical.Items.AddRange(new object[] {
            "Up 1",
            "Up 2",
            "Down 1",
            "Down 2"});
            this.comboBoxKnightVertical.Location = new System.Drawing.Point(810, 387);
            this.comboBoxKnightVertical.Name = "comboBoxKnightVertical";
            this.comboBoxKnightVertical.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKnightVertical.TabIndex = 49;
            // 
            // labelHorizontal
            // 
            this.labelHorizontal.AutoSize = true;
            this.labelHorizontal.Location = new System.Drawing.Point(807, 424);
            this.labelHorizontal.Name = "labelHorizontal";
            this.labelHorizontal.Size = new System.Drawing.Size(102, 13);
            this.labelHorizontal.TabIndex = 50;
            this.labelHorizontal.Text = "Horizontal Direction:";
            // 
            // buttonMoveKnight
            // 
            this.buttonMoveKnight.Location = new System.Drawing.Point(809, 489);
            this.buttonMoveKnight.Name = "buttonMoveKnight";
            this.buttonMoveKnight.Size = new System.Drawing.Size(34, 24);
            this.buttonMoveKnight.TabIndex = 52;
            this.buttonMoveKnight.Text = "Go";
            this.buttonMoveKnight.UseVisualStyleBackColor = true;
            this.buttonMoveKnight.Click += new System.EventHandler(this.buttonMoveKnight_Click);
            // 
            // comboBoxKnightHorizontal
            // 
            this.comboBoxKnightHorizontal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxKnightHorizontal.FormattingEnabled = true;
            this.comboBoxKnightHorizontal.Items.AddRange(new object[] {
            "Right 1",
            "Right 2",
            "Left 1",
            "Left 2"});
            this.comboBoxKnightHorizontal.Location = new System.Drawing.Point(809, 450);
            this.comboBoxKnightHorizontal.Name = "comboBoxKnightHorizontal";
            this.comboBoxKnightHorizontal.Size = new System.Drawing.Size(121, 21);
            this.comboBoxKnightHorizontal.TabIndex = 51;
            // 
            // FormGame2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 595);
            this.Controls.Add(this.buttonMoveKnight);
            this.Controls.Add(this.comboBoxKnightHorizontal);
            this.Controls.Add(this.labelHorizontal);
            this.Controls.Add(this.comboBoxKnightVertical);
            this.Controls.Add(this.labelVertical);
            this.Controls.Add(this.labelKnight);
            this.Controls.Add(this.buttonMovePiece);
            this.Controls.Add(this.comboBoxPieceSteps);
            this.Controls.Add(this.labelSteps);
            this.Controls.Add(this.comboBoxPieceDirection);
            this.Controls.Add(this.labelDirection);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonUndo);
            this.Controls.Add(this.buttonRestart);
            this.Controls.Add(this.labelInvalidMove);
            this.Controls.Add(this.labelGameWon);
            this.Controls.Add(this.labelActualCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPiece);
            this.Controls.Add(this.buttonLoad);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormGame2";
            this.Text = "4 x 4 Game A";
            this.Load += new System.EventHandler(this.FormGame2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonUndo;
        private System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.Label labelInvalidMove;
        private System.Windows.Forms.Label labelGameWon;
        private System.Windows.Forms.Label labelActualCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPiece;
        private System.Windows.Forms.Button buttonLoad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button00;
        private System.Windows.Forms.Button button01;
        private System.Windows.Forms.Button button02;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Label labelDirection;
        private System.Windows.Forms.ComboBox comboBoxPieceDirection;
        private System.Windows.Forms.Label labelSteps;
        private System.Windows.Forms.ComboBox comboBoxPieceSteps;
        private System.Windows.Forms.Button buttonMovePiece;
        private System.Windows.Forms.Label labelKnight;
        private System.Windows.Forms.Label labelVertical;
        private System.Windows.Forms.ComboBox comboBoxKnightVertical;
        private System.Windows.Forms.Label labelHorizontal;
        private System.Windows.Forms.Button buttonMoveKnight;
        private System.Windows.Forms.ComboBox comboBoxKnightHorizontal;
        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button30;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button03;
    }
}