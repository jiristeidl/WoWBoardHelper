namespace WoWBoardHelper
{
    partial class ClassSelect
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
            this.Title = new System.Windows.Forms.Label();
            this.ClassSelectDropdown = new System.Windows.Forms.ComboBox();
            this.SelectClassBtn = new System.Windows.Forms.Button();
            this.SideSelectDropdown = new System.Windows.Forms.ComboBox();
            this.ClassSelectLabel = new System.Windows.Forms.Label();
            this.SideSelectLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(180, 20);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(268, 31);
            this.Title.TabIndex = 0;
            this.Title.Text = "Choose Class Player";
            this.Title.UseWaitCursor = true;
            // 
            // ClassSelectDropdown
            // 
            this.ClassSelectDropdown.DisplayMember = "Shaman";
            this.ClassSelectDropdown.FormattingEnabled = true;
            this.ClassSelectDropdown.Location = new System.Drawing.Point(281, 69);
            this.ClassSelectDropdown.Name = "ClassSelectDropdown";
            this.ClassSelectDropdown.Size = new System.Drawing.Size(199, 21);
            this.ClassSelectDropdown.Sorted = true;
            this.ClassSelectDropdown.TabIndex = 1;
            this.ClassSelectDropdown.ValueMember = "Shaman";
            // 
            // SelectClassBtn
            // 
            this.SelectClassBtn.Location = new System.Drawing.Point(281, 177);
            this.SelectClassBtn.Name = "SelectClassBtn";
            this.SelectClassBtn.Size = new System.Drawing.Size(199, 45);
            this.SelectClassBtn.TabIndex = 2;
            this.SelectClassBtn.Text = "Select Class";
            this.SelectClassBtn.UseVisualStyleBackColor = true;
            this.SelectClassBtn.Click += new System.EventHandler(this.SelectClassBtn_Click);
            // 
            // SideSelectDropdown
            // 
            this.SideSelectDropdown.FormattingEnabled = true;
            this.SideSelectDropdown.Location = new System.Drawing.Point(281, 96);
            this.SideSelectDropdown.Name = "SideSelectDropdown";
            this.SideSelectDropdown.Size = new System.Drawing.Size(199, 21);
            this.SideSelectDropdown.TabIndex = 3;
            // 
            // ClassSelectLabel
            // 
            this.ClassSelectLabel.AutoSize = true;
            this.ClassSelectLabel.Location = new System.Drawing.Point(210, 72);
            this.ClassSelectLabel.Name = "ClassSelectLabel";
            this.ClassSelectLabel.Size = new System.Drawing.Size(35, 13);
            this.ClassSelectLabel.TabIndex = 5;
            this.ClassSelectLabel.Text = "label1";
            // 
            // SideSelectLabel
            // 
            this.SideSelectLabel.AutoSize = true;
            this.SideSelectLabel.Location = new System.Drawing.Point(210, 99);
            this.SideSelectLabel.Name = "SideSelectLabel";
            this.SideSelectLabel.Size = new System.Drawing.Size(35, 13);
            this.SideSelectLabel.TabIndex = 6;
            this.SideSelectLabel.Text = "label2";
            // 
            // ClassSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 247);
            this.Controls.Add(this.SideSelectLabel);
            this.Controls.Add(this.ClassSelectLabel);
            this.Controls.Add(this.SideSelectDropdown);
            this.Controls.Add(this.SelectClassBtn);
            this.Controls.Add(this.ClassSelectDropdown);
            this.Controls.Add(this.Title);
            this.Name = "ClassSelect";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.ClassSelect_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ComboBox ClassSelectDropdown;
        private System.Windows.Forms.Button SelectClassBtn;
        private System.Windows.Forms.ComboBox SideSelectDropdown;
        private System.Windows.Forms.Label ClassSelectLabel;
        private System.Windows.Forms.Label SideSelectLabel;
    }
}