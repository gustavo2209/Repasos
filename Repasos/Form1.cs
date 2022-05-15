using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Repasos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button3.Visible)
            {
                button3.Visible = false;
            }
            else
            {
                button3.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button3.Enabled)
            {
                button3.Enabled = false;
            }
            else
            {
                button3.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "0";
            this.AcceptButton = button4;

            for(int i=0; i<=20; i++)
            {
                comboBox1.Items.Add("" + +i);
                comboBox2.Items.Add("" + +i);
                comboBox3.Items.Add("" + +i);
            }

            comboBox1.SelectedIndex = 14;
            comboBox2.SelectedItem = "14";
            comboBox3.SelectedIndex = 14;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string texto = textBox1.Text.Trim();

            if (texto.Length > 0)
            {
                listBox1.Items.Add(texto); // ADICIONAR TEXTO A LISTBOX
                textBox1.Text = "";
                label1.Text = listBox1.Items.Count.ToString(); // CANTIDAD DE ELEMENTOS EN LISTBOX
            }
            else
            {
                MessageBox.Show("Digite texto");
            }
            textBox1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // HAY ELEMENTO SELECCIONADO
            if (listBox1.SelectedIndex != -1)
            {
                listBox1.Items.RemoveAt(listBox1.SelectedIndex); // RETIRA ELEMENTO EN EL LISTBOX
                label1.Text = listBox1.Items.Count.ToString();
            }
            else // NO HAY ELEMENTO SELECCIONADO
            {
                MessageBox.Show("Seleccione elemento de la lista");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                textBox2.Text = listBox1.SelectedItem.ToString(); // TOMAR ELEMENTO SELECCIONADO
            }
            else
            {
                MessageBox.Show("Seleccione elemento en la lista");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string msg = "Marcados:  ";

            if (checkBox1.Checked)
            {
                msg += checkBox1.Text + ", ";
            }
            if (checkBox2.Checked)
            {
                msg += checkBox2.Text + ", ";
            }
            if (checkBox3.Checked)
            {
                msg += checkBox3.Text + ", ";
            }
            if (checkBox4.Checked)
            {
                msg += checkBox4.Text + ", ";
            }

            if(msg.Length > 11)
            {
                msg = msg.Substring(0, msg.Length - 2);
                msg += ".";
            }

            MessageBox.Show(msg);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string msg = "Marcado:  ";

            if (radioButton1.Checked)
            {
                msg += radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                msg += radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                msg += radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                msg += radioButton4.Text;
            }

            MessageBox.Show(msg);
        }

        // ESTE EVENTO SE PRODUCE SOLO SI SE MARCA O DESMARCA
        private void cambiaEstado(object sender, EventArgs e)
        {
            string msg = "Marcado:  ";

            if (radioButton1.Checked)
            {
                msg += radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                msg += radioButton2.Text;
            }
            else if (radioButton3.Checked)
            {
                msg += radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                msg += radioButton4.Text;
            }

            MessageBox.Show(msg);
        }

        private void cambiaEstadoCheck(object sender, EventArgs e)
        {
            string msg = "Marcados:  ";

            if (checkBox1.Checked)
            {
                msg += checkBox1.Text + ", ";
            }
            if (checkBox2.Checked)
            {
                msg += checkBox2.Text + ", ";
            }
            if (checkBox3.Checked)
            {
                msg += checkBox3.Text + ", ";
            }
            if (checkBox4.Checked)
            {
                msg += checkBox4.Text + ", ";
            }

            if (msg.Length > 11)
            {
                msg = msg.Substring(0, msg.Length - 2);
                msg += ".";
            }

            MessageBox.Show(msg);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Personas p1 = new Personas();
            Personas p2 = new Personas("Kina Malpartida", "kina@yahoo.es", "666777888");

            // SET (PONER, ASIGNAR)
            p1.Nombre = "Juan Pérez";
            p1.Correo = "juanperez@gmail.com";
            p1.Telefono = "111222333";

            // GET (OBTENER)
            string msg = "";

            msg += p1.Nombre + ", correo: " + p1.Correo + ", telefono: " + p1.Telefono;
            msg += "\r\n";
            msg += p2.Nombre + ", correo: " + p2.Correo + ", telefono: " + p2.Telefono;

            textBox3.Text = msg;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Proveedores prov = new Proveedores();
            Clientes clie = new Clientes("Katia Ruiz", "katia@gmail.com", "999567898");
            Empleados empl = new Empleados("Jefe de Almacén", "Victor Alván", "valvan@gmail.com", "889567445");

            // SETTER
            prov.Ruc = "10077318753";
            prov.Nombre = "Luis Miranda";
            prov.Correo = "lmiranda@yahoo.es";
            prov.Telefono = "999876558";
            clie.Credito = 5000;

            // GETTER
            string msg = "";

            msg += "Proveedor: " + prov.Nombre + "\r\n\tRUC: " + prov.Ruc + "\r\n\tCORREO: " + prov.Correo + "\r\n\tTELEFONO: " + prov.Telefono;
            msg += "\r\n\r\n";

            msg += "Cliente: " + clie.Nombre + "\r\n\tCREDITO: S/. " + clie.Credito + "\r\n\tCORREO: " + clie.Correo + "\r\n\tTELEFONO: " + clie.Telefono;
            msg += "\r\n\r\n";

            msg += "Empleado: " + empl.Nombre + "\r\n\tCARGO: " + empl.Cargo + "\r\n\tCORREO: " + empl.Correo + "\r\n\tTELEFONO: " + empl.Telefono;

            textBox3.Text = msg;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            List<Cds> list = new List<Cds>();

            Cds cd1 = new Cds("Lo mejor de la salsa");
            cd1.Temas.Add(new Temas("La Carta", 340));
            cd1.Temas.Add(new Temas("El Timbalero", 410));

            Cds cd2 = new Cds("Romanticas de los 80");
            cd2.Temas.Add(new Temas("Concavo y Convexo", 190));
            cd2.Temas.Add(new Temas("Un gato en la oscuridad", 350));

            list.Add(cd1);
            list.Add(cd2);

            string msg = "";
            foreach(Cds cd in list)
            {
                msg += "\"" + cd.Titulo + "\" dura: " + cd.duracion() + "\r\n";
            }
            textBox4.Text = msg;
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the currently selected item in the ListBox.
            
            int curItem5 = listBox3.SelectedIndex;
            //MessageBox.Show("" + curItem5);

            // Find the string in ListBox2.
            //listBox2.SetSelected(curItem5, true);
            //curItem5 = -1;
            // If the item was not found in ListBox 2 display a message box, otherwise select it in ListBox2.
            //if (index == -1)
            //{
            //MessageBox.Show("Item is not available in ListBox2");
            //}

            //else
            //{
            //listBox3.SetSelected(index, true);
            //}
        }

        private void listBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            // Get the currently selected item in the ListBox.
            int curItem = listBox2.SelectedIndex;
            //MessageBox.Show("" + curItem);

            // Find the string in ListBox2.
            listBox3.SetSelected(curItem, true);
            //curItem = -1;
            // If the item was not found in ListBox 2 display a message box, otherwise select it in ListBox2.
            //if (index == -1)
            //{
            //MessageBox.Show("Item is not available in ListBox2");
            //}

            //else
            //{
            //listBox3.SetSelected(index, true);
            //}
        }
    }
}
