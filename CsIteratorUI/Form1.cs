using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CsIterator;
namespace CsIteratorUI
{
    public partial class Form1 : Form
    {

        private AbstractIterator iterador;
        private AbstractCollection collection = new ItemsCollection();
        public Form1()
        {
            iterador = collection.CreateIterator();
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Item item = new Item(textBoxNombreItem.Text);
            collection.Agregar(item);
            Listar();
        }
        private void Listar()
        {
            richTextBox1.Text = "";
            iterador.First();
            Item i = iterador.CurrentItem();
            if(i != null) {
                richTextBox1.Text = i.Nombre + "\n";
            }
            while (iterador.TieneSiguiente())
            {
                iterador.Siguiente();
                richTextBox1.Text += iterador.CurrentItem() + "\n";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            iterador.First();
            Item item = iterador.CurrentItem();
            if(item!= null)
            {
                textBoxPrimero.Text = iterador.CurrentItem().Nombre;
                textBoxSiguiente.Text = textBoxPrimero.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (iterador.TieneSiguiente())
            {
            iterador.Siguiente();
            Item item = iterador.CurrentItem();
            textBoxSiguiente.Text = item.Nombre;
            }
        }
    }
}
