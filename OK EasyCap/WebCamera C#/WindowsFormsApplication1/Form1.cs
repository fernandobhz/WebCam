using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            oWebCam = new WebCam();
            oWebCam.Container = this.pictureBox1;
        }
        WebCam oWebCam;
        private void btnStart_Click(object sender, EventArgs e)
        {
            oWebCam.OpenConnection();
        }
        
        private void btnSave_Click(object sender, EventArgs e)
        {
            oWebCam.SaveImage();
        }
 
        private void btnStop_Click(object sender, EventArgs e)
        {
            oWebCam.Dispose();
        }

    }
    }

