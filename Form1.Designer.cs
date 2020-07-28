namespace ScreenyScraper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.listViewDoubleBuffered1 = new ScreenyScraper.ListViewDoubleBuffered();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // listViewDoubleBuffered1
            // 
            this.listViewDoubleBuffered1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewDoubleBuffered1.HideSelection = false;
            this.listViewDoubleBuffered1.LargeImageList = this.imageList1;
            this.listViewDoubleBuffered1.Location = new System.Drawing.Point(0, 0);
            this.listViewDoubleBuffered1.Name = "listViewDoubleBuffered1";
            this.listViewDoubleBuffered1.Size = new System.Drawing.Size(1034, 778);
            this.listViewDoubleBuffered1.TabIndex = 1;
            this.listViewDoubleBuffered1.UseCompatibleStateImageBehavior = false;
            this.listViewDoubleBuffered1.SelectedIndexChanged += new System.EventHandler(this.listViewDoubleBuffered1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1034, 778);
            this.Controls.Add(this.listViewDoubleBuffered1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private ListViewDoubleBuffered listViewDoubleBuffered1;
    }
}

