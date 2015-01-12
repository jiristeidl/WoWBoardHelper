namespace WoWBoardHelper
{
    partial class StartScreen
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
            this.numberOfPlayers = new System.Windows.Forms.NumericUpDown();
            this.choosePlayers = new System.Windows.Forms.Label();
            this.startGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPlayers)).BeginInit();
            this.SuspendLayout();
            // 
            // numberOfPlayers
            // 
            this.numberOfPlayers.Location = new System.Drawing.Point(222, 152);
            this.numberOfPlayers.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.numberOfPlayers.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numberOfPlayers.Name = "numberOfPlayers";
            this.numberOfPlayers.Size = new System.Drawing.Size(120, 20);
            this.numberOfPlayers.TabIndex = 0;
            this.numberOfPlayers.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // choosePlayers
            // 
            this.choosePlayers.AutoSize = true;
            this.choosePlayers.Location = new System.Drawing.Point(71, 152);
            this.choosePlayers.Name = "choosePlayers";
            this.choosePlayers.Size = new System.Drawing.Size(35, 13);
            this.choosePlayers.TabIndex = 1;
            this.choosePlayers.Text = "label1";
            // 
            // startGame
            // 
            this.startGame.Cursor = System.Windows.Forms.Cursors.Cross;
            this.startGame.Location = new System.Drawing.Point(124, 205);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(131, 73);
            this.startGame.TabIndex = 2;
            this.startGame.Text = "startGame";
            this.startGame.UseVisualStyleBackColor = true;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // StartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 378);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.choosePlayers);
            this.Controls.Add(this.numberOfPlayers);
            this.Name = "StartScreen";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numberOfPlayers;
        private System.Windows.Forms.Label choosePlayers;
        private System.Windows.Forms.Button startGame;
    }
}

