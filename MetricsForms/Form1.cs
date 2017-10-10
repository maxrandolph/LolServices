using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LolServiceClient= LoLMetrics.LolService;
using MetricsForms.Models;
using MetricsForms.Controllers;

namespace MetricsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string summoner = summonerName.Text.ToString();
            var client = new ServiceCalls();
            var result = client.GetMatches(summoner);
            resultsDisplay.Text = result.ToString();

        }

        private void summonerName_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultsDisplay_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
