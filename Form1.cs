using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JelenletiNaplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            object name1 = comboBox1.SelectedItem;
            String name = Convert.ToString(name1);
            label86.Text = name;
        }


        public void comboBox3_SelectedValueChanged(object sender, EventArgs e)
        {
            object month1 = comboBox3.SelectedItem;
            String month = Convert.ToString(month1);
            label87.Text = month + " hónap";            
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            object workershour1 = comboBox2.SelectedItem;
            double workershour = Convert.ToDouble(workershour1);
            
        }

        private void comboBox4_SelectedValueChanged(object sender, EventArgs e)
        {
            object workinghours1 = comboBox4.SelectedItem;
            Byte workinghours = Convert.ToByte(workinghours1);
            label87.Text = workinghours + " óra";
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            //A lehetőségek: N6, N7, 8, 9, E6, E7, SZ, B.
            object avalasz1 = listBox1.SelectedItem;
            String valasz1 = Convert.ToString(avalasz1);
            object avalasz2 = listBox2.SelectedItem;
            String valasz2 = Convert.ToString(avalasz2);
            object avalasz3 = listBox3.SelectedItem;
            String valasz3 = Convert.ToString(avalasz3);
            object avalasz4 = listBox4.SelectedItem;
            String valasz4 = Convert.ToString(avalasz4);
            object avalasz5 = listBox5.SelectedItem;
            String valasz5 = Convert.ToString(avalasz5);
            object avalasz6 = listBox6.SelectedItem;
            String valasz6 = Convert.ToString(avalasz6);
            object avalasz7 = listBox7.SelectedItem;
            String valasz7 = Convert.ToString(avalasz7);
            object avalasz8 = listBox8.SelectedItem;
            String valasz8 = Convert.ToString(avalasz8);
            object avalasz9 = listBox9.SelectedItem;
            String valasz9 = Convert.ToString(avalasz9);
            object avalasz10 = listBox10.SelectedItem;
            String valasz10 = Convert.ToString(avalasz10);
            object avalasz11 = listBox11.SelectedItem;
            String valasz11 = Convert.ToString(avalasz11);
            object avalasz12 = listBox12.SelectedItem;
            String valasz12 = Convert.ToString(avalasz12);
            object avalasz13 = listBox13.SelectedItem;
            String valasz13 = Convert.ToString(avalasz13);
            object avalasz14 = listBox14.SelectedItem;
            String valasz14 = Convert.ToString(avalasz14);
            object avalasz15 = listBox15.SelectedItem;
            String valasz15 = Convert.ToString(avalasz15);
            object avalasz16 = listBox16.SelectedItem;
            String valasz16 = Convert.ToString(avalasz16);
            object avalasz17 = listBox17.SelectedItem;
            String valasz17 = Convert.ToString(avalasz17);
            object avalasz18 = listBox18.SelectedItem;
            String valasz18 = Convert.ToString(avalasz18);
            object avalasz19 = listBox19.SelectedItem;
            String valasz19 = Convert.ToString(avalasz19);
            object avalasz20 = listBox20.SelectedItem;
            String valasz20 = Convert.ToString(avalasz20);
            object avalasz21 = listBox21.SelectedItem;
            String valasz21 = Convert.ToString(avalasz21);
            object avalasz22 = listBox22.SelectedItem;
            String valasz22 = Convert.ToString(avalasz22);
            object avalasz23 = listBox23.SelectedItem;
            String valasz23 = Convert.ToString(avalasz23);
            object avalasz24 = listBox24.SelectedItem;
            String valasz24 = Convert.ToString(avalasz24);
            object avalasz25 = listBox25.SelectedItem;
            String valasz25 = Convert.ToString(avalasz25);
            object avalasz26 = listBox26.SelectedItem;
            String valasz26 = Convert.ToString(avalasz26);
            object avalasz27 = listBox27.SelectedItem;
            String valasz27 = Convert.ToString(avalasz27);
            object avalasz28 = listBox28.SelectedItem;
            string valasz28 = Convert.ToString(avalasz28);
            object avalasz29 = listBox29.SelectedItem;
            string valasz29 = Convert.ToString(avalasz29);
            object avalasz30 = listBox30.SelectedItem;
            string valasz30 = Convert.ToString(avalasz30);
            object avalasz31 = listBox31.SelectedItem;
            string valasz31 = Convert.ToString(avalasz31);
            object aathozat = checkBox1.CheckState;
            bool athozat = Convert.ToBoolean(aathozat);
            object aatvitt = checkBox2.CheckState;
            bool atvitt = Convert.ToBoolean(aatvitt);
            //A lehetőségek: N6, N7, 8, 9, E6, E7, SZ, B.
            //Megvizsgáljuk a válasz1 stringet
            switch (valasz1)
            {
                case "N6": //ha válasz1: N6
                    textBox1.Text = "06"; //Az első mezőbe 06-ot íratunk
                    Byte day1061 = Convert.ToByte(textBox1.Text); //majd konvertáljuk byte-tá
                    textBox46.Text = "18"; //A második mezőbe 18-at íratunk
                    Byte day1062 = Convert.ToByte(textBox46.Text); //majd konvertáljuk byte-tá
                    textBox76.Text = "12"; //adunk rá 12 munkaórát
                    Byte day1063 = Convert.ToByte(textBox76.Text); //majd konvertáljuk byte-tá
                    textBox91.Text = "4"; //És adunk rá 4 20%-os pótlékot
                    Byte day1064 = Convert.ToByte(textBox91.Text); //majd konvertáljuk byte-tá
                    textBox121.Text = "0";
                    Byte day1065 = Convert.ToByte(textBox121.Text);
                    day1063 += day1065;
                    day1064 += day1065;
                    break;
                case "N7":
                    textBox1.Text = "07";
                    Convert.ToByte(textBox1.Text);
                    textBox46.Text = "19";
                    Convert.ToByte(textBox46.Text);
                    textBox76.Text = "12";
                    Convert.ToByte(textBox76.Text);
                    textBox91.Text = "5";
                    Convert.ToByte(textBox91.Text);
                    break;
                case "8":
                    textBox1.Text = "08";
                    Convert.ToByte(textBox1.Text);
                    textBox46.Text = "20";
                    Convert.ToByte(textBox46.Text);
                    break;
                case "9":
                    textBox1.Text = "09";
                    Convert.ToByte(textBox1.Text);
                    textBox46.Text = "21";
                    Convert.ToByte(textBox46.Text);
                    break;
                case "E6":
                    textBox1.Text = "18";
                    Convert.ToByte(textBox1.Text);
                    textBox45.Text = "06";
                    Convert.ToByte(textBox45.Text);
                    break;
                case "E7":
                    textBox1.Text = "19";
                    Convert.ToByte(textBox1.Text);
                    textBox45.Text = "07";
                    Convert.ToByte(textBox45.Text);
                    break;
                case "SZ":
                    textBox1.Text = "8";
                    Convert.ToByte(textBox1.Text);
                    textBox61.Text = "8";
                    Convert.ToByte(textBox61.Text);
                    break;
                case "B":
                    textBox1.Text = "8";
                    Convert.ToByte(textBox1.Text);
                    textBox61.Text = "8";
                    Convert.ToByte(textBox61.Text);
                    break;
                default:
                    textBox1.Text = " ";
                    break;
               } //Switch vége
            //Rendelkezés az áthozott/átvitt órákról
            if (checkBox1.Checked == true)
            {
                textBox46.Text = "06";
                Convert.ToByte(textBox46.Text);
            }
            switch (valasz2)
            {
                case "N6":
                    textBox2.Text = "06";
                    textBox45.Text = "18";
                    break;
                case "N7":
                    textBox2.Text = "07";
                    textBox45.Text = "19";
                    break;
                case "8":
                    textBox2.Text = "08";
                    textBox45.Text = "20";
                    break;
                case "9":
                    textBox2.Text = "09";
                    textBox45.Text = "21";
                    break;
                case "E6":
                    textBox2.Text = "18";
                    textBox44.Text = "06";
                    break;
                case "E7":
                    textBox2.Text = "19";
                    textBox44.Text = "07";
                    break;
                case "SZ":
                    textBox2.Text = "8";
                    break;
                case "B":
                    textBox2.Text = "8";
                    break;
                default:
                    textBox2.Text = " ";
                    break;

            }
            switch (valasz3)
            {
                case "N6":
                    textBox3.Text = "06";
                    break;
                case "N7":
                    textBox3.Text = "07";
                    break;
                case "8":
                    textBox3.Text = "08";
                    break;
                case "9":
                    textBox3.Text = "09";
                    break;
                case "E6":
                    textBox3.Text = "18";
                    break;
                case "E7":
                    textBox3.Text = "19";
                    break;
                case "SZ":
                    textBox3.Text = "8";
                    break;
                case "B":
                    textBox3.Text = "8";
                    break;
                default:
                    textBox3.Text = " ";
                    break;
            }
            switch (valasz4)
            {
                case "N6":
                    textBox4.Text = "06";
                    break;
                case "N7":
                    textBox4.Text = "07";
                    break;
                case "8":
                    textBox4.Text = "08";
                    break;
                case "9":
                    textBox4.Text = "09";
                    break;
                case "E6":
                    textBox4.Text = "18";
                    break;
                case "E7":
                    textBox4.Text = "19";
                    break;
                case "SZ":
                    textBox4.Text = "8";
                    break;
                case "B":
                    textBox4.Text = "8";
                    break;
                default:
                    textBox4.Text = " ";
                    break;
            }
            switch (valasz5)
            {
                case "N6":
                    textBox5.Text = "06";
                    break;
                case "N7":
                    textBox5.Text = "07";
                    break;
                case "8":
                    textBox5.Text = "08";
                    break;
                case "9":
                    textBox5.Text = "09";
                    break;
                case "E6":
                    textBox5.Text = "18";
                    break;
                case "E7":
                    textBox5.Text = "19";
                    break;
                case "SZ":
                    textBox5.Text = "8";
                    break;
                case "B":
                    textBox5.Text = "8";
                    break;
                default:
                    textBox5.Text = " ";
                    break;
            }
            switch (valasz6)
            {
                case "N6":
                    textBox6.Text = "06";
                    break;
                case "N7":
                    textBox6.Text = "07";
                    break;
                case "8":
                    textBox6.Text = "08";
                    break;
                case "9":
                    textBox6.Text = "09";
                    break;
                case "E6":
                    textBox6.Text = "18";
                    break;
                case "E7":
                    textBox6.Text = "19";
                    break;
                case "SZ":
                    textBox6.Text = "8";
                    break;
                case "B":
                    textBox6.Text = "8";
                    break;
                default:
                    textBox6.Text = " ";
                    break;
            }
            switch (valasz7)
            {
                case "N6":
                    textBox7.Text = "06";
                    break;
                case "N7":
                    textBox7.Text = "07";
                    break;
                case "8":
                    textBox7.Text = "08";
                    break;
                case "9":
                    textBox7.Text = "09";
                    break;
                case "E6":
                    textBox7.Text = "18";
                    break;
                case "E7":
                    textBox7.Text = "19";
                    break;
                case "SZ":
                    textBox7.Text = "8";
                    break;
                case "B":
                    textBox7.Text = "8";
                    break;
                default:
                    textBox7.Text = " ";
                    break;
            }
            switch (valasz8)
            {
                case "N6":
                    textBox8.Text = "06";
                    break;
                case "N7":
                    textBox8.Text = "07";
                    break;
                case "8":
                    textBox8.Text = "08";
                    break;
                case "9":
                    textBox8.Text = "09";
                    break;
                case "E6":
                    textBox8.Text = "18";
                    break;
                case "E7":
                    textBox8.Text = "19";
                    break;
                case "SZ":
                    textBox8.Text = "8";
                    break;
                case "B":
                    textBox8.Text = "8";
                    break;
                default:
                    textBox8.Text = " ";
                    break;
            }
            switch (valasz9)
            {
                case "N6":
                    textBox9.Text = "06";
                    break;
                case "N7":
                    textBox9.Text = "07";
                    break;
                case "8":
                    textBox9.Text = "08";
                    break;
                case "9":
                    textBox9.Text = "09";
                    break;
                case "E6":
                    textBox9.Text = "18";
                    break;
                case "E7":
                    textBox9.Text = "19";
                    break;
                case "SZ":
                    textBox9.Text = "8";
                    break;
                case "B":
                    textBox9.Text = "8";
                    break;
                default:
                    textBox9.Text = " ";
                    break;
            }
            switch (valasz10)
            {
                case "N6":
                    textBox10.Text = "06";
                    break;
                case "N7":
                    textBox10.Text = "07";
                    break;
                case "8":
                    textBox10.Text = "08";
                    break;
                case "9":
                    textBox10.Text = "09";
                    break;
                case "E6":
                    textBox10.Text = "18";
                    break;
                case "E7":
                    textBox10.Text = "19";
                    break;
                case "SZ":
                    textBox10.Text = "8";
                    break;
                case "B":
                    textBox10.Text = "8";
                    break;
                default:
                    textBox10.Text = " ";
                    break;
            }
            switch (valasz11)
            {
                case "N6":
                    textBox11.Text = "06";
                    break;
                case "N7":
                    textBox11.Text = "07";
                    break;
                case "8":
                    textBox11.Text = "08";
                    break;
                case "9":
                    textBox11.Text = "09";
                    break;
                case "E6":
                    textBox11.Text = "18";
                    break;
                case "E7":
                    textBox11.Text = "19";
                    break;
                case "SZ":
                    textBox11.Text = "8";
                    break;
                case "B":
                    textBox11.Text = "8";
                    break;
                default:
                    textBox11.Text = " ";
                    break;
            }
            switch (valasz12)
            {
                case "N6":
                    textBox12.Text = "06";
                    break;
                case "N7":
                    textBox12.Text = "07";
                    break;
                case "8":
                    textBox12.Text = "08";
                    break;
                case "9":
                    textBox12.Text = "09";
                    break;
                case "E6":
                    textBox12.Text = "18";
                    break;
                case "E7":
                    textBox12.Text = "19";
                    break;
                case "SZ":
                    textBox12.Text = "8";
                    break;
                case "B":
                    textBox12.Text = "8";
                    break;
                default:
                    textBox12.Text = " ";
                    break;
            }
            switch (valasz13)
            {
                case "N6":
                    textBox13.Text = "06";
                    break;
                case "N7":
                    textBox13.Text = "07";
                    break;
                case "8":
                    textBox13.Text = "08";
                    break;
                case "9":
                    textBox13.Text = "09";
                    break;
                case "E6":
                    textBox13.Text = "18";
                    break;
                case "E7":
                    textBox13.Text = "19";
                    break;
                case "SZ":
                    textBox13.Text = "8";
                    break;
                case "B":
                    textBox13.Text = "8";
                    break;
                default:
                    textBox13.Text = " ";
                    break;
            }
            switch (valasz14)
            {
                case "N6":
                    textBox14.Text = "06";
                    break;
                case "N7":
                    textBox14.Text = "07";
                    break;
                case "8":
                    textBox14.Text = "08";
                    break;
                case "9":
                    textBox14.Text = "09";
                    break;
                case "E6":
                    textBox14.Text = "18";
                    break;
                case "E7":
                    textBox14.Text = "19";
                    break;
                case "SZ":
                    textBox14.Text = "8";
                    break;
                case "B":
                    textBox14.Text = "8";
                    break;
                default:
                    textBox14.Text = " ";
                    break;
            }
            switch (valasz15)
            {
                case "N6":
                    textBox15.Text = "06";
                    break;
                case "N7":
                    textBox15.Text = "07";
                    break;
                case "8":
                    textBox15.Text = "08";
                    break;
                case "9":
                    textBox15.Text = "09";
                    break;
                case "E6":
                    textBox15.Text = "18";
                    break;
                case "E7":
                    textBox15.Text = "19";
                    break;
                case "SZ":
                    textBox15.Text = "8";
                    break;
                case "B":
                    textBox15.Text = "8";
                    break;
                default:
                    textBox15.Text = " ";
                    break;
            }
            switch (valasz16)
            {
                case "N6":
                    textBox16.Text = "06";
                    break;
                case "N7":
                    textBox16.Text = "07";
                    break;
                case "8":
                    textBox16.Text = "08";
                    break;
                case "9":
                    textBox16.Text = "09";
                    break;
                case "E6":
                    textBox16.Text = "18";
                    break;
                case "E7":
                    textBox16.Text = "19";
                    break;
                case "SZ":
                    textBox16.Text = "8";
                    break;
                case "B":
                    textBox16.Text = "8";
                    break;
                default:
                    textBox16.Text = " ";
                    break;
            }
            switch (valasz17)
            {
                case "N6":
                    textBox17.Text = "06";
                    break;
                case "N7":
                    textBox17.Text = "07";
                    break;
                case "8":
                    textBox17.Text = "08";
                    break;
                case "9":
                    textBox17.Text = "09";
                    break;
                case "E6":
                    textBox17.Text = "18";
                    break;
                case "E7":
                    textBox17.Text = "19";
                    break;
                case "SZ":
                    textBox17.Text = "8";
                    break;
                case "B":
                    textBox17.Text = "8";
                    break;
                default:
                    textBox17.Text = " ";
                    break;
            }
            switch (valasz18)
            {
                case "N6":
                    textBox18.Text = "06";
                    break;
                case "N7":
                    textBox18.Text = "07";
                    break;
                case "8":
                    textBox18.Text = "08";
                    break;
                case "9":
                    textBox18.Text = "09";
                    break;
                case "E6":
                    textBox18.Text = "18";
                    break;
                case "E7":
                    textBox18.Text = "19";
                    break;
                case "SZ":
                    textBox18.Text = "8";
                    break;
                case "B":
                    textBox18.Text = "8";
                    break;
                default:
                    textBox18.Text = " ";
                    break;
            }
            switch (valasz19)
            {
                case "N6":
                    textBox19.Text = "06";
                    break;
                case "N7":
                    textBox19.Text = "07";
                    break;
                case "8":
                    textBox19.Text = "08";
                    break;
                case "9":
                    textBox19.Text = "09";
                    break;
                case "E6":
                    textBox19.Text = "18";
                    break;
                case "E7":
                    textBox19.Text = "19";
                    break;
                case "SZ":
                    textBox19.Text = "8";
                    break;
                case "B":
                    textBox19.Text = "8";
                    break;
                default:
                    textBox19.Text = " ";
                    break;
            }
            switch (valasz20)
            {
                case "N6":
                    textBox20.Text = "06";
                    break;
                case "N7":
                    textBox20.Text = "07";
                    break;
                case "8":
                    textBox20.Text = "08";
                    break;
                case "9":
                    textBox20.Text = "09";
                    break;
                case "E6":
                    textBox20.Text = "18";
                    break;
                case "E7":
                    textBox20.Text = "19";
                    break;
                case "SZ":
                    textBox20.Text = "8";
                    break;
                case "B":
                    textBox20.Text = "8";
                    break;
                default:
                    textBox20.Text = " ";
                    break;
            }
            switch (valasz21)
            {
                case "N6":
                    textBox21.Text = "06";
                    break;
                case "N7":
                    textBox21.Text = "07";
                    break;
                case "8":
                    textBox21.Text = "08";
                    break;
                case "9":
                    textBox21.Text = "09";
                    break;
                case "E6":
                    textBox21.Text = "18";
                    break;
                case "E7":
                    textBox21.Text = "19";
                    break;
                case "SZ":
                    textBox21.Text = "8";
                    break;
                case "B":
                    textBox21.Text = "8";
                    break;
                default:
                    textBox21.Text = " ";
                    break;
            }
            switch (valasz22)
            {
                case "N6":
                    textBox22.Text = "06";
                    break;
                case "N7":
                    textBox22.Text = "07";
                    break;
                case "8":
                    textBox22.Text = "08";
                    break;
                case "9":
                    textBox22.Text = "09";
                    break;
                case "E6":
                    textBox22.Text = "18";
                    break;
                case "E7":
                    textBox22.Text = "19";
                    break;
                case "SZ":
                    textBox22.Text = "8";
                    break;
                case "B":
                    textBox22.Text = "8";
                    break;
                default:
                    textBox22.Text = " ";
                    break;
            }
            switch (valasz23)
            {
                case "N6":
                    textBox23.Text = "06";
                    break;
                case "N7":
                    textBox23.Text = "07";
                    break;
                case "8":
                    textBox23.Text = "08";
                    break;
                case "9":
                    textBox23.Text = "09";
                    break;
                case "E6":
                    textBox23.Text = "18";
                    break;
                case "E7":
                    textBox23.Text = "19";
                    break;
                case "SZ":
                    textBox23.Text = "8";
                    break;
                case "B":
                    textBox23.Text = "8";
                    break;
                default:
                    textBox23.Text = " ";
                    break;
            }
            switch (valasz1)
            {
                case "N6":
                    textBox24.Text = "06";
                    break;
                case "N7":
                    textBox24.Text = "07";
                    break;
                case "8":
                    textBox24.Text = "08";
                    break;
                case "9":
                    textBox24.Text = "09";
                    break;
                case "E6":
                    textBox24.Text = "18";
                    break;
                case "E7":
                    textBox24.Text = "19";
                    break;
                case "SZ":
                    textBox24.Text = "8";
                    break;
                case "B":
                    textBox24.Text = "8";
                    break;
                default:
                    textBox24.Text = " ";
                    break;
            }
            switch (valasz25)
            {
                case "N6":
                    textBox25.Text = "06";
                    break;
                case "N7":
                    textBox25.Text = "07";
                    break;
                case "8":
                    textBox25.Text = "08";
                    break;
                case "9":
                    textBox25.Text = "09";
                    break;
                case "E6":
                    textBox25.Text = "18";
                    break;
                case "E7":
                    textBox25.Text = "19";
                    break;
                case "SZ":
                    textBox25.Text = "8";
                    break;
                case "B":
                    textBox25.Text = "8";
                    break;
                default:
                    textBox25.Text = " ";
                    break;
            }
            switch (valasz26)
            {
                case "N6":
                    textBox26.Text = "06";
                    break;
                case "N7":
                    textBox26.Text = "07";
                    break;
                case "8":
                    textBox26.Text = "08";
                    break;
                case "9":
                    textBox26.Text = "09";
                    break;
                case "E6":
                    textBox26.Text = "18";
                    break;
                case "E7":
                    textBox26.Text = "19";
                    break;
                case "SZ":
                    textBox26.Text = "8";
                    break;
                case "B":
                    textBox26.Text = "8";
                    break;
                default:
                    textBox26.Text = " ";
                    break;
            }
            switch (valasz27)
            {
                case "N6":
                    textBox27.Text = "06";
                    break;
                case "N7":
                    textBox27.Text = "07";
                    break;
                case "8":
                    textBox27.Text = "08";
                    break;
                case "9":
                    textBox27.Text = "09";
                    break;
                case "E6":
                    textBox27.Text = "18";
                    break;
                case "E7":
                    textBox27.Text = "19";
                    break;
                case "SZ":
                    textBox27.Text = "8";
                    break;
                case "B":
                    textBox27.Text = "8";
                    break;
                default:
                    textBox27.Text = " ";
                    break;
            }
            switch (valasz28)
            {
                case "N6":
                    textBox28.Text = "06";
                    break;
                case "N7":
                    textBox28.Text = "07";
                    break;
                case "8":
                    textBox28.Text = "08";
                    break;
                case "9":
                    textBox28.Text = "09";
                    break;
                case "E6":
                    textBox28.Text = "18";
                    break;
                case "E7":
                    textBox28.Text = "19";
                    break;
                case "SZ":
                    textBox28.Text = "8";
                    break;
                case "B":
                    textBox28.Text = "8";
                    break;
                default:
                    textBox28.Text = " ";
                    break;
            }
            switch (valasz29)
            {
                case "N6":
                    textBox29.Text = "06";
                    break;
                case "N7":
                    textBox29.Text = "07";
                    break;
                case "8":
                    textBox29.Text = "08";
                    break;
                case "9":
                    textBox29.Text = "09";
                    break;
                case "E6":
                    textBox29.Text = "18";
                    break;
                case "E7":
                    textBox29.Text = "19";
                    break;
                case "SZ":
                    textBox29.Text = "8";
                    break;
                case "B":
                    textBox29.Text = "8";
                    break;
                default:
                    textBox29.Text = " ";
                    break;
            }
            switch (valasz30)
            {
                case "N6":
                    textBox30.Text = "06";
                    break;
                case "N7":
                    textBox30.Text = "07";
                    break;
                case "8":
                    textBox30.Text = "08";
                    break;
                case "9":
                    textBox30.Text = "09";
                    break;
                case "E6":
                    textBox30.Text = "18";
                    break;
                case "E7":
                    textBox30.Text = "19";
                    break;
                case "SZ":
                    textBox30.Text = "8";
                    break;
                case "B":
                    textBox30.Text = "8";
                    break;
                default:
                    textBox30.Text = " ";
                    break;
            }
            switch (valasz31)
            {
                case "N6":
                    textBox31.Text = "06";
                    break;
                case "N7":
                    textBox31.Text = "07";
                    break;
                case "8":
                    textBox31.Text = "08";
                    break;
                case "9":
                    textBox31.Text = "09";
                    break;
                case "E6":
                    textBox31.Text = "18";
                    break;
                case "E7":
                    textBox31.Text = "19";
                    break;
                case "SZ":
                    textBox31.Text = "8";
                    break;
                case "B":
                    textBox31.Text = "8";
                    break;
                default:
                    textBox31.Text = " ";
                    break;
            }
            
            if (checkBox2.Checked == true)
            {
                textBox217.Text = "24";
            }



        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox16_SelectedIndexChanged(object sender, EventArgs e)
        {









        }
    }
}
