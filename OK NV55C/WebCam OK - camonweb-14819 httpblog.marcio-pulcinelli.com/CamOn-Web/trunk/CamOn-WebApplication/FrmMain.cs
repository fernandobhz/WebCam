using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace CamOnWebApplication
{
    public partial class FrmMain : Form
    {
        private bool recording = false;
        private bool playing = false;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.Text = "CamOnWeb v" + Assembly.GetExecutingAssembly().GetName().Version.ToString() + ".";
            btnRecord.Enabled = false;
        }

        private void btnPlayWebcam_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                playing = true;
                btnPlayWebcam.Image = Properties.Resources.Stop;
                btnRecord.Enabled = true;
                sliderFrame.Enabled = false;
                camOnWebComponent.Start();
            }
            else
            {
                playing = false;
                btnPlayWebcam.Image = Properties.Resources.Play;
                btnRecord.Enabled = false;

                camOnWebComponent.Stop();
                sliderFrame.Enabled = true;

                if (recording)
                {
                    camOnWebComponent.StopVideoRecord();
                }
            }
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            if (!recording)
            {
                recording = true;
                btnRecord.Image = Properties.Resources.Stop;
                camOnWebComponent.RecordVideo();
            }
            else
            {
                recording = false;
                btnRecord.Image = Properties.Resources.Record;
                camOnWebComponent.StopVideoRecord();
            }
        }

        private void btnTirarFoto_Click(object sender, EventArgs e)
        {
            camOnWebComponent.TakePicture();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            lblFrameRate.Text = sliderFrame.Value.ToString() + " ms";
            camOnWebComponent.IntervalFrameRate = 200;
        }
    }
}
