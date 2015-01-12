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
using WoWBoardHelper.Data.Enums;

namespace WoWBoardHelper
{
    public partial class ClassSelect : Form
    {
        public ClassSelect()
        {
            InitializeComponent();
        }

        private void ClassSelect_Paint(object sender, PaintEventArgs e)
        {
            var Classes = Enum.GetValues(typeof(Classes));
            var Sides = Enum.GetValues(typeof(Sides));

            this.Text = Properties.Resources.classSelect;
            this.Title.Text = string.Format(Properties.Resources.ChooseClassPlayer, Global.CurrentPlayer);
            foreach (var playerClass in Classes)
            {
                this.ClassSelectDropdown.Items.Add(playerClass.ToString());
            }
            foreach (var side in Sides)
            {
                this.SideSelectDropdown.Items.Add(side.ToString());
            }
            this.SideSelectDropdown.SelectedItem = WoWBoardHelper.Data.Enums.Sides.Horde.ToString();
            this.ClassSelectDropdown.SelectedItem = WoWBoardHelper.Data.Enums.Classes.Shaman.ToString();
            this.SelectClassBtn.Text = Properties.Resources.ConfirmClass;
            this.ClassSelectLabel.Text = Properties.Resources._class;
            this.SideSelectLabel.Text = Properties.Resources._race;
            this.PlayerNameLabel.Text = Properties.Resources.PlayerName;
            this.PlayerName.Text = Properties.Resources._player + " " + Global.CurrentPlayer;
        }

        private void SelectClassBtn_Click(object sender, EventArgs e)
        {
            Global.Players.Add(Global.CurrentPlayer, new Player((Classes)Enum.Parse(typeof(Classes), this.ClassSelectDropdown.SelectedItem.ToString(), true), ((Sides)Enum.Parse(typeof(Sides), this.SideSelectDropdown.SelectedItem.ToString(), true)), PlayerName.Text));
            if (Global.CurrentPlayer != Global.NumberOfPlayers)
            {
                Global.CurrentPlayer++;
                this.Refresh();
            }
            else
            {
                this.SelectClassBtn.Enabled = false;
            }
        }
    }
}