
namespace DatosPC
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnObtenerDatos = new System.Windows.Forms.Button();
            this.btLimpiarDatosPC = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lSerieBios = new System.Windows.Forms.Label();
            this.tbSerie = new System.Windows.Forms.TextBox();
            this.lSerieBoard = new System.Windows.Forms.Label();
            this.tbSerieBoard = new System.Windows.Forms.TextBox();
            this.lSerieRAM1 = new System.Windows.Forms.Label();
            this.tbSerieRAM1 = new System.Windows.Forms.TextBox();
            this.lTamañoRAM1 = new System.Windows.Forms.Label();
            this.tbTamañoRAM1 = new System.Windows.Forms.TextBox();
            this.lPesoDisco = new System.Windows.Forms.Label();
            this.tbPesoDisco = new System.Windows.Forms.TextBox();
            this.lMarcaDisco = new System.Windows.Forms.Label();
            this.tbMarcaDisco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSerieDisco = new System.Windows.Forms.TextBox();
            this.lMarca = new System.Windows.Forms.Label();
            this.tbMarca = new System.Windows.Forms.TextBox();
            this.lModelo = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.lUsuario = new System.Windows.Forms.Label();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lProcesador = new System.Windows.Forms.Label();
            this.tbProcesador = new System.Windows.Forms.TextBox();
            this.lOS = new System.Windows.Forms.Label();
            this.tbOS = new System.Windows.Forms.TextBox();
            this.btGuardarDatosPC = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // btnObtenerDatos
            // 
            this.btnObtenerDatos.Location = new System.Drawing.Point(38, 39);
            this.btnObtenerDatos.Name = "btnObtenerDatos";
            this.btnObtenerDatos.Size = new System.Drawing.Size(166, 44);
            this.btnObtenerDatos.TabIndex = 0;
            this.btnObtenerDatos.Text = "Obtener Datos PC";
            this.btnObtenerDatos.UseVisualStyleBackColor = true;
            this.btnObtenerDatos.Click += new System.EventHandler(this.btnObtenerDatos_Click);
            // 
            // btLimpiarDatosPC
            // 
            this.btLimpiarDatosPC.Location = new System.Drawing.Point(440, 39);
            this.btLimpiarDatosPC.Name = "btLimpiarDatosPC";
            this.btLimpiarDatosPC.Size = new System.Drawing.Size(166, 44);
            this.btLimpiarDatosPC.TabIndex = 15;
            this.btLimpiarDatosPC.Text = "Limpiar Datos PC";
            this.btLimpiarDatosPC.UseVisualStyleBackColor = true;
            this.btLimpiarDatosPC.Click += new System.EventHandler(this.btLimpiarDatosPC_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivo txt(*.txt)|*.txt";
            // 
            // lSerieBios
            // 
            this.lSerieBios.AutoSize = true;
            this.lSerieBios.Location = new System.Drawing.Point(35, 166);
            this.lSerieBios.Name = "lSerieBios";
            this.lSerieBios.Size = new System.Drawing.Size(77, 17);
            this.lSerieBios.TabIndex = 1;
            this.lSerieBios.Text = "Serie BIOS";
            this.lSerieBios.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbSerie
            // 
            this.tbSerie.Location = new System.Drawing.Point(155, 161);
            this.tbSerie.Name = "tbSerie";
            this.tbSerie.Size = new System.Drawing.Size(219, 22);
            this.tbSerie.TabIndex = 2;
            this.tbSerie.TextChanged += new System.EventHandler(this.tbSerie_TextChanged);
            // 
            // lSerieBoard
            // 
            this.lSerieBoard.AutoSize = true;
            this.lSerieBoard.Location = new System.Drawing.Point(35, 205);
            this.lSerieBoard.Name = "lSerieBoard";
            this.lSerieBoard.Size = new System.Drawing.Size(83, 17);
            this.lSerieBoard.TabIndex = 3;
            this.lSerieBoard.Text = "Serie Board";
            this.lSerieBoard.Click += new System.EventHandler(this.label2_Click);
            // 
            // tbSerieBoard
            // 
            this.tbSerieBoard.Location = new System.Drawing.Point(155, 200);
            this.tbSerieBoard.Name = "tbSerieBoard";
            this.tbSerieBoard.Size = new System.Drawing.Size(219, 22);
            this.tbSerieBoard.TabIndex = 4;
            this.tbSerieBoard.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lSerieRAM1
            // 
            this.lSerieRAM1.AutoSize = true;
            this.lSerieRAM1.Location = new System.Drawing.Point(35, 328);
            this.lSerieRAM1.Name = "lSerieRAM1";
            this.lSerieRAM1.Size = new System.Drawing.Size(87, 17);
            this.lSerieRAM1.TabIndex = 5;
            this.lSerieRAM1.Text = "Serie RAM 1";
            // 
            // tbSerieRAM1
            // 
            this.tbSerieRAM1.Location = new System.Drawing.Point(155, 325);
            this.tbSerieRAM1.Name = "tbSerieRAM1";
            this.tbSerieRAM1.Size = new System.Drawing.Size(219, 22);
            this.tbSerieRAM1.TabIndex = 6;
            // 
            // lTamañoRAM1
            // 
            this.lTamañoRAM1.AutoSize = true;
            this.lTamañoRAM1.Location = new System.Drawing.Point(35, 374);
            this.lTamañoRAM1.Name = "lTamañoRAM1";
            this.lTamañoRAM1.Size = new System.Drawing.Size(102, 17);
            this.lTamañoRAM1.TabIndex = 7;
            this.lTamañoRAM1.Text = "Tamaño RAM1";
            // 
            // tbTamañoRAM1
            // 
            this.tbTamañoRAM1.Location = new System.Drawing.Point(155, 371);
            this.tbTamañoRAM1.Name = "tbTamañoRAM1";
            this.tbTamañoRAM1.Size = new System.Drawing.Size(219, 22);
            this.tbTamañoRAM1.TabIndex = 8;
            // 
            // lPesoDisco
            // 
            this.lPesoDisco.AutoSize = true;
            this.lPesoDisco.Location = new System.Drawing.Point(380, 250);
            this.lPesoDisco.Name = "lPesoDisco";
            this.lPesoDisco.Size = new System.Drawing.Size(79, 17);
            this.lPesoDisco.TabIndex = 9;
            this.lPesoDisco.Text = "Peso Disco";
            // 
            // tbPesoDisco
            // 
            this.tbPesoDisco.Location = new System.Drawing.Point(480, 245);
            this.tbPesoDisco.Name = "tbPesoDisco";
            this.tbPesoDisco.Size = new System.Drawing.Size(281, 22);
            this.tbPesoDisco.TabIndex = 10;
            // 
            // lMarcaDisco
            // 
            this.lMarcaDisco.AutoSize = true;
            this.lMarcaDisco.Location = new System.Drawing.Point(380, 166);
            this.lMarcaDisco.Name = "lMarcaDisco";
            this.lMarcaDisco.Size = new System.Drawing.Size(86, 17);
            this.lMarcaDisco.TabIndex = 11;
            this.lMarcaDisco.Text = "Marca Disco";
            // 
            // tbMarcaDisco
            // 
            this.tbMarcaDisco.Location = new System.Drawing.Point(480, 161);
            this.tbMarcaDisco.Name = "tbMarcaDisco";
            this.tbMarcaDisco.Size = new System.Drawing.Size(281, 22);
            this.tbMarcaDisco.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(380, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Serie Disco";
            // 
            // tbSerieDisco
            // 
            this.tbSerieDisco.Location = new System.Drawing.Point(480, 201);
            this.tbSerieDisco.Name = "tbSerieDisco";
            this.tbSerieDisco.Size = new System.Drawing.Size(281, 22);
            this.tbSerieDisco.TabIndex = 14;
            // 
            // lMarca
            // 
            this.lMarca.AutoSize = true;
            this.lMarca.Location = new System.Drawing.Point(35, 247);
            this.lMarca.Name = "lMarca";
            this.lMarca.Size = new System.Drawing.Size(47, 17);
            this.lMarca.TabIndex = 16;
            this.lMarca.Text = "Marca";
            // 
            // tbMarca
            // 
            this.tbMarca.Location = new System.Drawing.Point(155, 242);
            this.tbMarca.Name = "tbMarca";
            this.tbMarca.Size = new System.Drawing.Size(219, 22);
            this.tbMarca.TabIndex = 17;
            // 
            // lModelo
            // 
            this.lModelo.AutoSize = true;
            this.lModelo.Location = new System.Drawing.Point(35, 287);
            this.lModelo.Name = "lModelo";
            this.lModelo.Size = new System.Drawing.Size(54, 17);
            this.lModelo.TabIndex = 18;
            this.lModelo.Text = "Modelo";
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(155, 282);
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(219, 22);
            this.tbModelo.TabIndex = 19;
            // 
            // lUsuario
            // 
            this.lUsuario.AutoSize = true;
            this.lUsuario.Location = new System.Drawing.Point(35, 117);
            this.lUsuario.Name = "lUsuario";
            this.lUsuario.Size = new System.Drawing.Size(57, 17);
            this.lUsuario.TabIndex = 20;
            this.lUsuario.Text = "Usuario";
            // 
            // tbUsuario
            // 
            this.tbUsuario.Location = new System.Drawing.Point(155, 112);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(219, 22);
            this.tbUsuario.TabIndex = 21;
            // 
            // lProcesador
            // 
            this.lProcesador.AutoSize = true;
            this.lProcesador.Location = new System.Drawing.Point(380, 117);
            this.lProcesador.Name = "lProcesador";
            this.lProcesador.Size = new System.Drawing.Size(81, 17);
            this.lProcesador.TabIndex = 22;
            this.lProcesador.Text = "Procesador";
            // 
            // tbProcesador
            // 
            this.tbProcesador.Location = new System.Drawing.Point(480, 112);
            this.tbProcesador.Name = "tbProcesador";
            this.tbProcesador.Size = new System.Drawing.Size(281, 22);
            this.tbProcesador.TabIndex = 23;
            // 
            // lOS
            // 
            this.lOS.AutoSize = true;
            this.lOS.Location = new System.Drawing.Point(380, 287);
            this.lOS.Name = "lOS";
            this.lOS.Size = new System.Drawing.Size(28, 17);
            this.lOS.TabIndex = 24;
            this.lOS.Text = "OS";
            // 
            // tbOS
            // 
            this.tbOS.Location = new System.Drawing.Point(480, 282);
            this.tbOS.Name = "tbOS";
            this.tbOS.Size = new System.Drawing.Size(281, 22);
            this.tbOS.TabIndex = 25;
            // 
            // btGuardarDatosPC
            // 
            this.btGuardarDatosPC.Location = new System.Drawing.Point(480, 347);
            this.btGuardarDatosPC.Name = "btGuardarDatosPC";
            this.btGuardarDatosPC.Size = new System.Drawing.Size(166, 44);
            this.btGuardarDatosPC.TabIndex = 26;
            this.btGuardarDatosPC.Text = "Guardar Datos PC";
            this.btGuardarDatosPC.UseVisualStyleBackColor = true;
            this.btGuardarDatosPC.Click += new System.EventHandler(this.btGuardarDatosPC_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btGuardarDatosPC);
            this.Controls.Add(this.tbOS);
            this.Controls.Add(this.lOS);
            this.Controls.Add(this.tbProcesador);
            this.Controls.Add(this.lProcesador);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.lUsuario);
            this.Controls.Add(this.tbModelo);
            this.Controls.Add(this.lModelo);
            this.Controls.Add(this.tbMarca);
            this.Controls.Add(this.lMarca);
            this.Controls.Add(this.btLimpiarDatosPC);
            this.Controls.Add(this.tbSerieDisco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMarcaDisco);
            this.Controls.Add(this.lMarcaDisco);
            this.Controls.Add(this.tbPesoDisco);
            this.Controls.Add(this.lPesoDisco);
            this.Controls.Add(this.tbTamañoRAM1);
            this.Controls.Add(this.lTamañoRAM1);
            this.Controls.Add(this.tbSerieRAM1);
            this.Controls.Add(this.lSerieRAM1);
            this.Controls.Add(this.tbSerieBoard);
            this.Controls.Add(this.lSerieBoard);
            this.Controls.Add(this.tbSerie);
            this.Controls.Add(this.lSerieBios);
            this.Controls.Add(this.btnObtenerDatos);
            this.Name = "Form1";
            this.Text = "Datos PC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnObtenerDatos;
        private System.Windows.Forms.Button btLimpiarDatosPC;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lSerieBios;
        private System.Windows.Forms.TextBox tbSerie;
        private System.Windows.Forms.Label lSerieBoard;
        private System.Windows.Forms.TextBox tbSerieBoard;
        private System.Windows.Forms.Label lSerieRAM1;
        private System.Windows.Forms.TextBox tbSerieRAM1;
        private System.Windows.Forms.Label lTamañoRAM1;
        private System.Windows.Forms.TextBox tbTamañoRAM1;
        private System.Windows.Forms.Label lPesoDisco;
        private System.Windows.Forms.TextBox tbPesoDisco;
        private System.Windows.Forms.Label lMarcaDisco;
        private System.Windows.Forms.TextBox tbMarcaDisco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSerieDisco;
        private System.Windows.Forms.Label lMarca;
        private System.Windows.Forms.TextBox tbMarca;
        private System.Windows.Forms.Label lModelo;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.Label lUsuario;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lProcesador;
        private System.Windows.Forms.TextBox tbProcesador;
        private System.Windows.Forms.Label lOS;
        private System.Windows.Forms.TextBox tbOS;
        private System.Windows.Forms.Button btGuardarDatosPC;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

