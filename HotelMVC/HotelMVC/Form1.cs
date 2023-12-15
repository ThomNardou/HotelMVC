using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelMVC
{
    public partial class Form1 : Form
    {
        private Controller _controller;
        public Controller Controller { get => _controller; set => _controller = value; }

        public Form1()
        {
            InitializeComponent();
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
        }

        public void DissplaySuccess(string message)
        {
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void DissplayError(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
