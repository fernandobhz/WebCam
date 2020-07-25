namespace CamOnWebApplication
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.tabJanelas = new System.Windows.Forms.TabControl();
            this.tabWebcam = new System.Windows.Forms.TabPage();
            this.lblFrameRate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.sliderFrame = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTirarFoto = new System.Windows.Forms.Button();
            this.btnPlayWebcam = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.camOnWebComponent = new CamOnWebController.CamOnWebComponent();
            this.tabWebSites = new System.Windows.Forms.TabPage();
            this.camOnFlashComponent1 = new CamOnWebController.CamOnFlashComponent();
            this.tabJanelas.SuspendLayout();
            this.tabWebcam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderFrame)).BeginInit();
            this.tabWebSites.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabJanelas
            // 
            this.tabJanelas.Controls.Add(this.tabWebcam);
            this.tabJanelas.Controls.Add(this.tabWebSites);
            this.tabJanelas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabJanelas.Location = new System.Drawing.Point(0, 0);
            this.tabJanelas.Name = "tabJanelas";
            this.tabJanelas.SelectedIndex = 0;
            this.tabJanelas.Size = new System.Drawing.Size(446, 521);
            this.tabJanelas.TabIndex = 0;
            // 
            // tabWebcam
            // 
            this.tabWebcam.Controls.Add(this.lblFrameRate);
            this.tabWebcam.Controls.Add(this.label4);
            this.tabWebcam.Controls.Add(this.sliderFrame);
            this.tabWebcam.Controls.Add(this.label3);
            this.tabWebcam.Controls.Add(this.label2);
            this.tabWebcam.Controls.Add(this.label1);
            this.tabWebcam.Controls.Add(this.btnTirarFoto);
            this.tabWebcam.Controls.Add(this.btnPlayWebcam);
            this.tabWebcam.Controls.Add(this.btnRecord);
            this.tabWebcam.Controls.Add(this.camOnWebComponent);
            this.tabWebcam.Location = new System.Drawing.Point(4, 22);
            this.tabWebcam.Name = "tabWebcam";
            this.tabWebcam.Padding = new System.Windows.Forms.Padding(3);
            this.tabWebcam.Size = new System.Drawing.Size(438, 495);
            this.tabWebcam.TabIndex = 0;
            this.tabWebcam.Text = "Webcam";
            this.tabWebcam.UseVisualStyleBackColor = true;
            // 
            // lblFrameRate
            // 
            this.lblFrameRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFrameRate.AutoSize = true;
            this.lblFrameRate.Location = new System.Drawing.Point(262, 404);
            this.lblFrameRate.Name = "lblFrameRate";
            this.lblFrameRate.Size = new System.Drawing.Size(35, 13);
            this.lblFrameRate.TabIndex = 9;
            this.lblFrameRate.Text = "50 ms";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Frame Rate:";
            // 
            // sliderFrame
            // 
            this.sliderFrame.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sliderFrame.Location = new System.Drawing.Point(183, 442);
            this.sliderFrame.Maximum = 1500;
            this.sliderFrame.Minimum = 50;
            this.sliderFrame.Name = "sliderFrame";
            this.sliderFrame.Size = new System.Drawing.Size(177, 45);
            this.sliderFrame.SmallChange = 10;
            this.sliderFrame.TabIndex = 7;
            this.sliderFrame.TickFrequency = 100;
            this.sliderFrame.Value = 50;
            this.sliderFrame.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(364, 404);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Take Picture:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Record Video:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 404);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Play WebCam";
            // 
            // btnTirarFoto
            // 
            this.btnTirarFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTirarFoto.Image = global::CamOnWebApplication.Properties.Resources.Camera;
            this.btnTirarFoto.Location = new System.Drawing.Point(366, 423);
            this.btnTirarFoto.Name = "btnTirarFoto";
            this.btnTirarFoto.Size = new System.Drawing.Size(64, 64);
            this.btnTirarFoto.TabIndex = 3;
            this.btnTirarFoto.UseVisualStyleBackColor = true;
            this.btnTirarFoto.Click += new System.EventHandler(this.btnTirarFoto_Click);
            // 
            // btnPlayWebcam
            // 
            this.btnPlayWebcam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlayWebcam.Image = global::CamOnWebApplication.Properties.Resources.Play;
            this.btnPlayWebcam.Location = new System.Drawing.Point(6, 423);
            this.btnPlayWebcam.Name = "btnPlayWebcam";
            this.btnPlayWebcam.Size = new System.Drawing.Size(64, 64);
            this.btnPlayWebcam.TabIndex = 2;
            this.btnPlayWebcam.UseVisualStyleBackColor = true;
            this.btnPlayWebcam.Click += new System.EventHandler(this.btnPlayWebcam_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRecord.Image = ((System.Drawing.Image)(resources.GetObject("btnRecord.Image")));
            this.btnRecord.Location = new System.Drawing.Point(113, 423);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(64, 64);
            this.btnRecord.TabIndex = 1;
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // camOnWebComponent
            // 
            this.camOnWebComponent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.camOnWebComponent.DriverVideoIndex = ((short)(0));
            this.camOnWebComponent.IntervalFrameRate = 50;
            this.camOnWebComponent.Location = new System.Drawing.Point(6, 6);
            this.camOnWebComponent.Name = "camOnWebComponent";
            this.camOnWebComponent.Size = new System.Drawing.Size(424, 387);
            this.camOnWebComponent.TabIndex = 0;
            // 
            // tabWebSites
            // 
            this.tabWebSites.Controls.Add(this.camOnFlashComponent1);
            this.tabWebSites.Location = new System.Drawing.Point(4, 22);
            this.tabWebSites.Name = "tabWebSites";
            this.tabWebSites.Padding = new System.Windows.Forms.Padding(3);
            this.tabWebSites.Size = new System.Drawing.Size(438, 495);
            this.tabWebSites.TabIndex = 1;
            this.tabWebSites.Text = "WebSites";
            this.tabWebSites.UseVisualStyleBackColor = true;
            // 
            // camOnFlashComponent1
            // 
            this.camOnFlashComponent1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.camOnFlashComponent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camOnFlashComponent1.Location = new System.Drawing.Point(3, 3);
            this.camOnFlashComponent1.Name = "camOnFlashComponent1";
            this.camOnFlashComponent1.Size = new System.Drawing.Size(432, 489);
            this.camOnFlashComponent1.TabIndex = 0;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 521);
            this.Controls.Add(this.tabJanelas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(462, 559);
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.tabJanelas.ResumeLayout(false);
            this.tabWebcam.ResumeLayout(false);
            this.tabWebcam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sliderFrame)).EndInit();
            this.tabWebSites.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabJanelas;
        private System.Windows.Forms.TabPage tabWebcam;
        private System.Windows.Forms.TabPage tabWebSites;
        private CamOnWebController.CamOnWebComponent camOnWebComponent;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnPlayWebcam;
        private System.Windows.Forms.Button btnTirarFoto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private CamOnWebController.CamOnFlashComponent camOnFlashComponent1;
        private System.Windows.Forms.TrackBar sliderFrame;
        private System.Windows.Forms.Label lblFrameRate;
        private System.Windows.Forms.Label label4;
    }
}