using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NDAT
{
    public partial class Ucus_Kutusu : UserControl
    {
        public Ucus_Kutusu(Ucus ucus)
        {
            InitializeComponent();
            RotaVeriLabel.Text = ucus.KalkisYeri + " -> " + ucus.VarisYeri;
            TarihVeriLabel.Text = ucus.Tarih.ToShortDateString();
            SaatVeriLabel.Text = ucus.Tarih.ToShortTimeString();
            FiyatVeriLabel.Text = ucus.Koltuklar[0].Fiyat.ToString();
        }
    }
}
