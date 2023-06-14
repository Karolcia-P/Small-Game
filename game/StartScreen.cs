using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace game
{
    public partial class StartScreen : Form
    {
        public StartScreen()
        {
            InitializeComponent();
        }

        private void LoadGame(object sender, EventArgs e)
        {
            this.Hide();
            GameScreen gameWindow = new GameScreen();
            gameWindow.Closed += (s, args) => this.Close();
            gameWindow.Show();
        }
    }
}
