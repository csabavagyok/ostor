using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunkaOraSzamolo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void valtozikadatum(object sender, EventArgs e)
        {
            //Hónap adatai blokk
            string ev = Convert.ToString(comboBox1.SelectedItem);
            string honap = Convert.ToString(comboBox2.SelectedItem);
            label1.Text = ev + ". " + honap + " kötelező óraszáma:";
            label1.Visible = true;
            short oraszam;
            switch (ev)
            {
                case "2016":
                    switch (honap)
                    {
                        case "január":
                            oraszam = 20 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (január 1.)";
                            label3.Visible = true;
                            break;
                        case "február":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            break;
                        case "március":
                            oraszam = 18 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (március 15. + húsvét)";
                            label3.Visible = true;
                            break;
                        case "április":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            break;
                        case "május":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (május 1. + pünkösd)";
                            label3.Visible = true;
                            break;
                        case "június":
                            oraszam = 22 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            break;
                        case "július":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            break;
                        case "augusztus":
                            oraszam = 23 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (aug. 20.)";
                            label3.Visible = true;
                            break;
                        case "szeptember":
                            oraszam = 22 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            break;
                        case "október":
                            oraszam = 20 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (okt. 20.)";
                            label3.Visible = true;
                            break;
                        case "november":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (nov. 1.)";
                            label3.Visible = true;
                            break;
                        case "december":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (dec. 25, 26.)";
                            label3.Visible = true;
                            break;
                        default:
                            label1.Text = "Adjon meg valós hónapot!";
                            break;
                    }
                    break;
                case "2017":
                    switch (honap)
                    {
                        case "január":
                            oraszam = 22 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (január 1.)";
                            label3.Visible = true;
                            break;
                        case "február":
                            oraszam = 20 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            break;
                        case "március":
                            oraszam = 22 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (márc. 15.)";
                            label3.Visible = true;
                            break;
                        case "április":
                            oraszam = 19 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (Húsvét)";
                            label3.Visible = true;
                            break;
                        case "május":
                            oraszam = 22 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (máj. 1.)";
                            label3.Visible = true;
                            break;
                        case "június":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (Pünkösd)";
                            label3.Visible = true;
                            break;
                        case "július":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            break;
                        case "augusztus":
                            oraszam = 23 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (aug. 20.)";
                            label3.Visible = true;
                            break;
                        case "szeptember":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            break;
                        case "október":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (okt. 20.)";
                            label3.Visible = true;
                            break;
                        case "november":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (nov. 1.)";
                            label3.Visible = true;
                            break;
                        case "december":
                            oraszam = 19 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (dec. 25, 26.)";
                            label3.Visible = true;
                            break;
                        default:
                            label1.Text = "Adjon meg valós hónapot!";
                            label5.Text = "0";
                            break;

                    }
                    break;
                default:
                    label1.Text = "Adjon meg valós évet!";
                    break;
            }//Az év/hónap comboBox-ok switch-case vége
        }
        public void valtozikanev (object sender, EventArgs e)
        {
            string dolgozo = Convert.ToString(comboBox3.SelectedItem);
            double fogl;
            switch (dolgozo)
            {
                //1,0 állású mentőtiszt
                case "Horváth Attila":
                case "Ludrovanová Mária":
                    fogl = 1.00;
                    label9.Text = "Mentőtiszt";
                    label9.Visible = true;
                    label5.Text = Convert.ToString(fogl);
                    label5.Visible = true;
                    label7.Text = Convert.ToString(Convert.ToDouble(label2.Text) * fogl);
                    label7.Visible = true;
                    break;
                //1,0 állású ápoló
                case "Bodzák Gergő":
                case "Fáró Ádám":
                case "Gergely Dezső":
                case "Gregus Dániel":
                case "Hegyi Lajos":
                case "Kiss Imre":
                case "Mahunka Géza":
                case "Major Gyula":
                case "Markos Zoltán":
                case "Nagy János":
                case "Német Tamás":
                case "Polóka Pál":
                case "Proksa Norbert":
                case "Sztudva Richárd":
                case "Tileczky Gábor":
                case "Vakarcs Tamás":
                    fogl = 1.00;
                    label9.Text = "Mentőápoló";
                    label9.Visible = true;
                    label5.Text = Convert.ToString(fogl);
                    label5.Visible = true;
                    label7.Text = Convert.ToString(Convert.ToDouble(label2.Text) * fogl);
                    label7.Visible = true;
                    break;
                //1,0 állású gépkocsivezető
                case "Bottó György":
                case "Farkas Tibor":
                case "Gyulavári Dezső":
                case "Hámori László":
                case "Hamza Mihály":
                case "Helik Attila":
                case "Jászkolics Lajos":
                case "Kálvin Ferenc":
                case "Kovácsik László":
                case "Körmendi István":
                case "Major Zoltán":
                case "Nagy Ferenc":
                case "Oláh Péter":
                case "Palcsek Zoltán":
                case "Rontó Csaba":
                case "Samu Gábor":
                case "Szarka Gyula":
                case "Sztahó Szilárd":
                case "Vass László":
                    fogl = 1.00;
                    label9.Text = "Mentő-gépkocsivezető";
                    label9.Visible = true;
                    label5.Text = Convert.ToString(fogl);
                    label5.Visible = true;
                    label7.Text = Convert.ToString(Convert.ToDouble(label2.Text) * fogl);
                    label7.Visible = true;
                    break;
                //0,75 mentőtiszt
                //0,75 ápoló
                case "Mátraházi Csaba":
                    fogl = 0.75;
                    label9.Text = "Mentőápoló";
                    label9.Visible = true;
                    label5.Text = Convert.ToString(fogl);
                    label5.Visible = true;
                    label7.Text = Convert.ToString(Convert.ToDouble(label2.Text) * fogl);
                    label7.Visible = true;
                    break;
                //0,75 gépkocsivezető
                //0,5 mentőtiszt
                //0,5 ápoló
                case "Óvári Péter":
                case "Szabó Márton":
                case "Vizér Miklós":
                    fogl = 0.50;
                    label9.Text = "Mentőápoló";
                    label9.Visible = true;
                    label5.Text = Convert.ToString(fogl);
                    label5.Visible = true;
                    label7.Text = Convert.ToString(Convert.ToDouble(label2.Text) * fogl);
                    label7.Visible = true;
                    break;
                //0,5 gépkocsivezető
                case "Balla László":
                case "Kiss Balázs":
                case "Paróczi Róbert":
                    fogl = 0.50;
                    label9.Text = "Mentő-gépkocsivezető";
                    label9.Visible = true;
                    label5.Text = Convert.ToString(fogl);
                    label5.Visible = true;
                    label7.Text = Convert.ToString(Convert.ToDouble(label2.Text) * fogl);
                    label7.Visible = true;
                    break;
                //0,375 mentőtiszt
                case "Fekete Előd":
                case "Néninger Tibor":
                    fogl = 0.375;
                    label9.Text = "Mentőtiszt";
                    label9.Visible = true;
                    label5.Text = Convert.ToString(fogl);
                    label5.Visible = true;
                    label7.Text = Convert.ToString(Convert.ToDouble(label2.Text) * fogl);
                    label7.Visible = true;
                    break;
                //0,375 ápoló
                //0,375 gépkocsivezető
                //0,25 mentőtiszt
                case "Kópházi Luca":
                case "Morvai Dóra":
                    fogl = 0.25;
                    label9.Text = "Mentőtiszt";
                    label9.Visible = true;
                    label5.Text = Convert.ToString(fogl);
                    label5.Visible = true;
                    label7.Text = Convert.ToString(Convert.ToDouble(label2.Text) * fogl);
                    label7.Visible = true;
                    break;
                //0,25 ápoló
                case "Tárkányi Gábor":
                    fogl = 0.25;
                    label9.Text = "Mentőápoló";
                    label9.Visible = true;
                    label5.Text = Convert.ToString(fogl);
                    label5.Visible = true;
                    label7.Text = Convert.ToString(Convert.ToDouble(label2.Text) * fogl);
                    label7.Visible = true;
                    break;
                //0,25 gépkocsivezető
                //0,125 mentőtiszt
                case "Nyéki Judit":
                    fogl = 0.125;
                    label9.Text = "Mentőtiszt";
                    label9.Visible = true;
                    label5.Text = Convert.ToString(fogl);
                    label5.Visible = true;
                    label7.Text = Convert.ToString(Convert.ToDouble(label2.Text) * fogl);
                    label7.Visible = true;
                    break;
                //0,125 ápoló
                //0,125 gépkocsivezető
                default:
                    label5.Text = "0";
                    label7.Text = "0";
                    label9.Text = "Érvénytelen dolgozó.";
                    label9.Visible = true;
                    break;
            }//Dolgozó adatbevitel vége

        }
        public void valtozikazoraszam_6_18 (object sender, EventArgs e)
        {
            label30.Text = Convert.ToString(numericUpDown1.Value * 4);
        }
        public void valtozikazoraszam_7_19 (object sender, EventArgs e)
        {
            label31.Text = Convert.ToString(numericUpDown2.Value * 5);
        }
        public void valtozikazoraszam_8_20 (object sender, EventArgs e)
        {
            label32.Text = Convert.ToString(numericUpDown3.Value * 6);
        }
        public void valtozikazoraszam_9_21 (object sender, EventArgs e)
        {
            label33.Text = Convert.ToString(numericUpDown4.Value * 7);
        }
        public void valtozikazoraszam_18_6 (object sender, EventArgs e)
        {
            label34.Text = Convert.ToString(numericUpDown5.Value * 4);
            label37.Text = Convert.ToString(numericUpDown5.Value * 8);
        }
        public void valtozikazoraszam_19_7 (object sender, EventArgs e)
        {
            label35.Text = Convert.ToString(numericUpDown6.Value * 3);
            label38.Text = Convert.ToString(numericUpDown6.Value * 8);
        }
        public void valtozikazoraszam_7_7 (object sender, EventArgs e)
        {
            label36.Text = Convert.ToString(numericUpDown7.Value * 8);
            label39.Text = Convert.ToString(numericUpDown7.Value * 8);
        }
        public void valtozikatulora_du (object sender, EventArgs e)
        {
            label43.Text = Convert.ToString(numericUpDown8.Value);
        }
        public void valtozikatulora_ej (object sender, EventArgs e)
        {
            label44.Text = Convert.ToString(numericUpDown9.Value);
            label45.Text = Convert.ToString(numericUpDown9.Value);
        }
        public void evvalasztas (object sender, EventArgs e)
        {
            comboBox3.Enabled = false;
        }
        public void button1_Click(object sender, EventArgs e)
        {
            //Hónap adatai blokk
            string ev = Convert.ToString(comboBox1.SelectedItem);
            string honap = Convert.ToString(comboBox2.SelectedItem);
            label1.Text = ev + ". " + honap + " kötelező óraszáma:";
            label1.Visible = true;
            short oraszam;
            switch (ev)
            {
                case "2016":
                    switch (honap)
                    {
                        case "január":
                            oraszam = 20 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (január 1.)";
                            label3.Visible = true;
                            break;
                        case "február":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            break;
                        case "március":
                            oraszam = 18 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (március 15. + húsvét)";
                            label3.Visible = true;
                            break;
                        case "április":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            break;
                        case "május":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (május 1. + pünkösd)";
                            label3.Visible = true;
                            break;
                        case "június":
                            oraszam = 22 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            break;
                        case "július":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            break;
                        case "augusztus":
                            oraszam = 23 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (aug. 20.)";
                            label3.Visible = true;
                            break;
                        case "szeptember":
                            oraszam = 22 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            break;
                        case "október":
                            oraszam = 20 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (okt. 20.)";
                            label3.Visible = true;
                            break;
                        case "november":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (nov. 1.)";
                            label3.Visible = true;
                            break;
                        case "december":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (dec. 25, 26.)";
                            label3.Visible = true;
                            break;
                        default:
                            label1.Text = "Adjon meg valós hónapot!";
                            break;
                    }
                    break;
                case "2017":
                    switch (honap)
                    {
                        case "január":
                            oraszam = 22 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (január 1.)";
                            label3.Visible = true;
                            break;
                        case "február":
                            oraszam = 20 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            break;
                        case "március":
                            oraszam = 22 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (márc. 15.)";
                            label3.Visible = true;
                            break;
                        case "április":
                            oraszam = 19 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (Húsvét)";
                            label3.Visible = true;
                            break;
                        case "május":
                            oraszam = 22 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (máj. 1.)";
                            label3.Visible = true;
                            break;
                        case "június":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (Pünkösd)";
                            label3.Visible = true;
                            break;
                        case "július":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            break;
                        case "augusztus":
                            oraszam = 23 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (aug. 20.)";
                            label3.Visible = true;
                            break;
                        case "szeptember":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            break;
                        case "október":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (okt. 20.)";
                            label3.Visible = true;
                            break;
                        case "november":
                            oraszam = 21 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (nov. 1.)";
                            label3.Visible = true;
                            break;
                        case "december":
                            oraszam = 19 * 8;
                            label2.Text = Convert.ToString(oraszam);
                            label2.Visible = true;
                            label3.Text = honap + " hónapban kollektív ünnep van! (dec. 25, 26.)";
                            label3.Visible = true;
                            break;
                        default:
                            label1.Text = "Adjon meg valós hónapot!";
                            label5.Text = "0";
                            break;

                    }
                    break;
                default:
                    label1.Text = "Adjon meg valós évet!";
                    break;
            }//Az év/hónap comboBox-ok switch-case vége
            //Dolgozó adatai blokk
            string dolgozo = Convert.ToString(comboBox3.SelectedItem);
            double fogl;
            switch (dolgozo)
            {
                //1,0 állású mentőtiszt
                case "Horváth Attila":
                case "Ludrovanová Mária":
                    fogl = 1.00;
                    label9.Text = "Mentőtiszt";
                    label9.Visible = true;
                    label5.Text = Convert.ToString(fogl);
                    label5.Visible = true;
                    label7.Text = Convert.ToString(Convert.ToDouble(label2.Text) * fogl);
                    label7.Visible = true;
                    break;
                //1,0 állású ápoló
                case "Bodzák Gergő":
                case "Fáró Ádám":
                case "Gergely Dezső":
                case "Gregus Dániel":
                case "Hegyi Lajos":
                case "Kiss Imre":
                case "Mahunka Géza":
                case "Major Gyula":
                case "Markos Zoltán":
                case "Nagy János":
                case "Német Tamás":
                case "Polóka Pál":
                case "Proksa Norbert":
                case "Sztudva Richárd":
                case "Tileczky Gábor":
                case "Vakarcs Tamás":
                    fogl = 1.00;
                    label9.Text = "Mentőápoló";
                    label9.Visible = true;
                    label5.Text = Convert.ToString(fogl);
                    label5.Visible = true;
                    label7.Text = Convert.ToString(Convert.ToDouble(label2.Text) * fogl);
                    label7.Visible = true;
                    break;
                //1,0 állású gépkocsivezető
                case "Bottó György":
                case "Farkas Tibor":
                case "Gyulavári Dezső":
                case "Hámori László":
                case "Hamza Mihály":
                case "Helik Attila":
                case "Jászkolics Lajos":
                case "Kálvin Ferenc":
                case "Kovácsik László":
                case "Körmendi István":
                case "Major Zoltán":
                case "Nagy Ferenc":
                case "Oláh Péter":
                case "Palcsek Zoltán":
                case "Rontó Csaba":
                case "Samu Gábor":
                case "Szarka Gyula":
                case "Sztahó Szilárd":
                case "Vass László":
                    fogl = 1.00;
                    label9.Text = "Mentő-gépkocsivezető";
                    label9.Visible = true;
                    label5.Text = Convert.ToString(fogl);
                    label5.Visible = true;
                    label7.Text = Convert.ToString(Convert.ToDouble(label2.Text) * fogl);
                    label7.Visible = true;
                    break;
                //0,75 mentőtiszt
                //0,75 ápoló
                case "Mátraházi Csaba":
                    fogl = 0.75;
                    label9.Text = "Mentőápoló";
                    label9.Visible = true;
                    label5.Text = Convert.ToString(fogl);
                    label5.Visible = true;
                    label7.Text = Convert.ToString(Convert.ToDouble(label2.Text) * fogl);
                    label7.Visible = true;
                    break;
                //0,75 gépkocsivezető
                //0,5 mentőtiszt
                //0,5 ápoló
                case "Óvári Péter":
                case "Szabó Márton":
                case "Vizér Miklós":
                    fogl = 0.50;
                    label9.Text = "Mentőápoló";
                    label9.Visible = true;
                    label5.Text = Convert.ToString(fogl);
                    label5.Visible = true;
                    label7.Text = Convert.ToString(Convert.ToDouble(label2.Text) * fogl);
                    label7.Visible = true;
                    break;
                //0,5 gépkocsivezető
                case "Balla László":
                case "Kiss Balázs":
                case "Paróczi Róbert":
                    fogl = 0.50;
                    label9.Text = "Mentő-gépkocsivezető";
                    label9.Visible = true;
                    label5.Text = Convert.ToString(fogl);
                    label5.Visible = true;
                    label7.Text = Convert.ToString(Convert.ToDouble(label2.Text) * fogl);
                    label7.Visible = true;
                    break;
                //0,375 mentőtiszt
                case "Fekete Előd":
                case "Néninger Tibor":
                    fogl = 0.375;
                    label9.Text = "Mentőtiszt";
                    label9.Visible = true;
                    label5.Text = Convert.ToString(fogl);
                    label5.Visible = true;
                    label7.Text = Convert.ToString(Convert.ToDouble(label2.Text) * fogl);
                    label7.Visible = true;
                    break;
                //0,375 ápoló
                //0,375 gépkocsivezető
                //0,25 mentőtiszt
                case "Kópházi Luca":
                case "Morvai Dóra":
                    fogl = 0.25;
                    label9.Text = "Mentőtiszt";
                    label9.Visible = true;
                    label5.Text = Convert.ToString(fogl);
                    label5.Visible = true;
                    label7.Text = Convert.ToString(Convert.ToDouble(label2.Text) * fogl);
                    label7.Visible = true;
                    break;
                //0,25 ápoló
                case "Tárkányi Gábor":
                    fogl = 0.25;
                    label9.Text = "Mentőápoló";
                    label9.Visible = true;
                    label5.Text = Convert.ToString(fogl);
                    label5.Visible = true;
                    label7.Text = Convert.ToString(Convert.ToDouble(label2.Text) * fogl);
                    label7.Visible = true;
                    break;
                //0,25 gépkocsivezető
                //0,125 mentőtiszt
                case "Nyéki Judit":
                    fogl = 0.125;
                    label9.Text = "Mentőtiszt";
                    label9.Visible = true;
                    label5.Text = Convert.ToString(fogl);
                    label5.Visible = true;
                    label7.Text = Convert.ToString(Convert.ToDouble(label2.Text) * fogl);
                    label7.Visible = true;
                    break;
                //0,125 ápoló
                //0,125 gépkocsivezető
                default:
                    label5.Text = "0";
                    label7.Text = "0";
                    label9.Text = "Érvénytelen dolgozó.";
                    label9.Visible = true;
                    break;
            }//Dolgozó adatbevitel vége
            //Szolgálatok adatai blokk
            decimal tuloraalap = 0;
            decimal osszteljora = 0;
            decimal teljesitettora = 0;
            decimal dupotlek = 0;
            decimal osszdupotlek = 0;
            decimal ejpotlek = 0;
            decimal osszejpotlek = 0;
            label30.Text = Convert.ToString(numericUpDown1.Value * 4);
            dupotlek += Convert.ToDecimal(label30.Text);
            label30.Visible = true;
            label31.Text = Convert.ToString(numericUpDown2.Value * 5);
            dupotlek += Convert.ToDecimal(label31.Text);
            label31.Visible = true;
            label32.Text = Convert.ToString(numericUpDown3.Value * 6);
            dupotlek += Convert.ToDecimal(label32.Text);
            label32.Visible = true;
            label33.Text = Convert.ToString(numericUpDown4.Value * 7);
            dupotlek += Convert.ToDecimal(label33.Text);
            label33.Visible = true;
            label34.Text = Convert.ToString(numericUpDown5.Value * 4);
            label37.Text = Convert.ToString(numericUpDown5.Value * 8);
            dupotlek += Convert.ToDecimal(label34.Text);
            ejpotlek += Convert.ToDecimal(label37.Text);
            label34.Visible = true;
            label37.Visible = true;
            label35.Text = Convert.ToString(numericUpDown6.Value * 3);
            label38.Text = Convert.ToString(numericUpDown6.Value * 8);
            dupotlek += Convert.ToDecimal(label35.Text);
            ejpotlek += Convert.ToDecimal(label38.Text);
            label35.Visible = true;
            label38.Visible = true;
            label36.Text = Convert.ToString(numericUpDown7.Value * 8);
            label39.Text = Convert.ToString(numericUpDown7.Value * 8);
            dupotlek += Convert.ToDecimal(label36.Text);
            ejpotlek += Convert.ToDecimal(label39.Text);
            label36.Visible = true;
            label39.Visible = true;
            teljesitettora = numericUpDown1.Value * 12 + numericUpDown2.Value * 12 + numericUpDown3.Value * 12
                + numericUpDown4.Value * 12 + numericUpDown5.Value * 12 + numericUpDown6.Value * 12
                + numericUpDown7.Value * 24;
            label40.Text = Convert.ToString(teljesitettora) + " óra";
            label40.Visible = true;
            label41.Text = Convert.ToString(dupotlek);
            label41.Visible = true;
            label42.Text = Convert.ToString(ejpotlek);
            label42.Visible = true;
            osszdupotlek += dupotlek;
            osszejpotlek += ejpotlek;
            tuloraalap += teljesitettora;
            osszteljora = teljesitettora;
            //Szolgálatok adatai blokk vége
            //Túlóra blokk
            decimal dutulora = 0;
            decimal ejtulora = 0;
            decimal detulora = 0;
            decimal ossztulora = 0;
            label43.Text = Convert.ToString(numericUpDown8.Value);
            label43.Visible = true;
            dutulora += numericUpDown8.Value;
            label44.Text = Convert.ToString(numericUpDown9.Value);
            label45.Text = Convert.ToString(numericUpDown9.Value);
            label44.Visible = true;
            label45.Visible = true;
            ejtulora += numericUpDown9.Value;
            detulora += numericUpDown10.Value;
            ossztulora = dutulora + ejtulora + detulora;
            label46.Text = Convert.ToString(ossztulora) + " óra";
            label46.Visible = true;
            osszdupotlek += dutulora;
            osszejpotlek += ejtulora;
            tuloraalap += ossztulora;
            osszteljora += ossztulora;
            //Túlóra blokk vége
            //Szabadság, betegség blokk
            decimal szabiora = 0;
            decimal betegora = 0;
            decimal osszszabi = 0;
            betegora = Convert.ToDecimal(label5.Text) * 8 * numericUpDown11.Value;
            label48.Text = Convert.ToString(betegora);
            label48.Visible = true;
            szabiora = Convert.ToDecimal(label5.Text) * 8 * numericUpDown12.Value;
            label49.Text = Convert.ToString(szabiora);
            label49.Visible = true;
            osszszabi = betegora + szabiora;
            label50.Text = Convert.ToString(osszszabi);
            label50.Visible = true;
            tuloraalap += osszszabi;
            //Szabadság, betegség blokk vége
            //Egyéb óra blokk
            decimal tanfolyamora = 0;
            decimal mozgo = 0;
            decimal athozott = 0;
            decimal athozotttulora = 0;
            decimal atvitt = 0;
            tanfolyamora = numericUpDown13.Value * 12;
            label55.Text = Convert.ToString(tanfolyamora);
            label55.Visible = true;
            tuloraalap += tanfolyamora;
            mozgo = numericUpDown14.Value;
            label56.Text = Convert.ToString(mozgo);
            label56.Visible = true;
            osszteljora += mozgo;
            tuloraalap += mozgo;
            athozott = numericUpDown15.Value;
            label57.Text = Convert.ToString(athozott);
            label57.Visible = true;
            osszteljora += athozott;
            tuloraalap += athozott;
            athozotttulora = numericUpDown16.Value;
            label58.Text = Convert.ToString(athozotttulora);
            label58.Visible = true;
            osszteljora += athozotttulora;
            tuloraalap += athozotttulora;
            atvitt = numericUpDown17.Value;
            label59.Text = "-" + Convert.ToString(atvitt);
            label59.Visible = true;
            osszteljora -= atvitt;
            tuloraalap -= atvitt;
            //Egyéb óra blokk vége
            //Összesítés
            label66.Text = Convert.ToString(osszteljora);
            label66.Visible = true;
            label67.Text = Convert.ToString(tuloraalap);
            label67.Visible = true;
            decimal tulora = 0;
            tulora = tuloraalap - Convert.ToDecimal(label7.Text);
            label68.Text = Convert.ToString(tulora);
            label68.Visible = true;
            label69.Text = Convert.ToString(osszdupotlek);
            label69.Visible = true;
            label70.Text = Convert.ToString(osszejpotlek);
            label70.Visible = true;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            comboBox3.Text = "Dolgozó";
            label9.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
            numericUpDown4.Value = 0;
            numericUpDown5.Value = 0;
            numericUpDown6.Value = 0;
            numericUpDown7.Value = 0;
            label30.Visible = false;
            label31.Visible = false;
            label32.Visible = false;
            label33.Visible = false;
            label34.Visible = false;
            label35.Visible = false;
            label36.Visible = false;
            label37.Visible = false;
            label38.Visible = false;
            label39.Visible = false;
            label40.Visible = false;
            label41.Visible = false;
            label42.Visible = false;
            numericUpDown8.Value = 0;
            numericUpDown9.Value = 0;
            numericUpDown10.Value = 0;
            label43.Visible = false;
            label44.Visible = false;
            label45.Visible = false;
            label46.Visible = false;
            numericUpDown11.Value = 0;
            numericUpDown12.Value = 0;
            label48.Visible = false;
            label49.Visible = false;
            label50.Visible = false;
            numericUpDown13.Value = 0;
            numericUpDown14.Value = 0;
            numericUpDown15.Value = 0;
            numericUpDown16.Value = 0;
            numericUpDown17.Value = 0;
            label55.Visible = false;
            label56.Visible = false;
            label57.Visible = false;
            label58.Visible = false;
            label59.Visible = false;
            label66.Visible = false;
            label67.Visible = false;
            label68.Visible = false;
            label69.Visible = false;
            label70.Visible = false;
        }
    }
}
