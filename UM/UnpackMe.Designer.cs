
using System.Reflection;

namespace UnpackMe
{
    partial class UM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        [Obfuscation(Exclude = false, Feature = "-virt", ApplyToMembers = false)]
        private void InitializeComponent()
        {
            this.UL = new System.Windows.Forms.Label();
            this.AL = new System.Windows.Forms.Label();
            this.AAL = new System.Windows.Forms.Label();
            this.Ps = new System.Windows.Forms.TextBox();
            this.VBtn = new System.Windows.Forms.Button();
            this.ERL = new System.Windows.Forms.Label();
            this.CBtn = new System.Windows.Forms.Button();
            this.PsL = new System.Windows.Forms.TextBox();
            this.PsS = new System.Windows.Forms.TextBox();
            this.AcceptOrDie = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // UL
            // 
            this.UL.AutoSize = true;
            this.UL.ForeColor = System.Drawing.SystemColors.Window;
            this.UL.Location = new System.Drawing.Point(30, 8);
            this.UL.Name = "UL";
            this.UL.Size = new System.Drawing.Size(0, 13);
            this.UL.TabIndex = 0;
            // 
            // AL
            // 
            this.AL.AutoSize = true;
            this.AL.ForeColor = System.Drawing.SystemColors.Window;
            this.AL.Location = new System.Drawing.Point(30, 24);
            this.AL.Name = "AL";
            this.AL.Size = new System.Drawing.Size(0, 13);
            this.AL.TabIndex = 1;
            // 
            // AAL
            // 
            this.AAL.AutoSize = true;
            this.AAL.ForeColor = System.Drawing.SystemColors.Window;
            this.AAL.Location = new System.Drawing.Point(30, 42);
            this.AAL.Name = "AAL";
            this.AAL.Size = new System.Drawing.Size(0, 13);
            this.AAL.TabIndex = 2;
            // 
            // Ps
            // 
            this.Ps.Location = new System.Drawing.Point(52, 62);
            this.Ps.Name = "Ps";
            this.Ps.Size = new System.Drawing.Size(103, 20);
            this.Ps.TabIndex = 3;
            this.Ps.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Ps.TextChanged += new System.EventHandler(this.Ps_TextChanged);
            // 
            // VBtn
            // 
            this.VBtn.Location = new System.Drawing.Point(52, 87);
            this.VBtn.Name = "VBtn";
            this.VBtn.Size = new System.Drawing.Size(103, 20);
            this.VBtn.TabIndex = 4;
            this.VBtn.UseVisualStyleBackColor = true;
            this.VBtn.Click += new System.EventHandler(this.VBtn_Click);
            // 
            // ERL
            // 
            this.ERL.AutoSize = true;
            this.ERL.ForeColor = System.Drawing.SystemColors.Window;
            this.ERL.Location = new System.Drawing.Point(52, 109);
            this.ERL.Name = "ERL";
            this.ERL.Size = new System.Drawing.Size(0, 13);
            this.ERL.TabIndex = 5;
            // 
            // CBtn
            // 
            this.CBtn.BackColor = System.Drawing.SystemColors.ControlText;
            this.CBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CBtn.Location = new System.Drawing.Point(195, 17);
            this.CBtn.Name = "CBtn";
            this.CBtn.Size = new System.Drawing.Size(9, 9);
            this.CBtn.TabIndex = 6;
            this.CBtn.UseVisualStyleBackColor = false;
            this.CBtn.Click += new System.EventHandler(this.CBtn_Click);
            // 
            // PsL
            // 
            this.PsL.Enabled = false;
            this.PsL.Location = new System.Drawing.Point(161, 61);
            this.PsL.Name = "PsL";
            this.PsL.Size = new System.Drawing.Size(43, 20);
            this.PsL.TabIndex = 7;
            this.PsL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PsS
            // 
            this.PsS.Enabled = false;
            this.PsS.Location = new System.Drawing.Point(52, 134);
            this.PsS.Name = "PsS";
            this.PsS.Size = new System.Drawing.Size(103, 20);
            this.PsS.TabIndex = 8;
            this.PsS.Text = "x|x|x";
            this.PsS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AcceptOrDie
            // 
            this.AcceptOrDie.AutoSize = true;
            this.AcceptOrDie.ForeColor = System.Drawing.Color.Blue;
            this.AcceptOrDie.Location = new System.Drawing.Point(119, 41);
            this.AcceptOrDie.Name = "AcceptOrDie";
            this.AcceptOrDie.Size = new System.Drawing.Size(83, 17);
            this.AcceptOrDie.TabIndex = 9;
            this.AcceptOrDie.Text = "Accept No?";
            this.AcceptOrDie.UseVisualStyleBackColor = true;
            // 
            // UM
            // 
            this.AcceptButton = this.VBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CancelButton = this.CBtn;
            this.ClientSize = new System.Drawing.Size(213, 156);
            this.Controls.Add(this.AcceptOrDie);
            this.Controls.Add(this.PsS);
            this.Controls.Add(this.PsL);
            this.Controls.Add(this.CBtn);
            this.Controls.Add(this.ERL);
            this.Controls.Add(this.VBtn);
            this.Controls.Add(this.Ps);
            this.Controls.Add(this.AAL);
            this.Controls.Add(this.AL);
            this.Controls.Add(this.UL);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UM";
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UnpackMe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UL;
        private System.Windows.Forms.Label AL;
        private System.Windows.Forms.Label AAL;
        private System.Windows.Forms.TextBox Ps;
        private System.Windows.Forms.Button VBtn;
        private System.Windows.Forms.Label ERL;
        private System.Windows.Forms.Button CBtn;
        private System.Windows.Forms.TextBox PsL;
        private System.Windows.Forms.TextBox PsS;
        private System.Windows.Forms.CheckBox AcceptOrDie;
    }
}

