using OktatasNyilvantarto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OktatasNyilvantarto
{
    public class LoadWidgets
    {
        public static void LoadType(ComboBox typeBox)
        {
            using (var db = new TP())
            {
                var query = from a in db.TpOktatasTipus
                            orderby a.Ertek
                            select a.Ertek;
                foreach (var b in query)
                {
                    typeBox.Items.Add(b);
                }
            }
        }

        public static void LoadStatus(ComboBox statusBox)
        {
            using (var db = new TP())
            {
                var query = from a in db.TpOktatasStatusz
                            orderby a.ID
                            select a.Leiras;
                foreach (var b in query)
                {
                    statusBox.Items.Add(b);
                }
            }
        }

        public static void LoadFrequency(ComboBox freqBox)
        {
            using (var db = new TP())
            {
                var query = from a in db.TpOktatasGyakorisag
                            orderby a.ID
                            select a.Ertek;
                foreach (var b in query)
                {
                    freqBox.Items.Add(b);
                }
            }
        }
        public static void LoadNames(ListBox nameList)
        {
            using (var db = new DolgozoiKodok())
            {
                var query = from a in db.DolgKodok
                            orderby a.TextDescription
                            where a.StatusAkt == 1
                            select new { a.TSz, a.TextDescription };
                foreach (var b in query)
                {
                    nameList.Items.Add(b.TextDescription + "#" + b.TSz);
                }
            }
        }
    }
}
