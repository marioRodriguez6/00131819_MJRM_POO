namespace Labo_09
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnInscripcion = new System.Windows.Forms.Button();
            this.btnMateria = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnESudiante = new System.Windows.Forms.Button();
            this.registerStudent1 = new Labo_09.RegisterStudent();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEstudiante = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnInscripcion, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnMateria, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnConsultar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnESudiante, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.registerStudent1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnInscripcion
            // 
            this.btnInscripcion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnInscripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInscripcion.Location = new System.Drawing.Point(403, 3);
            this.btnInscripcion.Name = "btnInscripcion";
            this.btnInscripcion.Size = new System.Drawing.Size(194, 48);
            this.btnInscripcion.TabIndex = 2;
            this.btnInscripcion.Text = "Inscripcion";
            this.btnInscripcion.UseVisualStyleBackColor = true;
            this.btnInscripcion.Click += new System.EventHandler(this.btnInscripcion_Click);
            // 
            // btnMateria
            // 
            this.btnMateria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMateria.Location = new System.Drawing.Point(203, 3);
            this.btnMateria.Name = "btnMateria";
            this.btnMateria.Size = new System.Drawing.Size(194, 48);
            this.btnMateria.TabIndex = 3;
            this.btnMateria.Text = "Materia";
            this.btnMateria.UseVisualStyleBackColor = true;
            this.btnMateria.Click += new System.EventHandler(this.btnMateria_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConsultar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConsultar.Location = new System.Drawing.Point(603, 3);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(194, 48);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click_1);
            // 
            // btnESudiante
            // 
            this.btnESudiante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnESudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnESudiante.Location = new System.Drawing.Point(3, 3);
            this.btnESudiante.Name = "btnESudiante";
            this.btnESudiante.Size = new System.Drawing.Size(194, 48);
            this.btnESudiante.TabIndex = 5;
            this.btnESudiante.Text = "Estudiante";
            this.btnESudiante.UseVisualStyleBackColor = true;
            this.btnESudiante.Click += new System.EventHandler(this.btnESudiante_Click);
            // 
            // registerStudent1
            // 
            this.registerStudent1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.registerStudent1, 4);
            this.registerStudent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerStudent1.Location = new System.Drawing.Point(3, 57);
            this.registerStudent1.Name = "registerStudent1";
            this.registerStudent1.Size = new System.Drawing.Size(794, 390);
            this.registerStudent1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.tableLayoutPanel2.SetRowSpan(this.label1, 2);
            this.label1.Size = new System.Drawing.Size(44, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombres:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(3, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 84);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellidos:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel3.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.tableLayoutPanel3.SetRowSpan(this.label3, 2);
            this.label3.Size = new System.Drawing.Size(44, 100);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombres:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(3, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 84);
            this.label4.TabIndex = 1;
            this.label4.Text = "Apellidos:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnEstudiante
            // 
            this.btnEstudiante.Location = new System.Drawing.Point(0, 0);
            this.btnEstudiante.Name = "btnEstudiante";
            this.btnEstudiante.Size = new System.Drawing.Size(75, 23);
            this.btnEstudiante.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEstudiante;
        private System.Windows.Forms.Button btnESudiante;
        private System.Windows.Forms.Button btnInscripcion;
        private System.Windows.Forms.Button btnMateria;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Labo_09.RegisterStudent registerStudent1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;

        #endregion
    }
}