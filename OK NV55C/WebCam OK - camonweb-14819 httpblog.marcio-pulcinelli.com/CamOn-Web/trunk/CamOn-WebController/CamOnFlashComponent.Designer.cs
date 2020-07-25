namespace CamOnWebController
{
    partial class CamOnFlashComponent
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CamOnFlashComponent));
            this.flashPlayer = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.lblBorda = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGO = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.flashPlayer)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // flashPlayer
            // 
            this.flashPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flashPlayer.Enabled = true;
            this.flashPlayer.Location = new System.Drawing.Point(0, 0);
            this.flashPlayer.Name = "flashPlayer";
            this.flashPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("flashPlayer.OcxState")));
            this.flashPlayer.Size = new System.Drawing.Size(382, 306);
            this.flashPlayer.TabIndex = 0;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnMenu.Controls.Add(this.lblBorda);
            this.pnMenu.Controls.Add(this.label1);
            this.pnMenu.Controls.Add(this.btnGO);
            this.pnMenu.Controls.Add(this.txtURL);
            this.pnMenu.Location = new System.Drawing.Point(0, 0);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(315, 41);
            this.pnMenu.TabIndex = 1;
            // 
            // lblBorda
            // 
            this.lblBorda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBorda.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblBorda.ForeColor = System.Drawing.Color.White;
            this.lblBorda.Location = new System.Drawing.Point(298, 0);
            this.lblBorda.Name = "lblBorda";
            this.lblBorda.Size = new System.Drawing.Size(17, 41);
            this.lblBorda.TabIndex = 3;
            this.lblBorda.Text = ">>";
            this.lblBorda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBorda.Click += new System.EventHandler(this.lblBorda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type the video URL:";
            // 
            // btnGO
            // 
            this.btnGO.Image = global::CamOnWebController.Properties.Resources.OK;
            this.btnGO.Location = new System.Drawing.Point(272, 18);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(20, 20);
            this.btnGO.TabIndex = 1;
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(3, 18);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(267, 20);
            this.txtURL.TabIndex = 0;
            // 
            // CamOnFlashComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.flashPlayer);
            this.Name = "CamOnFlashComponent";
            this.Size = new System.Drawing.Size(382, 306);
            ((System.ComponentModel.ISupportInitialize)(this.flashPlayer)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash flashPlayer;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Label lblBorda;
    }
}
