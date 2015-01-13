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
        private int initializedCharacters;

        public ClassSelect()
        {
            InitializeComponent();
            initializedCharacters = 0;
            var Classes = Enum.GetValues(typeof(Classes));
            var Sides = Enum.GetValues(typeof(Sides));
            foreach (var playerClass in Classes)
            {
                this.ClassSelectDropdown.Items.Add(playerClass.ToString());
            }
            foreach (var side in Sides)
            {
                this.SideSelectDropdown.Items.Add(side.ToString());
            }
        }

        private void ClassSelect_Paint(object sender, PaintEventArgs e)
        {
            this.Text = Properties.Resources.classSelect;
            this.Title.Text = string.Format(Properties.Resources.ChooseClassPlayer, _Global.CurrentPlayer);
            this.SideSelectDropdown.SelectedItem = WoWBoardHelper.Data.Enums.Sides.Horde.ToString();
            this.ClassSelectDropdown.SelectedItem = WoWBoardHelper.Data.Enums.Classes.Shaman.ToString();
            this.SelectClassBtn.Text = Properties.Resources.ConfirmClass;
            this.ClassSelectLabel.Text = Properties.Resources._class;
            this.SideSelectLabel.Text = Properties.Resources._race;
        }

        private void SelectClassBtn_Click(object sender, EventArgs e)
        {
            _Global.CurrentPlayer++;
        }
    }
}