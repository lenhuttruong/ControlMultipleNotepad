namespace ControlMultipleNotepad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAccount = new System.Windows.Forms.Label();
            this.lbAccountSelection = new System.Windows.Forms.ListBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.chBoxSieuDo = new System.Windows.Forms.CheckBox();
            this.btnRefreshAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAccount
            // 
            this.txtAccount.AutoSize = true;
            this.txtAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccount.Location = new System.Drawing.Point(13, 13);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(62, 18);
            this.txtAccount.TabIndex = 0;
            this.txtAccount.Text = "Account";
            // 
            // lbAccountSelection
            // 
            this.lbAccountSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccountSelection.FormattingEnabled = true;
            this.lbAccountSelection.ItemHeight = 18;
            this.lbAccountSelection.Location = new System.Drawing.Point(81, 12);
            this.lbAccountSelection.Name = "lbAccountSelection";
            this.lbAccountSelection.Size = new System.Drawing.Size(139, 22);
            this.lbAccountSelection.TabIndex = 1;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(28, 235);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(126, 235);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // chBoxSieuDo
            // 
            this.chBoxSieuDo.AutoSize = true;
            this.chBoxSieuDo.Location = new System.Drawing.Point(28, 70);
            this.chBoxSieuDo.Name = "chBoxSieuDo";
            this.chBoxSieuDo.Size = new System.Drawing.Size(64, 17);
            this.chBoxSieuDo.TabIndex = 3;
            this.chBoxSieuDo.Text = "Sieu Do";
            this.chBoxSieuDo.UseVisualStyleBackColor = true;
            // 
            // btnRefreshAccount
            // 
            this.btnRefreshAccount.BackColor = System.Drawing.Color.White;
            this.btnRefreshAccount.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRefreshAccount.BackgroundImage")));
            this.btnRefreshAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRefreshAccount.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnRefreshAccount.FlatAppearance.BorderSize = 0;
            this.btnRefreshAccount.Location = new System.Drawing.Point(223, 10);
            this.btnRefreshAccount.Margin = new System.Windows.Forms.Padding(0);
            this.btnRefreshAccount.Name = "btnRefreshAccount";
            this.btnRefreshAccount.Size = new System.Drawing.Size(29, 27);
            this.btnRefreshAccount.TabIndex = 4;
            this.btnRefreshAccount.UseVisualStyleBackColor = false;
            this.btnRefreshAccount.Click += new System.EventHandler(this.btnRefreshAccount_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(255, 271);
            this.Controls.Add(this.btnRefreshAccount);
            this.Controls.Add(this.chBoxSieuDo);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbAccountSelection);
            this.Controls.Add(this.txtAccount);
            this.Name = "Form1";
            this.Text = "Control Notepad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtAccount;
        private System.Windows.Forms.ListBox lbAccountSelection;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox chBoxSieuDo;
        private System.Windows.Forms.Button btnRefreshAccount;
    }
}

