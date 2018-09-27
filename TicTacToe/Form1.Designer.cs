namespace TicTacToe
{
    partial class Form1
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
            this.A1btn = new System.Windows.Forms.Button();
            this.A2btn = new System.Windows.Forms.Button();
            this.A3btn = new System.Windows.Forms.Button();
            this.B1btn = new System.Windows.Forms.Button();
            this.B2btn = new System.Windows.Forms.Button();
            this.B3btn = new System.Windows.Forms.Button();
            this.C1btn = new System.Windows.Forms.Button();
            this.C2btn = new System.Windows.Forms.Button();
            this.C3btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetScoreboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.x_win_countlbl = new System.Windows.Forms.Label();
            this.draw_countlbl = new System.Windows.Forms.Label();
            this.o_win_countlbl = new System.Windows.Forms.Label();
            this.newGameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // A1btn
            // 
            this.A1btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A1btn.Location = new System.Drawing.Point(15, 38);
            this.A1btn.Name = "A1btn";
            this.A1btn.Size = new System.Drawing.Size(80, 67);
            this.A1btn.TabIndex = 0;
            this.A1btn.UseVisualStyleBackColor = true;
            this.A1btn.Click += new System.EventHandler(this.button_click);
            this.A1btn.MouseEnter += new System.EventHandler(this.button_enter);
            this.A1btn.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A2btn
            // 
            this.A2btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A2btn.Location = new System.Drawing.Point(101, 38);
            this.A2btn.Name = "A2btn";
            this.A2btn.Size = new System.Drawing.Size(80, 67);
            this.A2btn.TabIndex = 1;
            this.A2btn.UseVisualStyleBackColor = true;
            this.A2btn.Click += new System.EventHandler(this.button_click);
            this.A2btn.MouseEnter += new System.EventHandler(this.button_enter);
            this.A2btn.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // A3btn
            // 
            this.A3btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.A3btn.Location = new System.Drawing.Point(187, 38);
            this.A3btn.Name = "A3btn";
            this.A3btn.Size = new System.Drawing.Size(80, 67);
            this.A3btn.TabIndex = 2;
            this.A3btn.UseVisualStyleBackColor = true;
            this.A3btn.Click += new System.EventHandler(this.button_click);
            this.A3btn.MouseEnter += new System.EventHandler(this.button_enter);
            this.A3btn.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B1btn
            // 
            this.B1btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B1btn.Location = new System.Drawing.Point(15, 111);
            this.B1btn.Name = "B1btn";
            this.B1btn.Size = new System.Drawing.Size(80, 67);
            this.B1btn.TabIndex = 3;
            this.B1btn.UseVisualStyleBackColor = true;
            this.B1btn.Click += new System.EventHandler(this.button_click);
            this.B1btn.MouseEnter += new System.EventHandler(this.button_enter);
            this.B1btn.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B2btn
            // 
            this.B2btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B2btn.Location = new System.Drawing.Point(101, 111);
            this.B2btn.Name = "B2btn";
            this.B2btn.Size = new System.Drawing.Size(80, 67);
            this.B2btn.TabIndex = 4;
            this.B2btn.UseVisualStyleBackColor = true;
            this.B2btn.Click += new System.EventHandler(this.button_click);
            this.B2btn.MouseEnter += new System.EventHandler(this.button_enter);
            this.B2btn.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // B3btn
            // 
            this.B3btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.B3btn.Location = new System.Drawing.Point(187, 111);
            this.B3btn.Name = "B3btn";
            this.B3btn.Size = new System.Drawing.Size(80, 67);
            this.B3btn.TabIndex = 5;
            this.B3btn.UseVisualStyleBackColor = true;
            this.B3btn.Click += new System.EventHandler(this.button_click);
            this.B3btn.MouseEnter += new System.EventHandler(this.button_enter);
            this.B3btn.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C1btn
            // 
            this.C1btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C1btn.Location = new System.Drawing.Point(15, 184);
            this.C1btn.Name = "C1btn";
            this.C1btn.Size = new System.Drawing.Size(80, 67);
            this.C1btn.TabIndex = 6;
            this.C1btn.UseVisualStyleBackColor = true;
            this.C1btn.Click += new System.EventHandler(this.button_click);
            this.C1btn.MouseEnter += new System.EventHandler(this.button_enter);
            this.C1btn.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C2btn
            // 
            this.C2btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C2btn.Location = new System.Drawing.Point(101, 184);
            this.C2btn.Name = "C2btn";
            this.C2btn.Size = new System.Drawing.Size(80, 67);
            this.C2btn.TabIndex = 7;
            this.C2btn.UseVisualStyleBackColor = true;
            this.C2btn.Click += new System.EventHandler(this.button_click);
            this.C2btn.MouseEnter += new System.EventHandler(this.button_enter);
            this.C2btn.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // C3btn
            // 
            this.C3btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.C3btn.Location = new System.Drawing.Point(187, 184);
            this.C3btn.Name = "C3btn";
            this.C3btn.Size = new System.Drawing.Size(80, 67);
            this.C3btn.TabIndex = 8;
            this.C3btn.UseVisualStyleBackColor = true;
            this.C3btn.Click += new System.EventHandler(this.button_click);
            this.C3btn.MouseEnter += new System.EventHandler(this.button_enter);
            this.C3btn.MouseLeave += new System.EventHandler(this.button_leave);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.newGameToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(281, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.resetScoreboardToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // resetScoreboardToolStripMenuItem
            // 
            this.resetScoreboardToolStripMenuItem.Name = "resetScoreboardToolStripMenuItem";
            this.resetScoreboardToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.resetScoreboardToolStripMenuItem.Text = "Reset Scoreboard";
            this.resetScoreboardToolStripMenuItem.Click += new System.EventHandler(this.resetScoreboardToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 281);
            this.label1.MaximumSize = new System.Drawing.Size(96, 15);
            this.label1.MinimumSize = new System.Drawing.Size(96, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "X\'s Win Count";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(114, 281);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Draws";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(171, 281);
            this.label3.MaximumSize = new System.Drawing.Size(97, 15);
            this.label3.MinimumSize = new System.Drawing.Size(97, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "O\'s Win Count";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(76, 254);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "SCOREBOARD";
            // 
            // x_win_countlbl
            // 
            this.x_win_countlbl.AutoSize = true;
            this.x_win_countlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.x_win_countlbl.Location = new System.Drawing.Point(46, 309);
            this.x_win_countlbl.Name = "x_win_countlbl";
            this.x_win_countlbl.Size = new System.Drawing.Size(15, 15);
            this.x_win_countlbl.TabIndex = 14;
            this.x_win_countlbl.Text = "0";
            // 
            // draw_countlbl
            // 
            this.draw_countlbl.AutoSize = true;
            this.draw_countlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.draw_countlbl.Location = new System.Drawing.Point(128, 309);
            this.draw_countlbl.Name = "draw_countlbl";
            this.draw_countlbl.Size = new System.Drawing.Size(15, 15);
            this.draw_countlbl.TabIndex = 15;
            this.draw_countlbl.Text = "0";
            // 
            // o_win_countlbl
            // 
            this.o_win_countlbl.AutoSize = true;
            this.o_win_countlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.o_win_countlbl.Location = new System.Drawing.Point(210, 309);
            this.o_win_countlbl.Name = "o_win_countlbl";
            this.o_win_countlbl.Size = new System.Drawing.Size(15, 15);
            this.o_win_countlbl.TabIndex = 16;
            this.o_win_countlbl.Text = "0";
            // 
            // newGameToolStripMenuItem1
            // 
            this.newGameToolStripMenuItem1.Name = "newGameToolStripMenuItem1";
            this.newGameToolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem1.Text = "New Game";
            this.newGameToolStripMenuItem1.Click += new System.EventHandler(this.newGameToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 333);
            this.Controls.Add(this.o_win_countlbl);
            this.Controls.Add(this.draw_countlbl);
            this.Controls.Add(this.x_win_countlbl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.C3btn);
            this.Controls.Add(this.C2btn);
            this.Controls.Add(this.C1btn);
            this.Controls.Add(this.B3btn);
            this.Controls.Add(this.B2btn);
            this.Controls.Add(this.B1btn);
            this.Controls.Add(this.A3btn);
            this.Controls.Add(this.A2btn);
            this.Controls.Add(this.A1btn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(297, 372);
            this.MinimumSize = new System.Drawing.Size(297, 372);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button A1btn;
        private System.Windows.Forms.Button A2btn;
        private System.Windows.Forms.Button A3btn;
        private System.Windows.Forms.Button B1btn;
        private System.Windows.Forms.Button B2btn;
        private System.Windows.Forms.Button B3btn;
        private System.Windows.Forms.Button C1btn;
        private System.Windows.Forms.Button C2btn;
        private System.Windows.Forms.Button C3btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label x_win_countlbl;
        private System.Windows.Forms.Label draw_countlbl;
        private System.Windows.Forms.Label o_win_countlbl;
        private System.Windows.Forms.ToolStripMenuItem resetScoreboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem1;
    }
}

