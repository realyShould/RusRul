namespace RusRul
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.numericBullets = new System.Windows.Forms.NumericUpDown();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFire = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.labelBullets = new System.Windows.Forms.Label();
            this.btnReload = new System.Windows.Forms.Button();
            this.labelStatusStatic = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.labelHscore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericBullets)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numericBullets
            // 
            this.numericBullets.Location = new System.Drawing.Point(311, 256);
            this.numericBullets.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numericBullets.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericBullets.Name = "numericBullets";
            this.numericBullets.Size = new System.Drawing.Size(36, 22);
            this.numericBullets.TabIndex = 0;
            this.numericBullets.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericBullets.ValueChanged += new System.EventHandler(this.numericBullets_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(412, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuNewGame,
            this.MenuExit});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // MenuNewGame
            // 
            this.MenuNewGame.Name = "MenuNewGame";
            this.MenuNewGame.Size = new System.Drawing.Size(132, 22);
            this.MenuNewGame.Text = "New Game";
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(132, 22);
            this.MenuExit.Text = "Exit";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // btnFire
            // 
            this.btnFire.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFire.Location = new System.Drawing.Point(304, 404);
            this.btnFire.Name = "btnFire";
            this.btnFire.Size = new System.Drawing.Size(96, 34);
            this.btnFire.TabIndex = 2;
            this.btnFire.Text = "Fire";
            this.btnFire.UseVisualStyleBackColor = true;
            this.btnFire.Click += new System.EventHandler(this.btnFire_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(325, 375);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(75, 23);
            this.btnSpin.TabIndex = 3;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // labelBullets
            // 
            this.labelBullets.AutoSize = true;
            this.labelBullets.Location = new System.Drawing.Point(353, 258);
            this.labelBullets.Name = "labelBullets";
            this.labelBullets.Size = new System.Drawing.Size(42, 13);
            this.labelBullets.TabIndex = 4;
            this.labelBullets.Text = "bullets";
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(325, 284);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 5;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // labelStatusStatic
            // 
            this.labelStatusStatic.AutoSize = true;
            this.labelStatusStatic.Location = new System.Drawing.Point(13, 28);
            this.labelStatusStatic.Name = "labelStatusStatic";
            this.labelStatusStatic.Size = new System.Drawing.Size(42, 13);
            this.labelStatusStatic.TabIndex = 6;
            this.labelStatusStatic.Text = "Status:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Location = new System.Drawing.Point(16, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(379, 200);
            this.panel1.TabIndex = 7;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Location = new System.Drawing.Point(3, 0);
            this.labelStatus.MaximumSize = new System.Drawing.Size(379, 200);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(0, 13);
            this.labelStatus.TabIndex = 0;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(19, 418);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(47, 13);
            this.labelScore.TabIndex = 8;
            this.labelScore.Text = "Score: 0";
            // 
            // labelHscore
            // 
            this.labelHscore.AutoSize = true;
            this.labelHscore.Location = new System.Drawing.Point(19, 258);
            this.labelHscore.Name = "labelHscore";
            this.labelHscore.Size = new System.Drawing.Size(79, 13);
            this.labelHscore.TabIndex = 9;
            this.labelHscore.Text = "Hight Score: 0";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.labelHscore);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelStatusStatic);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.labelBullets);
            this.Controls.Add(this.btnSpin);
            this.Controls.Add(this.btnFire);
            this.Controls.Add(this.numericBullets);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Nirmala UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Let\'s play?";
            ((System.ComponentModel.ISupportInitialize)(this.numericBullets)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericBullets;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuNewGame;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.Button btnFire;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.Label labelBullets;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label labelStatusStatic;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Label labelHscore;
    }
}

