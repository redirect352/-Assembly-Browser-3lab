using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AssemblyBrowser;
using AssemblyBrowser.DescriptionsGenerators;

using System.Text.Json;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       


        private void Form1_Load(object sender, EventArgs e)
        {
            JsonSerializerOptions options = new JsonSerializerOptions ();
            options.AllowTrailingCommas = false;
            options.WriteIndented = true;
            AssemblyViever assembly = new AssemblyViever();
            assembly.VievAssembly();
            textBox1.Text =  JsonSerializer.Serialize(assembly, options).Replace("\\u003C","<").Replace("\\u003E", ">");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
