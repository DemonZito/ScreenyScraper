using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ScreenyScraper
{
    class ListViewDoubleBuffered : ListView
    {
        public ListViewDoubleBuffered() : base()
        {
            DoubleBuffered = true;
        }
    }
}