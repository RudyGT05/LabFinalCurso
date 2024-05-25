namespace LabFinalCurso
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
            this.btprobarconexion = new System.Windows.Forms.Button();
            this.btmodeloinsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbidconsola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbnombrecon = new System.Windows.Forms.TextBox();
            this.tbaniolan = new System.Windows.Forms.TextBox();
            this.tbgeneracion = new System.Windows.Forms.TextBox();
            this.comboBoxcompania = new System.Windows.Forms.ComboBox();
            this.dataGridViewcatalogo = new System.Windows.Forms.DataGridView();
            this.btcargar = new System.Windows.Forms.Button();
            this.btupdate = new System.Windows.Forms.Button();
            this.btelim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btprobarconexion
            // 
            this.btprobarconexion.Location = new System.Drawing.Point(657, 268);
            this.btprobarconexion.Name = "btprobarconexion";
            this.btprobarconexion.Size = new System.Drawing.Size(122, 45);
            this.btprobarconexion.TabIndex = 0;
            this.btprobarconexion.Text = "Probar Conexion";
            this.btprobarconexion.UseVisualStyleBackColor = true;
            this.btprobarconexion.Click += new System.EventHandler(this.btprobarconexion_Click);
            // 
            // btmodeloinsertar
            // 
            this.btmodeloinsertar.Location = new System.Drawing.Point(62, 239);
            this.btmodeloinsertar.Name = "btmodeloinsertar";
            this.btmodeloinsertar.Size = new System.Drawing.Size(75, 23);
            this.btmodeloinsertar.TabIndex = 1;
            this.btmodeloinsertar.Text = "Insertar";
            this.btmodeloinsertar.UseVisualStyleBackColor = true;
            this.btmodeloinsertar.Click += new System.EventHandler(this.btmodeloinsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID Consola";
            // 
            // tbidconsola
            // 
            this.tbidconsola.Location = new System.Drawing.Point(180, 21);
            this.tbidconsola.Name = "tbidconsola";
            this.tbidconsola.Size = new System.Drawing.Size(174, 20);
            this.tbidconsola.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre Consola";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Compañia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Año Lanzamiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Generacion";
            // 
            // tbnombrecon
            // 
            this.tbnombrecon.Location = new System.Drawing.Point(180, 65);
            this.tbnombrecon.Name = "tbnombrecon";
            this.tbnombrecon.Size = new System.Drawing.Size(174, 20);
            this.tbnombrecon.TabIndex = 8;
            // 
            // tbaniolan
            // 
            this.tbaniolan.Location = new System.Drawing.Point(180, 141);
            this.tbaniolan.Name = "tbaniolan";
            this.tbaniolan.Size = new System.Drawing.Size(174, 20);
            this.tbaniolan.TabIndex = 10;
            // 
            // tbgeneracion
            // 
            this.tbgeneracion.Location = new System.Drawing.Point(180, 180);
            this.tbgeneracion.Name = "tbgeneracion";
            this.tbgeneracion.Size = new System.Drawing.Size(174, 20);
            this.tbgeneracion.TabIndex = 11;
            // 
            // comboBoxcompania
            // 
            this.comboBoxcompania.FormattingEnabled = true;
            this.comboBoxcompania.Location = new System.Drawing.Point(180, 102);
            this.comboBoxcompania.Name = "comboBoxcompania";
            this.comboBoxcompania.Size = new System.Drawing.Size(174, 21);
            this.comboBoxcompania.TabIndex = 12;
            // 
            // dataGridViewcatalogo
            // 
            this.dataGridViewcatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewcatalogo.Location = new System.Drawing.Point(360, 12);
            this.dataGridViewcatalogo.Name = "dataGridViewcatalogo";
            this.dataGridViewcatalogo.Size = new System.Drawing.Size(428, 198);
            this.dataGridViewcatalogo.TabIndex = 13;
            // 
            // btcargar
            // 
            this.btcargar.Location = new System.Drawing.Point(529, 268);
            this.btcargar.Name = "btcargar";
            this.btcargar.Size = new System.Drawing.Size(122, 45);
            this.btcargar.TabIndex = 14;
            this.btcargar.Text = "Cargar Datos";
            this.btcargar.UseVisualStyleBackColor = true;
            this.btcargar.Click += new System.EventHandler(this.btcargar_Click);
            // 
            // btupdate
            // 
            this.btupdate.Location = new System.Drawing.Point(143, 239);
            this.btupdate.Name = "btupdate";
            this.btupdate.Size = new System.Drawing.Size(75, 23);
            this.btupdate.TabIndex = 15;
            this.btupdate.Text = "Actualizar";
            this.btupdate.UseVisualStyleBackColor = true;
            this.btupdate.Click += new System.EventHandler(this.btupdate_Click);
            // 
            // btelim
            // 
            this.btelim.Location = new System.Drawing.Point(224, 239);
            this.btelim.Name = "btelim";
            this.btelim.Size = new System.Drawing.Size(75, 23);
            this.btelim.TabIndex = 16;
            this.btelim.Text = "Eliminar";
            this.btelim.UseVisualStyleBackColor = true;
            this.btelim.Click += new System.EventHandler(this.btelim_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btelim);
            this.Controls.Add(this.btupdate);
            this.Controls.Add(this.btcargar);
            this.Controls.Add(this.dataGridViewcatalogo);
            this.Controls.Add(this.comboBoxcompania);
            this.Controls.Add(this.tbgeneracion);
            this.Controls.Add(this.tbaniolan);
            this.Controls.Add(this.tbnombrecon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbidconsola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btmodeloinsertar);
            this.Controls.Add(this.btprobarconexion);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewcatalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btprobarconexion;
        private System.Windows.Forms.Button btmodeloinsertar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbidconsola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbnombrecon;
        private System.Windows.Forms.TextBox tbaniolan;
        private System.Windows.Forms.TextBox tbgeneracion;
        private System.Windows.Forms.ComboBox comboBoxcompania;
        private System.Windows.Forms.DataGridView dataGridViewcatalogo;
        private System.Windows.Forms.Button btcargar;
        private System.Windows.Forms.Button btupdate;
        private System.Windows.Forms.Button btelim;
    }
}

