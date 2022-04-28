using System;
using System.IO;
using System.Management;
using System.Windows.Forms;

namespace DatosPC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnObtenerDatos_Click(object sender, EventArgs e)
        {
            ManagementObjectSearcher ComSerial = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS");
            ManagementObjectSearcher ComBaseBoard = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            ManagementObjectSearcher ComDisco = new ManagementObjectSearcher("SELECT * FROM Win32_diskdrive");
            ManagementObjectSearcher ComRAM = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMemory");
            ManagementObjectSearcher ComMarcaM = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystemProduct");
            ManagementObjectSearcher ComUser = new ManagementObjectSearcher("SELECT * FROM Win32_ComputerSystem");
            ManagementObjectSearcher ComProcesador = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            ManagementObjectSearcher ComOS = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");

            foreach (ManagementObject wmi in ComUser.Get())
            {
                try
                {
                    tbUsuario.Text = wmi.GetPropertyValue("UserName").ToString();
                }
                catch (Exception) { tbUsuario.Text = "Error, No hay datos!"; }
            }

            foreach (ManagementObject wmi in ComSerial.Get())
            {
                try
                {
                    tbSerie.Text = wmi.GetPropertyValue("SerialNumber").ToString();
                }
                catch (Exception) { tbSerie.Text = "Error, No hay datos!"; }
            }

            foreach (ManagementObject wmi in ComBaseBoard.Get())
            {
                try
                {
                    tbSerieBoard.Text = wmi.GetPropertyValue("SerialNumber").ToString();
                }
                catch (Exception) { tbSerieBoard.Text = "Error, No hay datos!"; }
            }

            foreach (ManagementObject wmi in ComMarcaM.Get())
            {
                try
                {
                    tbMarca.Text = wmi.GetPropertyValue("Name").ToString();
                    tbModelo.Text = wmi.GetPropertyValue("Vendor").ToString();
                }
                catch (Exception)
                {
                    tbMarca.Text = "Error, No hay datos!";
                    tbModelo.Text = "Error, No hay datos!";
                }
            }

            foreach (ManagementObject wmi in ComRAM.Get())
            {
                try
                {
                    tbTamañoRAM1.Text = wmi.GetPropertyValue("Capacity").ToString();
                    tbSerieRAM1.Text = wmi.GetPropertyValue("SerialNumber").ToString();
                }
                catch (Exception)
                {
                    tbTamañoRAM1.Text = "Error, No hay datos!";
                    tbSerieRAM1.Text = "Error, No hay datos!";
                }
            }

            foreach (ManagementObject wmi in ComProcesador.Get())
            {
                try
                {
                    tbProcesador.Text = wmi.GetPropertyValue("Name").ToString();
                }
                catch (Exception) { tbProcesador.Text = "Error, No hay datos!"; }
            }

            foreach (ManagementObject wmi in ComDisco.Get())
            {
                try
                {
                    tbMarcaDisco.Text = wmi.GetPropertyValue("model").ToString();
                    tbSerieDisco.Text = wmi.GetPropertyValue("SerialNumber").ToString();
                    tbPesoDisco.Text = wmi.GetPropertyValue("size").ToString();
                }
                catch (Exception)
                {
                    tbMarcaDisco.Text = "Error, No hay datos!";
                    tbSerieDisco.Text = "Error, No hay datos!";
                    tbPesoDisco.Text = "Error, No hay datos!";
                }
            }

            foreach (ManagementObject wmi in ComOS.Get())
            {
                try
                {
                    tbOS.Text = wmi.GetPropertyValue("Caption").ToString();
                }
                catch (Exception) { tbOS.Text = "Error, No hay datos!"; }
            }

        }

        private void tbSerie_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLimpiarDatosPC_Click(object sender, EventArgs e)
        {
            tbUsuario.Text = "";
            tbSerie.Text = "";
            tbSerieBoard.Text = "";
            tbMarca.Text = "";
            tbModelo.Text = "";
            tbSerieRAM1.Text = "";
            tbTamañoRAM1.Text = "";
            tbSerieDisco.Text = "";
            tbMarcaDisco.Text = "";
            tbPesoDisco.Text = "";
            tbProcesador.Text = "";
            tbOS.Text = "";

        }

        private void btGuardarDatosPC_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog1.FileName;
                TextWriter archivo = new StreamWriter(path);
                archivo.Close();
                using (StreamWriter sw = File.CreateText(path))
                {

                    sw.WriteLine("Usuario: " + tbUsuario.Text);
                    sw.WriteLine("Serie Bios: " + tbSerie.Text);
                    sw.WriteLine("Serie Board: " + tbSerieBoard.Text);
                    sw.WriteLine("Marca: " + tbMarca.Text);
                    sw.WriteLine("Modelo: " + tbModelo.Text);
                    sw.WriteLine("Serie RAM: " + tbSerieRAM1.Text);
                    sw.WriteLine("Peso RAM: " + tbTamañoRAM1.Text);
                    sw.WriteLine("Serie Disco: " + tbSerieDisco.Text);
                    sw.WriteLine("Marca Disco:" + tbMarcaDisco.Text);
                    sw.WriteLine("Peso Disco:" + tbPesoDisco.Text);
                    sw.WriteLine("Procesador: " + tbProcesador.Text);
                    sw.WriteLine("SO: " + tbOS.Text);
                }
            }
            MessageBox.Show("Guardado con exito!");
        }
    }
}
