namespace CompiladorCSharp
{
    partial class Principal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.TextCode = new System.Windows.Forms.RichTextBox();
            this.btn_Analizar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.descripcion = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TableKT = new System.Windows.Forms.DataGridView();
            this.KeyTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescripcionKeyTerm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.TableTok = new System.Windows.Forms.DataGridView();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.Consola = new System.Windows.Forms.TabPage();
            this.Consola1 = new System.Windows.Forms.RichTextBox();
            this.btn_Abrir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnArbol = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.PictureBox();
            this.btnMaximizar = new System.Windows.Forms.PictureBox();
            this.btnMinimizar = new System.Windows.Forms.PictureBox();
            this.btnRestaurar = new System.Windows.Forms.PictureBox();
            this.btnConSonido = new System.Windows.Forms.PictureBox();
            this.btnSinSonido = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableKT)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableTok)).BeginInit();
            this.tabControl2.SuspendLayout();
            this.Consola.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConSonido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSinSonido)).BeginInit();
            this.SuspendLayout();
            // 
            // TextCode
            // 
            this.TextCode.DetectUrls = false;
            this.TextCode.Location = new System.Drawing.Point(53, 80);
            this.TextCode.Name = "TextCode";
            this.TextCode.Size = new System.Drawing.Size(559, 335);
            this.TextCode.TabIndex = 1;
            this.TextCode.Text = "";
            this.TextCode.ZoomFactor = 2F;
            // 
            // btn_Analizar
            // 
            this.btn_Analizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Analizar.BackgroundImage = global::CompiladorCSharp.Properties.Resources.BtnAnalizar;
            this.btn_Analizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Analizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Analizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_Analizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Analizar.Location = new System.Drawing.Point(53, 425);
            this.btn_Analizar.Name = "btn_Analizar";
            this.btn_Analizar.Size = new System.Drawing.Size(100, 29);
            this.btn_Analizar.TabIndex = 2;
            this.btn_Analizar.UseVisualStyleBackColor = false;
            this.btn_Analizar.Click += new System.EventHandler(this.btn_Analizar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Transparent;
            this.btn_Guardar.BackgroundImage = global::CompiladorCSharp.Properties.Resources.BtnGuardar;
            this.btn_Guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Guardar.Location = new System.Drawing.Point(265, 425);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(100, 29);
            this.btn_Guardar.TabIndex = 3;
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Game of Thrones", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(655, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(317, 378);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.descripcion);
            this.tabPage1.Location = new System.Drawing.Point(4, 20);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(309, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Descripcion";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // descripcion
            // 
            this.descripcion.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcion.Location = new System.Drawing.Point(0, 0);
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Size = new System.Drawing.Size(309, 351);
            this.descripcion.TabIndex = 0;
            this.descripcion.Text = "El siguiente analizador Lexico y Sintactico esta hecho para un nuevo lenguaje lla" +
    "mado \"Not Today\" basado en CSharp.\nPara mayor informacion revise la documentacio" +
    "n presente en la carpeta.";
            this.descripcion.TextChanged += new System.EventHandler(this.descripcion_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TableKT);
            this.tabPage2.Location = new System.Drawing.Point(4, 20);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(309, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Palabras Reservadas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TableKT
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableKT.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TableKT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableKT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KeyTerm,
            this.DescripcionKeyTerm});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableKT.DefaultCellStyle = dataGridViewCellStyle2;
            this.TableKT.Location = new System.Drawing.Point(0, 0);
            this.TableKT.Name = "TableKT";
            this.TableKT.ReadOnly = true;
            this.TableKT.RowHeadersVisible = false;
            this.TableKT.Size = new System.Drawing.Size(306, 354);
            this.TableKT.TabIndex = 0;
            // 
            // KeyTerm
            // 
            this.KeyTerm.HeaderText = "KeyTerm";
            this.KeyTerm.Name = "KeyTerm";
            this.KeyTerm.ReadOnly = true;
            this.KeyTerm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.KeyTerm.Width = 120;
            // 
            // DescripcionKeyTerm
            // 
            this.DescripcionKeyTerm.HeaderText = "Descripcion";
            this.DescripcionKeyTerm.Name = "DescripcionKeyTerm";
            this.DescripcionKeyTerm.ReadOnly = true;
            this.DescripcionKeyTerm.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DescripcionKeyTerm.Width = 190;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.TableTok);
            this.tabPage3.Location = new System.Drawing.Point(4, 20);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(309, 354);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tokens";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // TableTok
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableTok.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.TableTok.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableTok.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Token,
            this.Desc});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TableTok.DefaultCellStyle = dataGridViewCellStyle4;
            this.TableTok.Location = new System.Drawing.Point(-2, 0);
            this.TableTok.Name = "TableTok";
            this.TableTok.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TableTok.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.TableTok.RowHeadersVisible = false;
            this.TableTok.Size = new System.Drawing.Size(315, 354);
            this.TableTok.TabIndex = 0;
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.Name = "Token";
            this.Token.ReadOnly = true;
            this.Token.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Token.Width = 120;
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Descripcion";
            this.Desc.Name = "Desc";
            this.Desc.ReadOnly = true;
            this.Desc.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Desc.Width = 195;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.Consola);
            this.tabControl2.Font = new System.Drawing.Font("Game of Thrones", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl2.Location = new System.Drawing.Point(188, 471);
            this.tabControl2.Multiline = true;
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(769, 128);
            this.tabControl2.TabIndex = 5;
            // 
            // Consola
            // 
            this.Consola.Controls.Add(this.Consola1);
            this.Consola.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Consola.Location = new System.Drawing.Point(4, 22);
            this.Consola.Name = "Consola";
            this.Consola.Padding = new System.Windows.Forms.Padding(3);
            this.Consola.Size = new System.Drawing.Size(761, 102);
            this.Consola.TabIndex = 0;
            this.Consola.Text = "CONSOLA";
            this.Consola.UseVisualStyleBackColor = true;
            // 
            // Consola1
            // 
            this.Consola1.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Consola1.ForeColor = System.Drawing.SystemColors.Window;
            this.Consola1.Location = new System.Drawing.Point(0, 3);
            this.Consola1.Name = "Consola1";
            this.Consola1.ReadOnly = true;
            this.Consola1.Size = new System.Drawing.Size(915, 96);
            this.Consola1.TabIndex = 0;
            this.Consola1.Text = "";
            // 
            // btn_Abrir
            // 
            this.btn_Abrir.BackColor = System.Drawing.Color.Transparent;
            this.btn_Abrir.BackgroundImage = global::CompiladorCSharp.Properties.Resources.BtnAbrir;
            this.btn_Abrir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_Abrir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Abrir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btn_Abrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Abrir.Location = new System.Drawing.Point(159, 425);
            this.btn_Abrir.Name = "btn_Abrir";
            this.btn_Abrir.Size = new System.Drawing.Size(100, 29);
            this.btn_Abrir.TabIndex = 6;
            this.btn_Abrir.UseVisualStyleBackColor = false;
            this.btn_Abrir.Click += new System.EventHandler(this.btn_Abrir_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Archivos de csharp(*.cs)|*.cs";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Archivos de texto (*.txt)|*.txt|Archivos de csharp(*.cs)|*.cs";
            // 
            // btnArbol
            // 
            this.btnArbol.BackColor = System.Drawing.Color.Transparent;
            this.btnArbol.BackgroundImage = global::CompiladorCSharp.Properties.Resources.BtnArbol;
            this.btnArbol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnArbol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnArbol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnArbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArbol.Location = new System.Drawing.Point(371, 425);
            this.btnArbol.Name = "btnArbol";
            this.btnArbol.Size = new System.Drawing.Size(100, 29);
            this.btnArbol.TabIndex = 7;
            this.btnArbol.UseVisualStyleBackColor = false;
            this.btnArbol.Click += new System.EventHandler(this.btnArbol_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.Image = global::CompiladorCSharp.Properties.Resources.cerrar;
            this.btnCerrar.Location = new System.Drawing.Point(952, 12);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(20, 20);
            this.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCerrar.TabIndex = 8;
            this.btnCerrar.TabStop = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnMaximizar
            // 
            this.btnMaximizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMaximizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximizar.Image = global::CompiladorCSharp.Properties.Resources.maxi;
            this.btnMaximizar.Location = new System.Drawing.Point(926, 12);
            this.btnMaximizar.Name = "btnMaximizar";
            this.btnMaximizar.Size = new System.Drawing.Size(20, 20);
            this.btnMaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMaximizar.TabIndex = 9;
            this.btnMaximizar.TabStop = false;
            this.btnMaximizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.Image = global::CompiladorCSharp.Properties.Resources.minimazar;
            this.btnMinimizar.Location = new System.Drawing.Point(900, 12);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(20, 20);
            this.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimizar.TabIndex = 10;
            this.btnMinimizar.TabStop = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click_1);
            // 
            // btnRestaurar
            // 
            this.btnRestaurar.BackColor = System.Drawing.Color.Transparent;
            this.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestaurar.Image = global::CompiladorCSharp.Properties.Resources.res;
            this.btnRestaurar.Location = new System.Drawing.Point(926, 12);
            this.btnRestaurar.Name = "btnRestaurar";
            this.btnRestaurar.Size = new System.Drawing.Size(20, 20);
            this.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnRestaurar.TabIndex = 11;
            this.btnRestaurar.TabStop = false;
            this.btnRestaurar.Visible = false;
            this.btnRestaurar.Click += new System.EventHandler(this.btnRestaurar_Click);
            // 
            // btnConSonido
            // 
            this.btnConSonido.BackColor = System.Drawing.Color.Transparent;
            this.btnConSonido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConSonido.Image = global::CompiladorCSharp.Properties.Resources.ConSonido2;
            this.btnConSonido.Location = new System.Drawing.Point(952, 38);
            this.btnConSonido.Name = "btnConSonido";
            this.btnConSonido.Size = new System.Drawing.Size(20, 20);
            this.btnConSonido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnConSonido.TabIndex = 12;
            this.btnConSonido.TabStop = false;
            this.btnConSonido.Click += new System.EventHandler(this.btnConSonido_Click);
            // 
            // btnSinSonido
            // 
            this.btnSinSonido.BackColor = System.Drawing.Color.Transparent;
            this.btnSinSonido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinSonido.Image = global::CompiladorCSharp.Properties.Resources.SinSonido2;
            this.btnSinSonido.Location = new System.Drawing.Point(952, 38);
            this.btnSinSonido.Name = "btnSinSonido";
            this.btnSinSonido.Size = new System.Drawing.Size(20, 20);
            this.btnSinSonido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSinSonido.TabIndex = 13;
            this.btnSinSonido.TabStop = false;
            this.btnSinSonido.Click += new System.EventHandler(this.btnSinSonido_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CompiladorCSharp.Properties.Resources.Fondo1_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 603);
            this.Controls.Add(this.btnSinSonido);
            this.Controls.Add(this.btnConSonido);
            this.Controls.Add(this.btnRestaurar);
            this.Controls.Add(this.btnMinimizar);
            this.Controls.Add(this.btnMaximizar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.btnArbol);
            this.Controls.Add(this.btn_Abrir);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Analizar);
            this.Controls.Add(this.TextCode);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Principal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NOT TODAY";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableKT)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TableTok)).EndInit();
            this.tabControl2.ResumeLayout(false);
            this.Consola.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRestaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnConSonido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSinSonido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox TextCode;
        private System.Windows.Forms.Button btn_Analizar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage Consola;
        private System.Windows.Forms.Button btn_Abrir;
        private System.Windows.Forms.RichTextBox Consola1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.RichTextBox descripcion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView TableKT;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView TableTok;
        private System.Windows.Forms.Button btnArbol;
        private System.Windows.Forms.PictureBox btnCerrar;
        private System.Windows.Forms.PictureBox btnMaximizar;
        private System.Windows.Forms.PictureBox btnMinimizar;
        private System.Windows.Forms.PictureBox btnRestaurar;
        private System.Windows.Forms.DataGridViewTextBoxColumn KeyTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescripcionKeyTerm;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.PictureBox btnConSonido;
        private System.Windows.Forms.PictureBox btnSinSonido;
    }
}

