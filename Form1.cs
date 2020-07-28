using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using HtmlAgilityPack;
using System.IO;
using System.Threading;

namespace ScreenyScraper
{
    public partial class Form1 : Form
    {
        // Thread-safe add image to listview
        public void AddImageToUI(Image img, string urlSuffix)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(() => AddImageToUI(img, urlSuffix)));
            }
            else
            {
                imageList1.Images.Add(img);

                ListViewItem item = new ListViewItem();
                item.ImageIndex = imageList1.Images.Count -1;
                item.Text = urlSuffix;
                listViewDoubleBuffered1.Items.Add(item);
            }
        }

        // Form constructor
        public Form1()
        {
            InitializeComponent();

            listViewDoubleBuffered1.LargeImageList = imageList1;
            imageList1.ImageSize = new Size(256, 256);

            Scraper scraper = new Scraper();
            scraper.StartScrape(this);

        }

        private void listViewDoubleBuffered1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listViewDoubleBuffered1.FocusedItem != null)
            {
                listViewDoubleBuffered1.FocusedItem.Focused = false;
                listViewDoubleBuffered1.SelectedItems[0].Selected = false;
            }
        }
    }

}
