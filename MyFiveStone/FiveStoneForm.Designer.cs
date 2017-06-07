namespace MyFiveStone
{
    partial class FiveStoneForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.historylist = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.white = new System.Windows.Forms.Label();
            this.black = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Game = new System.Windows.Forms.ToolStripMenuItem();
            this.NewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.Retract_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.PersonFirst = new System.Windows.Forms.ToolStripMenuItem();
            this.PCFirst = new System.Windows.Forms.ToolStripMenuItem();
            this.LevelChoseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Easy = new System.Windows.Forms.ToolStripMenuItem();
            this.Hard = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Help_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Rule_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.historylist);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox2.Location = new System.Drawing.Point(646, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(186, 385);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "历史信息";
            // 
            // historylist
            // 
            this.historylist.FormattingEnabled = true;
            this.historylist.ItemHeight = 12;
            this.historylist.Location = new System.Drawing.Point(0, 21);
            this.historylist.Name = "historylist";
            this.historylist.Size = new System.Drawing.Size(180, 352);
            this.historylist.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.white);
            this.groupBox3.Controls.Add(this.black);
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox3.Location = new System.Drawing.Point(646, 419);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(186, 100);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "玩家信息";
            // 
            // white
            // 
            this.white.AutoSize = true;
            this.white.Location = new System.Drawing.Point(119, 72);
            this.white.Name = "white";
            this.white.Size = new System.Drawing.Size(41, 12);
            this.white.TabIndex = 2;
            this.white.Text = "计算机";
            // 
            // black
            // 
            this.black.AutoSize = true;
            this.black.Location = new System.Drawing.Point(34, 72);
            this.black.Name = "black";
            this.black.Size = new System.Drawing.Size(29, 12);
            this.black.TabIndex = 2;
            this.black.Text = "玩家";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MyFiveStone.Properties.Resources.white;
            this.pictureBox2.Location = new System.Drawing.Point(112, 21);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MyFiveStone.Properties.Resources.black;
            this.pictureBox1.Location = new System.Drawing.Point(26, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.groupBox4.Location = new System.Drawing.Point(646, 525);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(186, 97);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "落子点";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(32, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "X：0 Y：0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "1";
            this.label2.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Game,
            this.Help_ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(844, 25);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Game
            // 
            this.Game.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewGame,
            this.Retract_ToolStripMenuItem,
            this.ChangeColor,
            this.LevelChoseToolStripMenuItem,
            this.Exit});
            this.Game.Name = "Game";
            this.Game.Size = new System.Drawing.Size(44, 21);
            this.Game.Text = "游戏";
            // 
            // NewGame
            // 
            this.NewGame.Name = "NewGame";
            this.NewGame.Size = new System.Drawing.Size(152, 22);
            this.NewGame.Text = "新游戏";
            this.NewGame.Click += new System.EventHandler(this.NewGame_ToolStripMenuItem_Click_1);
            // 
            // Retract_ToolStripMenuItem
            // 
            this.Retract_ToolStripMenuItem.Name = "Retract_ToolStripMenuItem";
            this.Retract_ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.Retract_ToolStripMenuItem.Text = "悔棋";
            this.Retract_ToolStripMenuItem.Click += new System.EventHandler(this.Retract_ToolStripMenuItem_Click);
            // 
            // ChangeColor
            // 
            this.ChangeColor.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PersonFirst,
            this.PCFirst});
            this.ChangeColor.Name = "ChangeColor";
            this.ChangeColor.Size = new System.Drawing.Size(152, 22);
            this.ChangeColor.Text = "切换选手";
            // 
            // PersonFirst
            // 
            this.PersonFirst.Checked = true;
            this.PersonFirst.CheckState = System.Windows.Forms.CheckState.Checked;
            this.PersonFirst.Name = "PersonFirst";
            this.PersonFirst.Size = new System.Drawing.Size(152, 22);
            this.PersonFirst.Text = "玩家先";
            this.PersonFirst.Click += new System.EventHandler(this.PersonFirst_ToolStripMenuItem_Click);
            // 
            // PCFirst
            // 
            this.PCFirst.Name = "PCFirst";
            this.PCFirst.Size = new System.Drawing.Size(152, 22);
            this.PCFirst.Text = "电脑先";
            this.PCFirst.Click += new System.EventHandler(this.PCFirst_ToolStripMenuItem_Click);
            // 
            // LevelChoseToolStripMenuItem
            // 
            this.LevelChoseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Easy,
            this.Hard});
            this.LevelChoseToolStripMenuItem.Name = "LevelChoseToolStripMenuItem";
            this.LevelChoseToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.LevelChoseToolStripMenuItem.Text = "难度选择";
            // 
            // Easy
            // 
            this.Easy.Checked = true;
            this.Easy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Easy.Name = "Easy";
            this.Easy.Size = new System.Drawing.Size(152, 22);
            this.Easy.Text = "简单";
            this.Easy.Click += new System.EventHandler(this.Easy_ToolStripMenuItem_Click);
            // 
            // Hard
            // 
            this.Hard.Name = "Hard";
            this.Hard.Size = new System.Drawing.Size(152, 22);
            this.Hard.Text = "困难";
            this.Hard.Click += new System.EventHandler(this.Hard_ToolStripMenuItem_Click);
            // 
            // Exit
            // 
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(152, 22);
            this.Exit.Text = "退出";
            this.Exit.Click += new System.EventHandler(this.Exit_ToolStripMenuItem_Click);
            // 
            // Help_ToolStripMenuItem
            // 
            this.Help_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Rule_ToolStripMenuItem});
            this.Help_ToolStripMenuItem.Name = "Help_ToolStripMenuItem";
            this.Help_ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.Help_ToolStripMenuItem.Text = "帮助";
            // 
            // Rule_ToolStripMenuItem
            // 
            this.Rule_ToolStripMenuItem.Name = "Rule_ToolStripMenuItem";
            this.Rule_ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.Rule_ToolStripMenuItem.Text = "规则";
            this.Rule_ToolStripMenuItem.Click += new System.EventHandler(this.Rule_ToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 629);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(844, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(97, 17);
            this.toolStripStatusLabel1.Text = "落子点：X 0 Y 0";
            // 
            // FiveStoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 651);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FiveStoneForm";
            this.Text = "五子棋";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox historylist;
        private System.Windows.Forms.Label white;
        private System.Windows.Forms.Label black;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Game;
        private System.Windows.Forms.ToolStripMenuItem NewGame;
        private System.Windows.Forms.ToolStripMenuItem ChangeColor;
        private System.Windows.Forms.ToolStripMenuItem PersonFirst;
        private System.Windows.Forms.ToolStripMenuItem PCFirst;
        private System.Windows.Forms.ToolStripMenuItem Exit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem Help_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Rule_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LevelChoseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Easy;
        private System.Windows.Forms.ToolStripMenuItem Hard;
        private System.Windows.Forms.ToolStripMenuItem Retract_ToolStripMenuItem;
    }
}

