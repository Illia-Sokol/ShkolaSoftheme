using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ISerializationSurrogate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MovableButton selected = null;
        private void button1_Click(object sender, EventArgs e)
        {
            MovableButton table = new MovableButton(TableMode.Snooker);
            table.Selected += new EventHandler(table_Selected);
            table.Name = "Table_" + pictureBox1.Controls.Count.ToString();
            table.Mode = ISerializationSurrogate.DesignMode.Design;

            pictureBox1.Controls.Add(table);
        }

        void table_Selected(object sender, EventArgs e)
        {
            selected = (MovableButton)sender;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selected != null)
            {
                pictureBox1.Controls.Remove(selected);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<MovableButton> tables = new List<MovableButton>();

            foreach (MovableButton table in pictureBox1.Controls)
                tables.Add(table);

            Diagnastics.BinarySerializer.ToBin("TableLayout.tbl", tables, new MovableButtonSurrogate(), typeof(MovableButton));

            tables.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("TableLayout.tbl"))
            {
                pictureBox1.Controls.Clear();

                List<MovableButton> tables = (List<MovableButton>)Diagnastics.BinarySerializer.FromBin("TableLayout.tbl", new MovableButtonSurrogate(), typeof(MovableButton));

                foreach (MovableButton table in tables)
                {
                    table.Selected += new EventHandler(table_Selected);
                    pictureBox1.Controls.Add(table);
                }

                
                GC.Collect();
                GC.SuppressFinalize(pictureBox1);

            }
        }
    }
}
