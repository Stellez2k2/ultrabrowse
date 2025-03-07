using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UltraBrowse
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            textBoxSearch.Text = "google.com";
            //This will navigate to the Url in the textbox
            webBrowserDisplay.Navigate(textBoxSearch.Text);
            //This will stop JS errors from displaying
            webBrowserDisplay.ScriptErrorsSuppressed = true;


        }

        //This runs when the user presses the go button
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            //This will navigate to the Url in the textbox
            webBrowserDisplay.Navigate(textBoxSearch.Text);
            //This will stop JS errors from displaying
            webBrowserDisplay.ScriptErrorsSuppressed = true;
        }

        private void buttonSearch2_Click(object sender, EventArgs e)
        {
            //This will navigate to the Url in the textbox
            webBrowserDisplay2.Navigate(textBoxSearch2.Text);
            //This will stop JS errors from displaying
            webBrowserDisplay2.ScriptErrorsSuppressed = true;

        }

        private void buttonMusic1_Click(object sender, EventArgs e)
        {
            SoundPlayer objectSoundPlayer = new SoundPlayer(Properties.Resources.relaxing);

            objectSoundPlayer.Play();
        }

        private void buttonMusic2_Click(object sender, EventArgs e)
        {
            SoundPlayer objectSoundPlayer = new SoundPlayer(Properties.Resources.rock);

            objectSoundPlayer.Play();
        }

        private void buttonMusic3_Click(object sender, EventArgs e)
        {
            SoundPlayer objectSoundPlayer = new SoundPlayer(Properties.Resources.jazz);

            objectSoundPlayer.Play();
        }

        private void buttonMusic4_Click(object sender, EventArgs e)
        {
            SoundPlayer objectSoundPlayer = new SoundPlayer(Properties.Resources.pop);

            objectSoundPlayer.Play();
        }
    }
}
