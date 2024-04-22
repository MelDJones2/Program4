namespace P04_Melvin
{
    partial class PlayerNamed
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
            this.btnSecondAdd = new System.Windows.Forms.Button();
            this.btnSecondRemove = new System.Windows.Forms.Button();
            this.btnFirstRemove = new System.Windows.Forms.Button();
            this.btnFirstAdd = new System.Windows.Forms.Button();
            this.lstBoxFirst = new System.Windows.Forms.ListBox();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.cmbBoxPlayers = new System.Windows.Forms.ComboBox();
            this.lblSecond = new System.Windows.Forms.Label();
            this.lstBoxSecond = new System.Windows.Forms.ListBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSecondAdd
            // 
            this.btnSecondAdd.Location = new System.Drawing.Point(540, 345);
            this.btnSecondAdd.Name = "btnSecondAdd";
            this.btnSecondAdd.Size = new System.Drawing.Size(75, 23);
            this.btnSecondAdd.TabIndex = 0;
            this.btnSecondAdd.Text = "Add";
            this.btnSecondAdd.UseVisualStyleBackColor = true;
            this.btnSecondAdd.Click += new System.EventHandler(this.btnSecondAdd_Click);
            // 
            // btnSecondRemove
            // 
            this.btnSecondRemove.Location = new System.Drawing.Point(540, 383);
            this.btnSecondRemove.Name = "btnSecondRemove";
            this.btnSecondRemove.Size = new System.Drawing.Size(75, 23);
            this.btnSecondRemove.TabIndex = 1;
            this.btnSecondRemove.Text = "Remove";
            this.btnSecondRemove.UseVisualStyleBackColor = true;
            this.btnSecondRemove.Click += new System.EventHandler(this.btnSecondRemove_Click);
            // 
            // btnFirstRemove
            // 
            this.btnFirstRemove.Location = new System.Drawing.Point(179, 383);
            this.btnFirstRemove.Name = "btnFirstRemove";
            this.btnFirstRemove.Size = new System.Drawing.Size(75, 23);
            this.btnFirstRemove.TabIndex = 2;
            this.btnFirstRemove.Text = "Remove";
            this.btnFirstRemove.UseVisualStyleBackColor = true;
            this.btnFirstRemove.Click += new System.EventHandler(this.btnFirstRemove_Click);
            // 
            // btnFirstAdd
            // 
            this.btnFirstAdd.Location = new System.Drawing.Point(179, 345);
            this.btnFirstAdd.Name = "btnFirstAdd";
            this.btnFirstAdd.Size = new System.Drawing.Size(75, 23);
            this.btnFirstAdd.TabIndex = 3;
            this.btnFirstAdd.Text = "Add";
            this.btnFirstAdd.UseVisualStyleBackColor = true;
            this.btnFirstAdd.Click += new System.EventHandler(this.btnFirstAdd_Click);
            // 
            // lstBoxFirst
            // 
            this.lstBoxFirst.FormattingEnabled = true;
            this.lstBoxFirst.ItemHeight = 16;
            this.lstBoxFirst.Location = new System.Drawing.Point(160, 194);
            this.lstBoxFirst.Name = "lstBoxFirst";
            this.lstBoxFirst.Size = new System.Drawing.Size(125, 132);
            this.lstBoxFirst.TabIndex = 5;
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(183, 175);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(71, 16);
            this.lblFirst.TabIndex = 7;
            this.lblFirst.Text = "First Team";
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Location = new System.Drawing.Point(368, 45);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(53, 16);
            this.lblPlayers.TabIndex = 8;
            this.lblPlayers.Text = "Players";
            // 
            // cmbBoxPlayers
            // 
            this.cmbBoxPlayers.FormattingEnabled = true;
            this.cmbBoxPlayers.Location = new System.Drawing.Point(332, 64);
            this.cmbBoxPlayers.Name = "cmbBoxPlayers";
            this.cmbBoxPlayers.Size = new System.Drawing.Size(121, 24);
            this.cmbBoxPlayers.TabIndex = 9;
            this.cmbBoxPlayers.SelectedIndexChanged += new System.EventHandler(this.cmbBoxPlayers_SelectedIndexChanged);
            this.cmbBoxPlayers.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbBoxPlayers_KeyPress);
            // 
            // lblSecond
            // 
            this.lblSecond.AutoSize = true;
            this.lblSecond.Location = new System.Drawing.Point(522, 175);
            this.lblSecond.Name = "lblSecond";
            this.lblSecond.Size = new System.Drawing.Size(93, 16);
            this.lblSecond.TabIndex = 10;
            this.lblSecond.Text = "Second Team";
            // 
            // lstBoxSecond
            // 
            this.lstBoxSecond.FormattingEnabled = true;
            this.lstBoxSecond.ItemHeight = 16;
            this.lstBoxSecond.Location = new System.Drawing.Point(510, 194);
            this.lstBoxSecond.Name = "lstBoxSecond";
            this.lstBoxSecond.Size = new System.Drawing.Size(135, 132);
            this.lstBoxSecond.TabIndex = 11;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(358, 133);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(75, 23);
            this.btnRestart.TabIndex = 12;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // PlayerNamed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.lstBoxSecond);
            this.Controls.Add(this.lblSecond);
            this.Controls.Add(this.cmbBoxPlayers);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lstBoxFirst);
            this.Controls.Add(this.btnFirstAdd);
            this.Controls.Add(this.btnFirstRemove);
            this.Controls.Add(this.btnSecondRemove);
            this.Controls.Add(this.btnSecondAdd);
            this.Name = "PlayerNamed";
            this.Text = "Teams!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSecondAdd;
        private System.Windows.Forms.Button btnSecondRemove;
        private System.Windows.Forms.Button btnFirstRemove;
        private System.Windows.Forms.Button btnFirstAdd;
        private System.Windows.Forms.ListBox lstBoxFirst;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.ComboBox cmbBoxPlayers;
        private System.Windows.Forms.Label lblSecond;
        private System.Windows.Forms.ListBox lstBoxSecond;
        private System.Windows.Forms.Button btnRestart;
    }
}

