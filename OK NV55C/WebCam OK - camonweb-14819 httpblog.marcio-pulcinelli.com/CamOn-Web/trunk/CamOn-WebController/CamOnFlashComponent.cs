using System;
using System.Windows.Forms;

namespace CamOnWebController
{
    /// <summary>
    /// Component for execute web streams like youtube and Vimeo.
    /// </summary>
    public partial class CamOnFlashComponent : UserControl
    {
        public CamOnFlashComponent()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Overrides the OnCreateControl event.
        /// </summary>
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (!this.DesignMode)
            {
                pnMenu.Left = -300;
                lblBorda.Text = ">>";
                txtURL.Text = "http://";
            }
        }

        /// <summary>
        /// Event for expand / contract menu.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblBorda_Click(object sender, EventArgs e)
        {
            if (lblBorda.Text.Equals(">>"))
            {
                pnMenu.Left = 0;
                lblBorda.Text = "<<";
            }
            else
            {
                pnMenu.Left = -300;
                lblBorda.Text = ">>";
            }
        }

        /// <summary>
        /// Event for execute the player.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGO_Click(object sender, EventArgs e)
        {
            try
            {
                flashPlayer.Movie = txtURL.Text;
                flashPlayer.Play();
                pnMenu.Left = -300;
                lblBorda.Text = ">>";
            }
            catch 
            {
            }
        }
    }
}
