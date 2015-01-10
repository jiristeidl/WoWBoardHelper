using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WoWBoardHelper.Core;

namespace WoWBoardHelper
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
            this.Text = Properties.Resources.AppTitle;
            this.choosePlayers.Text = Properties.Resources.ChoosePlayers;
            this.startGame.Text = Properties.Resources.StartGame;
        }

        private void startGame_Click(object sender, EventArgs e)
        {
            ClassSelect classSelectForm = new ClassSelect((int)numberOfPlayers.Value);
            this.Visible = false;
            classSelectForm.ShowDialog();
            this.Close();
        }
    }
}