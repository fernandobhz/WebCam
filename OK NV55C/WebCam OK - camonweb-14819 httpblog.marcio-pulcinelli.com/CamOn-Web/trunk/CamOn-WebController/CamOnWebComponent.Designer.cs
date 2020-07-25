using System.Windows.Forms;
namespace CamOnWebController
{
    partial class CamOnWebComponent
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CamOnWebComponent));
            this.ImgWebCamShow = new System.Windows.Forms.PictureBox();
            this.tmrRefrashFrame = new System.Windows.Forms.Timer(this.components);
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnSalvarConfig = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBorda = new System.Windows.Forms.Label();
            this.cboDriver = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImgWebCamShow)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImgWebCamShow
            // 
            resources.ApplyResources(this.ImgWebCamShow, "ImgWebCamShow");
            this.ImgWebCamShow.Image = global::CamOnWebController.Properties.Resources.CamOnWeb;
            this.ImgWebCamShow.InitialImage = global::CamOnWebController.Properties.Resources.CamOnWeb;
            this.ImgWebCamShow.Name = "ImgWebCamShow";
            this.ImgWebCamShow.TabStop = false;
            // 
            // tmrRefrashFrame
            // 
            this.tmrRefrashFrame.Tick += new System.EventHandler(this.tmrRefrashFrame_Tick);
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnMenu.Controls.Add(this.btnSalvarConfig);
            this.pnMenu.Controls.Add(this.label1);
            this.pnMenu.Controls.Add(this.lblBorda);
            this.pnMenu.Controls.Add(this.cboDriver);
            resources.ApplyResources(this.pnMenu, "pnMenu");
            this.pnMenu.Name = "pnMenu";
            // 
            // btnSalvarConfig
            // 
            resources.ApplyResources(this.btnSalvarConfig, "btnSalvarConfig");
            this.btnSalvarConfig.Name = "btnSalvarConfig";
            this.btnSalvarConfig.UseVisualStyleBackColor = true;
            this.btnSalvarConfig.Click += new System.EventHandler(this.btnSaveConfig_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblBorda
            // 
            this.lblBorda.BackColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.lblBorda, "lblBorda");
            this.lblBorda.ForeColor = System.Drawing.Color.White;
            this.lblBorda.Name = "lblBorda";
            this.lblBorda.Click += new System.EventHandler(this.lblBorda_Click);
            // 
            // cboDriver
            // 
            this.cboDriver.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDriver.FormattingEnabled = true;
            resources.ApplyResources(this.cboDriver, "cboDriver");
            this.cboDriver.Name = "cboDriver";
            // 
            // CamOnWebComponent
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.ImgWebCamShow);
            this.Name = "CamOnWebComponent";
            this.Load += new System.EventHandler(this.CamOnWebComponent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgWebCamShow)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgWebCamShow;
        private System.Windows.Forms.Timer tmrRefrashFrame;
        private Panel pnMenu;
        private ComboBox cboDriver;
        private Label lblBorda;
        private Label label1;
        private Button btnSalvarConfig;
    }
}
