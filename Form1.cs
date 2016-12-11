using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunkaOraElszamolas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Teljesített óra
            label10.Visible = true;
            decimal teljesitettora = numericUpDown1.Value;
            label10.Text = Convert.ToString(teljesitettora) + " óra";
            //Tanfolyam óra
            decimal tanfolyam;
            decimal tanfolyamora;
            tanfolyam = numericUpDown4.Value;
            tanfolyamora = tanfolyam * 12;
            label13.Visible = true;
            label13.Text = Convert.ToString(tanfolyamora);
            //Betegség óra, szabadság óra
            label11.Visible = true;
            label12.Visible = true;
            string oraszam = listBox1.Text;
            int oraszamsz = Convert.ToInt16(oraszam);
            byte ora;
            double fogl;
            decimal betegseg;
            decimal betegsegora;
            decimal szabadsag;
            decimal szabadsagora;
            decimal tuloraalap;
            decimal tulora;
            decimal ketszaz;
            switch (oraszamsz)
            {
                //teljes állás
                case 152:
                case 160:
                case 168:
                case 176:
                case 184:
                    //Óraszám deklaráció
                    fogl = 1;
                    ora = 8;
                    //Betegség órák
                    betegseg = numericUpDown2.Value;
                    betegsegora = betegseg * ora;
                    label11.Text = Convert.ToString(betegsegora) + " óra";
                    //Szabadság órák
                    szabadsag = numericUpDown3.Value;
                    szabadsagora = szabadsag * ora;
                    label12.Text = Convert.ToString(szabadsagora) + " óra";
                    //Túlóraalap
                    tuloraalap = (teljesitettora + betegsegora + szabadsagora + tanfolyamora);
                    label14.Text = Convert.ToString(tuloraalap) + " óra";
                    label14.Visible = true;
                    //200%
                    ketszaz = numericUpDown8.Value;
                    label7.Text = Convert.ToString(ketszaz);
                    //Túlóra
                    tulora = (tuloraalap - oraszamsz) - ketszaz;
                    label15.Text = Convert.ToString(tulora) + " óra";
                    label15.Visible = true;
                    //Túl sok túlóra
                    if (Convert.ToDouble(tulora) >= 100 * fogl)
                    { label16.Visible = true; }
                    break;
                //0,75
                case 114:
                case 120:
                case 126:
                case 132:
                case 138:
                    ora = 6;
                    fogl = 0.75;
                    //Betegség órák
                    betegseg = numericUpDown2.Value;
                    betegsegora = betegseg * ora;
                    label11.Text = Convert.ToString(betegsegora) + " óra";
                    //Szabadság órák
                    szabadsag = numericUpDown3.Value;
                    szabadsagora = szabadsag * ora;
                    label12.Text = Convert.ToString(szabadsagora) + " óra";
                    //Túlóraalap
                    tuloraalap = (teljesitettora + betegsegora + szabadsagora + tanfolyamora);
                    label14.Text = Convert.ToString(tuloraalap) + " óra";
                    label14.Visible = true;
                    //200%
                    ketszaz = numericUpDown8.Value;
                    label7.Text = Convert.ToString(ketszaz);
                    //Túlóra
                    tulora = (tuloraalap - oraszamsz) - ketszaz;
                    label15.Text = Convert.ToString(tulora) + " óra";
                    label15.Visible = true;
                    //Túl sok túlóra
                    if (Convert.ToDouble(tulora) >= 100 * fogl)
                    { label16.Visible = true; }
                    break;
                //félállás
                case 76:
                case 80:
                case 84:
                case 88:
                case 92:
                    ora = 4;
                    fogl = 0.5;
                    //Betegség órák
                    betegseg = numericUpDown2.Value;
                    betegsegora = betegseg * ora;
                    label11.Text = Convert.ToString(betegsegora) + " óra";
                    //Szabadság órák
                    szabadsag = numericUpDown3.Value;
                    szabadsagora = szabadsag * ora;
                    label12.Text = Convert.ToString(szabadsagora) + " óra";
                    //Túlóraalap
                    tuloraalap = (teljesitettora + betegsegora + szabadsagora + tanfolyamora);
                    label14.Text = Convert.ToString(tuloraalap) + " óra";
                    label14.Visible = true;
                    //200%
                    ketszaz = numericUpDown8.Value;
                    label7.Text = Convert.ToString(ketszaz);
                    //Túlóra
                    tulora = (tuloraalap - oraszamsz) - ketszaz;
                    label15.Text = Convert.ToString(tulora) + " óra";
                    label15.Visible = true;
                    //Túl sok túlóra
                    if (Convert.ToDouble(tulora) >= 100 * fogl)
                    { label16.Visible = true; }
                    break;
                //0,375
                case 57:
                case 60:
                case 63:
                case 66:
                case 69:
                    ora = 3;
                    fogl = 0.375;
                    //Betegség órák
                    betegseg = numericUpDown2.Value;
                    betegsegora = betegseg * ora;
                    label11.Text = Convert.ToString(betegsegora) + " óra";
                    //Szabadság órák
                    szabadsag = numericUpDown3.Value;
                    szabadsagora = szabadsag * ora;
                    label12.Text = Convert.ToString(szabadsagora) + " óra";
                    //Túlóraalap
                    tuloraalap = (teljesitettora + betegsegora + szabadsagora + tanfolyamora);
                    label14.Text = Convert.ToString(tuloraalap) + " óra";
                    label14.Visible = true;
                    //200%
                    ketszaz = numericUpDown8.Value;
                    label7.Text = Convert.ToString(ketszaz);
                    //Túlóra
                    tulora = (tuloraalap - oraszamsz) - ketszaz;
                    label15.Text = Convert.ToString(tulora) + " óra";
                    label15.Visible = true;
                    //Túl sok túlóra
                    if (Convert.ToDouble(tulora) >= 100 * fogl)
                    { label16.Visible = true; }
                    break;
                //0,25
                case 38:
                case 40:
                case 42:
                case 44:
                case 46:
                    ora = 2;
                    fogl = 0.25;
                    //Betegség órák
                    betegseg = numericUpDown2.Value;
                    betegsegora = betegseg * ora;
                    label11.Text = Convert.ToString(betegsegora) + " óra";
                    //Szabadság órák
                    szabadsag = numericUpDown3.Value;
                    szabadsagora = szabadsag * ora;
                    label12.Text = Convert.ToString(szabadsagora) + " óra";
                    //Túlóraalap
                    tuloraalap = (teljesitettora + betegsegora + szabadsagora + tanfolyamora);
                    label14.Text = Convert.ToString(tuloraalap) + " óra";
                    label14.Visible = true;
                    //200%
                    ketszaz = numericUpDown8.Value;
                    label7.Text = Convert.ToString(ketszaz);
                    //Túlóra
                    tulora = (tuloraalap - oraszamsz) - ketszaz;
                    label15.Text = Convert.ToString(tulora) + " óra";
                    label15.Visible = true;
                    //Túl sok túlóra
                    if (Convert.ToDouble(tulora) >= 100 * fogl)
                    { label16.Visible = true; }
                    break;
                //0,125
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                    ora = 1;
                    fogl = 0.125;
                    //Betegség órák
                    betegseg = numericUpDown2.Value;
                    betegsegora = betegseg * ora;
                    label11.Text = Convert.ToString(betegsegora) + " óra";
                    //Szabadság órák
                    szabadsag = numericUpDown3.Value;
                    szabadsagora = szabadsag * ora;
                    label12.Text = Convert.ToString(szabadsagora) + " óra";
                    //Túlóraalap
                    tuloraalap = (teljesitettora + betegsegora + szabadsagora + tanfolyamora);
                    label14.Text = Convert.ToString(tuloraalap) + " óra";
                    label14.Visible = true;
                    //200%
                    ketszaz = numericUpDown8.Value;
                    label7.Text = Convert.ToString(ketszaz);
                    //Túlóra
                    tulora = (tuloraalap - oraszamsz) - ketszaz;
                    label15.Text = Convert.ToString(tulora) + " óra";
                    label15.Visible = true;
                    //Túl sok túlóra
                    if (Convert.ToDouble(tulora) >= 100 * fogl)
                    { label16.Visible = true; }
                    break;
                default:
                    label11.Text = "Érvénytelen óraszám!";
                    label12.Text = "Érvénytelen óraszám!";
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label7.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            label12.Visible = false;
            label13.Visible = false;
            label14.Visible = false;
            label15.Visible = false;
            label16.Visible = false;
            listBox1.SelectedIndex = 0;
            numericUpDown1.Value = 60;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown8.Value = 0;
        }
    }
}
