using MetroSet_UI.Forms;
using Sopa_De_Letras.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sopa_De_Letras
{
    public partial class TopPlayers : MetroSetForm
    {
        public TopPlayers()
        {
            InitializeComponent();
        }

        private void TopPlayers_Load(object sender, EventArgs e)
        {
            metroSetTabControl1.SendToBack();
            EstadisticasDAO estadisticasDAO = new EstadisticasDAO();
            foreach (var item in estadisticasDAO.ranking())
            {
                metroLblRanking.AddItem(item.ToString());
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }

        private void metroBtnRegresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            var categories = new Login();
            categories.Closed += (s, args) => this.Close();
            categories.Show();
        }
    }
}
