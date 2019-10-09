using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            inputStart.Maximum = long.MaxValue;
            inputEnd.Maximum = long.MaxValue;
        }

        List<Task> tasks = new List<Task>();

        PrimeTool pt = new PrimeTool();
        List<long> primeList = new List<long>();

        private async void PrimesButtonPara(object sender, EventArgs e)
        {
            this.primeList = await PrimeTool.GetPrimesParallelAsync(Convert.ToInt64(inputStart.Value), Convert.ToInt64(inputEnd.Value));

            this.PopulateListBox();
        }

        private async void PrimesButtonSequ(object sender, EventArgs e)
        {
            this.primeList = await PrimeTool.GetPrimesSequentialAsync(Convert.ToInt64(inputStart.Value), Convert.ToInt64(inputEnd.Value));

            this.PopulateListBox();
        }


        private void PopulateListBox()
        {
            this.listBoxPrimes.Items.Clear();

            string[] stringArray = Array.ConvertAll<long, string>(this.primeList.ToArray(),
               delegate (long i)
               {
                   return i.ToString();
               });

            this.listBoxPrimes.BeginUpdate();

            this.listBoxPrimes.Items.AddRange(stringArray);

            this.listBoxPrimes.EndUpdate();
        }

    }
}
