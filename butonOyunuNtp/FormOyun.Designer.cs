namespace butonOyunuNtp
{
    partial class FormOyun
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPuan = new System.Windows.Forms.Panel();
            this.tmr_game = new System.Windows.Forms.Timer(this.components);
            this.tmr_sure = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(698, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(698, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // pnlPuan
            // 
            this.pnlPuan.BackColor = System.Drawing.SystemColors.HotTrack;
            this.pnlPuan.Location = new System.Drawing.Point(667, 0);
            this.pnlPuan.Name = "pnlPuan";
            this.pnlPuan.Size = new System.Drawing.Size(134, 450);
            this.pnlPuan.TabIndex = 2;
            // 
            // tmr_game
            // 
            this.tmr_game.Interval = 1000;
            this.tmr_game.Tick += new System.EventHandler(this.tmr_game_Tick);
            // 
            // tmr_sure
            // 
            this.tmr_sure.Interval = 1000;
            this.tmr_sure.Tick += new System.EventHandler(this.tmr_sure_Tick);
            // 
            // FormOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlPuan);
            this.Name = "FormOyun";
            this.Text = "FormOyun";
            this.Load += new System.EventHandler(this.FormOyun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnlPuan;
        private System.Windows.Forms.Timer tmr_game;
        private System.Windows.Forms.Timer tmr_sure;
    }
}