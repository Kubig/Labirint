using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labirint
{
    public partial class Level1 : Form
    {
        public Level1()
        {
            InitializeComponent();
            
        }

        private void start_game ()
        {
            Point point = lblStart.Location;
            point.Offset(lblStart.Width / 2, lblStart.Height / 2);
            Cursor.Position = PointToScreen (point);
            Sound.play_start();
        }

        private void finish_game()
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void Level1_Show(object sender, EventArgs e)
        {
            start_game();
        }

        private void lblFinish_MouseEnter(object sender, EventArgs e)
        {
            finish_game();
        }

        private void restart_game() // Функция перезапуска игры
        {
            Sound.play_fail();
            DialogResult dr = MessageBox.Show("Выходить за рамки лабиринта нельзя!\n\nБудем ещё играть?", "Вы проиграли!", MessageBoxButtons.YesNo);
            if (dr == System.Windows.Forms.DialogResult.Yes)
                start_game();
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            restart_game();
        }
    }
}
