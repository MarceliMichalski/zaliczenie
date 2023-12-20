using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace zaliczenie
{
    public partial class Form1 : Form
    {
        public List<SortowanieElementarne> elements;
        public List<SortowanieZlozone> elem;
        public List<RadioButton> przyciski;
        public Babelkowe b;
        public WedlugWyboru w;
        public PrzezScalanie s;
        public PrzezWstawianie ws;
        public Szybkie sz;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b = new Babelkowe();
            w = new WedlugWyboru();
            ws = new PrzezWstawianie();
            sz = new Szybkie();
            s = new PrzezScalanie();
            przyciski = new List<RadioButton>();
            elements = new List<SortowanieElementarne>();
            elem = new List<SortowanieZlozone>();

            if (int.TryParse(this.textBox1.Text, out int v) &&
                int.TryParse(this.textBox2.Text, out int v2) &&
                int.TryParse(this.textBox3.Text, out int v3) &&
                                                    v3 >= v2 &&
                                               v <= (v3 - v2))
            {
                b.dlugosc = v;
                b.od = v2;
                b.dO = v3;

                w.dlugosc = v;
                w.od = v2;
                w.dO = v3;

                s.dlugosc = v;
                s.od = v2;
                s.dO = v3;

                sz.dlugosc = v;
                sz.od = v2;
                sz.dO = v3;

                ws.dlugosc = v;
                ws.od = v2;
                ws.dO = v3;

                b.t = new int[b.dlugosc];
                w.t = new int[w.dlugosc];
                s.t = new int[s.dlugosc];
                ws.t = new int[ws.dlugosc];
                sz.t = new int[sz.dlugosc];

                elements.Add(b);
                elements.Add(w);
                elements.Add(ws);
                elem.Add(s);
                elem.Add(sz);

                foreach (SortowanieElementarne sort in elements)
                {
                    if (sort is Babelkowe b)
                    {
                        if (radioButton4.Checked == true)
                        {
                            if (radioButton3.Checked == true)
                            {
                                b.los(b.t);
                                chart1.Series.Clear();
                                chart1.Series.Add("Wykres");
                                b.wykres(chart1, b.t);
                            }
                            else if (radioButton2.Checked == true)
                            {
                                b.mal(b.t);
                                chart1.Series.Clear();
                                chart1.Series.Add("Wykres");
                                b.wykres(chart1, b.t);
                            }
                            else if (radioButton1.Checked == true)
                            {
                                b.ros(b.t);
                                chart1.Series.Clear();
                                chart1.Series.Add("Wykres");
                                b.wykres(chart1, b.t);
                            }
                        }
                    }
                    else if (sort is WedlugWyboru wedlug)
                    {
                        if (radioButton8.Checked == true)
                        {
                            if (radioButton3.Checked == true)
                            {
                                wedlug.los(wedlug.t);
                                chart1.Series.Clear();
                                chart1.Series.Add("Wykres");
                                wedlug.wykres(chart1, wedlug.t);
                            }
                            else if (radioButton2.Checked == true)
                            {
                                wedlug.mal(wedlug.t);
                                chart1.Series.Clear();
                                chart1.Series.Add("Wykres");
                                wedlug.wykres(chart1, wedlug.t);
                            }
                            else if (radioButton1.Checked == true)
                            {
                                wedlug.ros(wedlug.t);
                                chart1.Series.Clear();
                                chart1.Series.Add("Wykres");
                                wedlug.wykres(chart1, wedlug.t);
                            }
                        }
                    }
                    else if (sort is PrzezWstawianie ws)
                    {
                        if (radioButton5.Checked == true)
                        {
                            if (radioButton3.Checked == true)
                            {
                                ws.los(ws.t);
                                chart1.Series.Clear();
                                chart1.Series.Add("Wykres");
                                ws.wykres(chart1, ws.t);
                            }
                            else if (radioButton2.Checked == true)
                            {
                                ws.mal(ws.t);
                                chart1.Series.Clear();
                                chart1.Series.Add("Wykres");
                                ws.wykres(chart1, ws.t);
                            }
                            else if (radioButton1.Checked == true)
                            {
                                ws.ros(ws.t);
                                chart1.Series.Clear();
                                chart1.Series.Add("Wykres");
                                ws.wykres(chart1, ws.t);
                            }
                        }
                    }
                }

                foreach (SortowanieZlozone z in elem)
                {
                    if (z is Szybkie sz)
                    {
                        if (radioButton7.Checked == true)
                        {
                            if (radioButton3.Checked == true)
                            {
                                sz.los(sz.t);
                                chart1.Series.Clear();
                                chart1.Series.Add("Wykres");
                                sz.wykres(chart1, sz.t);
                            }
                            else if (radioButton2.Checked == true)
                            {
                                sz.mal(sz.t);
                                chart1.Series.Clear();
                                chart1.Series.Add("Wykres");
                                sz.wykres(chart1, sz.t);
                            }
                            else if (radioButton1.Checked == true)
                            {
                                sz.ros(sz.t);
                                chart1.Series.Clear();
                                chart1.Series.Add("Wykres");
                                sz.wykres(chart1, sz.t);
                            }
                        }
                    }
                    else if (z is PrzezScalanie sc)
                    {
                        if (radioButton6.Checked == true)
                        {

                            if (radioButton3.Checked == true)
                            {
                                sc.los(sc.t);
                                chart1.Series.Clear();
                                chart1.Series.Add("Wykres");
                                sc.wykres(chart1, sc.t);
                            }
                            else if (radioButton2.Checked == true)
                            {
                                sc.mal(sc.t);
                                chart1.Series.Clear();
                                chart1.Series.Add("Wykres");
                                sc.wykres(chart1, sc.t);
                            }
                            else if (radioButton1.Checked == true)
                            {
                                sc.ros(sc.t);
                                chart1.Series.Clear();
                                chart1.Series.Add("Wykres");
                                sc.wykres(chart1, sc.t);
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Podano nieprawidłowe wartości w jednym z pól. Wprowadź poprawne liczby.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch czas = new Stopwatch();
             
            foreach (SortowanieElementarne el in elements)
            {
                if (el is Babelkowe b)
                {
                    if (radioButton4.Checked == true)
                    {
                        if (radioButton3.Checked == true)
                        {
                            czas.Start();
                            b.Sortuj(b.t);
                            czas.Stop();
                            chart1.Series.Clear();
                            chart1.Series.Add("Wykres");
                            b.wykres(chart1, b.t);
                            textBox4.Text =czas.ElapsedMilliseconds.ToString() + "milisekundy";
                        }
                        else if (radioButton2.Checked == true)
                        {
                            czas.Start();
                            b.Sortuj(b.t);
                            czas.Stop();
                            chart1.Series.Clear();
                            chart1.Series.Add("Wykres");
                            b.wykres(chart1, b.t);
                            textBox4.Text = czas.ElapsedMilliseconds.ToString() + "milisekundy";
                        }
                        else if (radioButton1.Checked == true)
                        {
                            czas.Start();
                            b.Sortuj(b.t);
                            czas.Stop();
                            chart1.Series.Clear();
                            chart1.Series.Add("Wykres");
                            b.wykres(chart1, b.t);
                            textBox4.Text = czas.ElapsedMilliseconds.ToString() + "milisekundy";
                        }
                    }
                } else if(el is PrzezWstawianie ws)
                      {
                             if(radioButton5.Checked == true) 
                    {
                        if (radioButton3.Checked == true)
                        {
                            czas.Start();
                            ws.Sortuj(ws.t);
                            czas.Stop();
                            chart1.Series.Clear();
                            chart1.Series.Add("Wykres");
                            ws.wykres(chart1, ws.t);
                            textBox4.Text = czas.ElapsedMilliseconds.ToString() + "milisekundy";
                        }
                        else if (radioButton2.Checked == true)
                        {
                            czas.Start();
                            ws.Sortuj(ws.t);
                            czas.Stop();
                            chart1.Series.Clear();
                            chart1.Series.Add("Wykres");
                            ws.wykres(chart1, ws.t);
                            textBox4.Text = czas.ElapsedMilliseconds.ToString() + "milisekundy";
                        }
                        else if (radioButton1.Checked == true)
                        {
                            czas.Start();
                            ws.Sortuj(ws.t);
                            czas.Stop();
                            chart1.Series.Clear();
                            chart1.Series.Add("Wykres");
                            ws.wykres(chart1, ws.t);
                            textBox4.Text = czas.ElapsedMilliseconds.ToString() + "milisekundy";
                        }
                    }
                      }else if(el is WedlugWyboru wy)
                {
                    if(radioButton8.Checked == true)
                      {
                        if (radioButton3.Checked == true)
                        {
                            czas.Start();
                            wy.Sortuj(wy.t);
                            czas.Stop();
                            chart1.Series.Clear();
                            chart1.Series.Add("Wykres");
                            wy.wykres(chart1, wy.t);
                            textBox4.Text = czas.ElapsedMilliseconds.ToString() + "milisekundy";
                        }
                        else if (radioButton2.Checked == true)
                        {
                            czas.Start();
                            wy.Sortuj(wy.t);
                            czas.Stop();
                            chart1.Series.Clear();
                            chart1.Series.Add("Wykres");
                            wy.wykres(chart1, wy.t);
                            textBox4.Text = czas.ElapsedMilliseconds.ToString() + "milisekundy";
                        }
                        else if (radioButton1.Checked == true)
                        {
                            czas.Start();
                            wy.Sortuj(wy.t);
                            czas.Stop();
                            chart1.Series.Clear();
                            chart1.Series.Add("Wykres");
                            wy.wykres(chart1, wy.t);
                            textBox4.Text = czas.ElapsedMilliseconds.ToString() + "milisekundy";
                        }
                    }
                }
            }

            foreach(SortowanieZlozone zl in elem)
            {
                if(zl is PrzezScalanie sc)
                {
                    if(radioButton6.Checked == true) 
                    {
                        if (radioButton3.Checked == true)
                        {
                            czas.Start();
                            sc.Sortuj(sc.t,0,sc.dlugosc-1);
                            czas.Stop();
                            chart1.Series.Clear();
                            chart1.Series.Add("Wykres");
                            sc.wykres(chart1, sc.t);
                            textBox4.Text = czas.ElapsedMilliseconds.ToString() + "milisekundy";
                        }
                        else if (radioButton2.Checked == true)
                        {
                            czas.Start();
                            sc.Sortuj(sc.t,0 ,sc.dlugosc-1);
                            czas.Stop();
                            chart1.Series.Clear();
                            chart1.Series.Add("Wykres");
                            sc.wykres(chart1, sc.t);
                            textBox4.Text = czas.ElapsedMilliseconds.ToString() + "milisekundy";
                        }
                        else if (radioButton1.Checked == true)
                        {
                            czas.Start();
                            sc.Sortuj(sc.t,0,sc.dlugosc-1);
                            czas.Stop();
                            chart1.Series.Clear();
                            chart1.Series.Add("Wykres");
                            sc.wykres(chart1, sc.t);
                            textBox4.Text = czas.ElapsedMilliseconds.ToString() + "milisekundy";
                        }
                    }
                } else if(zl is Szybkie szybkie) 
                  { 
                       if(radioButton7.Checked == true) 
                       {
                        if (radioButton3.Checked == true)
                        {
                            czas.Start();
                            szybkie.Sortuj(szybkie.t, 0, szybkie.dlugosc - 1);
                            czas.Stop();
                            chart1.Series.Clear();
                            chart1.Series.Add("Wykres");
                            szybkie.wykres(chart1, szybkie.t);
                            textBox4.Text = czas.ElapsedMilliseconds.ToString() + "milisekundy";
                        }
                        else if (radioButton2.Checked == true)
                        {
                            czas.Start();
                            szybkie.Sortuj(szybkie.t, 0, szybkie.dlugosc - 1);
                            czas.Stop();
                            chart1.Series.Clear();
                            chart1.Series.Add("Wykres");
                            szybkie.wykres(chart1, szybkie.t);
                            textBox4.Text = czas.ElapsedMilliseconds.ToString() + "milisekundy";
                        }
                        else if (radioButton1.Checked == true)
                        {
                            czas.Start();
                            szybkie.Sortuj(szybkie.t, 0, szybkie.dlugosc - 1);
                            czas.Stop();
                            chart1.Series.Clear();
                            chart1.Series.Add("Wykres");
                            szybkie.wykres(chart1, szybkie.t);
                            textBox4.Text = czas.ElapsedMilliseconds.ToString() + "milisekundy";
                        }
                    }                
                  }
            }
        }
    }
}