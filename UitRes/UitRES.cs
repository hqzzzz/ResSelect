using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UitRes
{
    public partial class UitRES : Form
    {


        public class ResA
        {

            public double R0 { get; set; }
            public double R1 { get; set; }
            public double R2 { get; set; }
            public double pRop { get; set; }

            public double dif { get; set; }


        }
        double[] Reslist = {1,2,2.2,4.7,5.1,10,15,20,22,24,27,33,47,49.9,51,56,68,75,82,91,
            100,110,120,130,150,160,180,200,220,240,270,300,330,360,390,430,470,510,560,620,680,750,820,910,
            1000,1100,1200,1500,1800,2000,2200,2400,2700,3000,3300,3600,3900,4300,4700,4990,5100,5600,6200,6800,7500,8200,9100,
            10000,11000,12000,13000,15000,16000,18000,20000,22000,24000,27000,30000,33000,36000,39000,40200,43000,47000,49900,51000,56000,62000,68000,75000,82000,91000,
            1e+05,1.1e+05,1.2e+05,1.3e+05,1.5e+05,1.6e+05,1.8e+05,2e+05,2.2e+05,2.4e+05,2.7e+05,3e+05,3.3e+05,3.6e+05,3.9e+05,4.3e+05,4.7e+05,5.1e+05,5.6e+05,6.2e+05,6.8e+05,7.5e+05,
            1e+06,1.2e+06,1.5e+06,2e+06,2.2e+06,3e+06,4.7e+06,5.1e+06,
            1e+07
            };

        DataView dataView = new DataView();

        List<ResA> ResLis = new List<ResA>();
        public UitRES()
        {
            InitializeComponent();

            CB_Nc.Items.Add(2);
            CB_Nc.Items.Add(3);
            CB_Nc.SelectedIndex = 0;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }


   
   


        private void btnslove2(double Rp)
        {
            double Rpmax = Rp * 1.002;
            double Rpmin = Rp * (1.000 - 0.002);

            ParallelLoopResult result = Parallel.ForEach<double>(Reslist, res =>
            {

                for (int i = 0; i < Reslist.Length; i++)
                {
                        double rop = (double)res /Reslist[i];
                        double dif = (rop - Rp) / Rp;
                        if (rop > Rpmin && rop < Rpmax)
                        {
                        ResLis.Add(new ResA { R1 = res, R2 = Reslist[i], pRop = rop, dif = dif });
                        }

                }
            });

            ResLis = ResLis.OrderBy(u => u.R1 + u.R0).ToList();

            Console.WriteLine("是否完成:{0}", result.IsCompleted);
            dataGridView1.DataSource = ResLis;
            btn_s.Enabled = true;
      
        }



        private void btnslove3(double Rp)
        {
           
            double Rpmax = Rp * 1.001;
            double Rpmin = Rp * (1.000 - 0.001);

            for (int i = 0; i < Reslist.Length; i++)
            {
                ParallelLoopResult result = Parallel.ForEach<double>(Reslist, new ParallelOptions { MaxDegreeOfParallelism = 16 }, res =>
             {

                     for (int j = 0; j < Reslist.Length; j++)
                     {
                         double rop = (double)(res + Reslist[i]) /Reslist[j];
                        double dif = (rop - Rp) / Rp;
                     if (rop > Rpmin && rop < Rpmax)
                         {
                            ResLis.Add(new ResA { R0 = res, R1 = Reslist[i], R2 = Reslist[j], pRop = rop, dif = dif });
                         }
                     }
                 
                
               });
            }


            ResLis= ResLis.OrderBy(u => u.R1+u.R0).ToList();

            dataGridView1.DataSource = ResLis;
            btn_s.Enabled = true;

         
        }


        private void btn_s_Click(object sender, EventArgs e)
        {
            btn_s.Enabled = false;
            double pRop = double.Parse(TB_Rop.Text);

            int Nc = int.Parse(CB_Nc.Text);
            ResLis.Clear();

            if (Nc == 2)
            {
 
                btnslove2(pRop);

            }
            else if (Nc == 3)
            {
               
                btnslove3(pRop);
            }

        }
    }
}
