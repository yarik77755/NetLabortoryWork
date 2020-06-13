using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesPart2
{
    public partial class Form1 : Form
    {
        InterfacesPart1.BoatShop boatShop;
        Dictionary<int, string> dic = new Dictionary<int, string>();


        public Form1()
        {
            InitializeComponent();
            boatShop = new InterfacesPart1.BoatShop();
            Array mas1 = InterfacesPart1.VesselType.GetValues(typeof(InterfacesPart1.VesselType));          
            foreach (InterfacesPart1.VesselType name in mas1)
                comboBoxVesselType.Items.Add(name);

            Array mas2 = InterfacesPart1.SpeedUnit.GetValues(typeof(InterfacesPart1.SpeedUnit));
            foreach (InterfacesPart1.SpeedUnit name in mas2)
                comboBoxSpeedUnit.Items.Add(name);

            dic.Add(5, "Red");
            dic.Add(7, "Black");
            dic.Add(10, "White");
            foreach (var item in dic)
            {
                comboBoxSpeedUnit.Items.Add(item.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                boatShop.Photo = openFileDialog1.FileName;
                pictureBox1.Image = Image.FromFile(boatShop.Photo);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            boatShop.Date = DateTime.Now;
            boatShop.Price = Convert.ToDouble(textBoxPrice.Text);
            boatShop.MaxSpeed = Convert.ToInt32(labelSpeed.Text);
            // TODO Закончить считывание данных объекта
        }

        private void trackBarDraught_ValueChanged(object sender, EventArgs e)
        {
            labelDraught.Text = (trackBarDraught.Value/10.0).ToString();
        }

        private void hScrollMaxSpeed_ValueChanged(object sender, EventArgs e)
        {
            labelSpeed.Text = hScrollMaxSpeed.Value.ToString();
        }

        private void comboBoxSpeedUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(comboBoxSpeedUnit.Text);
            switch (comboBoxSpeedUnit.SelectedIndex+1)
            {
                case 1:
                    hScrollMaxSpeed.Maximum = 209;
                    break;
                case 2:
                    hScrollMaxSpeed.Maximum = 54;
                    break;
                case 3:
                    hScrollMaxSpeed.Maximum = 1209;
                    break;
                case 4:
                    hScrollMaxSpeed.Maximum = 18;
                    break;
                default:
                    hScrollMaxSpeed.Maximum = 109;
                    break;
                    
            }

            hScrollMaxSpeed.Value = hScrollMaxSpeed.Maximum;
        }

        private void comboBoxVesselType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxVesselType.SelectedIndex)
            {
                case 0:
                    pictureBox1.Image = Image.FromFile(@"d:\qrcode.png");
                    break;
                case 1:
                    pictureBox1.Image = Image.FromFile(@"d:\boat.png");
                    break;
            }
        }

    }
}
