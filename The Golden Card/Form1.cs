using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace The_Golden_Card
{
    public partial class Guldkortet : Form
    {
        Network network = new Network();
        Collection<Card> cardCollection = new Collection<Card>();
        Collection<Customer> customerCollection = new Collection<Customer>();

        public Guldkortet()
        {
            InitializeComponent();
        }

        private void StartServer_Click(object sender, EventArgs e)
        {
            try
            {
                network.StartServer();
                MessageBox.Show("Waiting for a connection...", Text);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void StopServer_Click(object sender, EventArgs e)
        {
            network.StopServer();
        }
    }
}
