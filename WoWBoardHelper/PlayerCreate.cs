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
    public partial class PlayerCreate : Form
    {
        public PlayerCreate()
        {
            InitializeComponent();
            this.Text = Properties.Resources.AppTitle;
            this.ConfirmBtn.Text = Properties.Resources.Confirm;
        }

        private void PlayerCreate_Paint(object sender, PaintEventArgs e)
        {
            this.Title.Text = string.Format(Properties.Resources.PlayerSelectName, _Global.CurrentPlayer);
            this.PlayerNameText.Text = Properties.Resources._player + _Global.CurrentPlayer;
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            _Global.Players.Add(_Global.CurrentPlayer, new Player(PlayerNameText.Text));
            if (_Global.CurrentPlayer < _Global.NumberOfPlayers)
            {
                _Global.CurrentPlayer++;
                this.Refresh();
            }
            else
            {
                _Global.CurrentPlayer = 1;
                ClassSelect ClassSelectFrm = new ClassSelect();
                this.Visible = false;
                ClassSelectFrm.ShowDialog();
                this.Close();
            }
        }
    }
}