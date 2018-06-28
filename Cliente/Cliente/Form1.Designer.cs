namespace Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerImagen = new System.Windows.Forms.Timer(this.components);
            this.textbox_respuesta = new System.Windows.Forms.TextBox();
            this.button_enviarRespuesta = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox_ip = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox_puerto = new System.Windows.Forms.ToolStripTextBox();
            this.conectarseAlServidorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desconectarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verLasNormasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer_cuentaAtras = new System.Windows.Forms.Timer(this.components);
            this.labelPista = new System.Windows.Forms.Label();
            this.label_estado = new System.Windows.Forms.Label();
            this.radioButton_respuesta = new System.Windows.Forms.RadioButton();
            this.radioButton_chat = new System.Windows.Forms.RadioButton();
            this.label_CuentaAtrasInicio = new System.Windows.Forms.Label();
            this.timer_cuentaInicio = new System.Windows.Forms.Timer(this.components);
            this.groupBox_nick = new System.Windows.Forms.GroupBox();
            this.button_nick = new System.Windows.Forms.Button();
            this.textBox_nick = new System.Windows.Forms.TextBox();
            this.button_listo = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label_time = new System.Windows.Forms.Label();
            this.listBox_resultado = new System.Windows.Forms.ListBox();
            this.listBox_chat = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox_nick.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timerImagen
            // 
            this.timerImagen.Interval = 500;
            this.timerImagen.Tick += new System.EventHandler(this.timerImagen_Tick);
            // 
            // textbox_respuesta
            // 
            this.textbox_respuesta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textbox_respuesta.Location = new System.Drawing.Point(84, 13);
            this.textbox_respuesta.Name = "textbox_respuesta";
            this.textbox_respuesta.Size = new System.Drawing.Size(493, 20);
            this.textbox_respuesta.TabIndex = 1;
            this.textbox_respuesta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textbox_respuesta_KeyDown);
            // 
            // button_enviarRespuesta
            // 
            this.button_enviarRespuesta.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_enviarRespuesta.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_enviarRespuesta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_enviarRespuesta.Location = new System.Drawing.Point(580, 11);
            this.button_enviarRespuesta.Name = "button_enviarRespuesta";
            this.button_enviarRespuesta.Size = new System.Drawing.Size(66, 23);
            this.button_enviarRespuesta.TabIndex = 3;
            this.button_enviarRespuesta.Text = "Enviar";
            this.button_enviarRespuesta.UseVisualStyleBackColor = false;
            this.button_enviarRespuesta.Click += new System.EventHandler(this.button_JUGADA_CHAT);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conectarToolStripMenuItem,
            this.desconectarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // conectarToolStripMenuItem
            // 
            this.conectarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox_ip,
            this.toolStripTextBox_puerto,
            this.conectarseAlServidorToolStripMenuItem});
            this.conectarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("conectarToolStripMenuItem.Image")));
            this.conectarToolStripMenuItem.Name = "conectarToolStripMenuItem";
            this.conectarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.conectarToolStripMenuItem.Text = "Conectar";
            // 
            // toolStripTextBox_ip
            // 
            this.toolStripTextBox_ip.AutoToolTip = true;
            this.toolStripTextBox_ip.BackColor = System.Drawing.SystemColors.Window;
            this.toolStripTextBox_ip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox_ip.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox_ip.MaxLength = 15;
            this.toolStripTextBox_ip.Name = "toolStripTextBox_ip";
            this.toolStripTextBox_ip.Size = new System.Drawing.Size(150, 30);
            this.toolStripTextBox_ip.Text = "127.0.0.1";
            this.toolStripTextBox_ip.ToolTipText = "Introduce la ip del servidor";
            this.toolStripTextBox_ip.Click += new System.EventHandler(this.toolStripTextBox_ip_Click);
            // 
            // toolStripTextBox_puerto
            // 
            this.toolStripTextBox_puerto.AutoToolTip = true;
            this.toolStripTextBox_puerto.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTextBox_puerto.Name = "toolStripTextBox_puerto";
            this.toolStripTextBox_puerto.Size = new System.Drawing.Size(150, 30);
            this.toolStripTextBox_puerto.Text = "2000";
            this.toolStripTextBox_puerto.ToolTipText = "Introduce le puerto del servidor";
            this.toolStripTextBox_puerto.Click += new System.EventHandler(this.toolStripTextBox_puerto_Click);
            // 
            // conectarseAlServidorToolStripMenuItem
            // 
            this.conectarseAlServidorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("conectarseAlServidorToolStripMenuItem.Image")));
            this.conectarseAlServidorToolStripMenuItem.Name = "conectarseAlServidorToolStripMenuItem";
            this.conectarseAlServidorToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+N";
            this.conectarseAlServidorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.conectarseAlServidorToolStripMenuItem.Size = new System.Drawing.Size(237, 26);
            this.conectarseAlServidorToolStripMenuItem.Text = "Conectarse al servidor";
            this.conectarseAlServidorToolStripMenuItem.Click += new System.EventHandler(this.conectarseAlServidorToolStripMenuItem_Click);
            // 
            // desconectarToolStripMenuItem
            // 
            this.desconectarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("desconectarToolStripMenuItem.Image")));
            this.desconectarToolStripMenuItem.Name = "desconectarToolStripMenuItem";
            this.desconectarToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.desconectarToolStripMenuItem.Text = "Desconectar";
            this.desconectarToolStripMenuItem.Click += new System.EventHandler(this.desconectarToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verLasNormasToolStripMenuItem,
            this.acercaDeToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "ver";
            // 
            // verLasNormasToolStripMenuItem
            // 
            this.verLasNormasToolStripMenuItem.Name = "verLasNormasToolStripMenuItem";
            this.verLasNormasToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.verLasNormasToolStripMenuItem.Text = "Ver manual de usuario";
            this.verLasNormasToolStripMenuItem.Click += new System.EventHandler(this.verLasNormasToolStripMenuItem_Click);
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // timer_cuentaAtras
            // 
            this.timer_cuentaAtras.Interval = 1000;
            this.timer_cuentaAtras.Tick += new System.EventHandler(this.timer_cuentaAtras_Tick);
            // 
            // labelPista
            // 
            this.labelPista.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelPista.AutoSize = true;
            this.labelPista.BackColor = System.Drawing.Color.Transparent;
            this.labelPista.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelPista.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelPista.Location = new System.Drawing.Point(3, 0);
            this.labelPista.Name = "labelPista";
            this.labelPista.Size = new System.Drawing.Size(112, 67);
            this.labelPista.TabIndex = 8;
            this.labelPista.Text = "Pista en";
            this.labelPista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_estado
            // 
            this.label_estado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_estado.AutoSize = true;
            this.label_estado.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label_estado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_estado.Location = new System.Drawing.Point(1143, 6);
            this.label_estado.Name = "label_estado";
            this.label_estado.Size = new System.Drawing.Size(116, 13);
            this.label_estado.TabIndex = 9;
            this.label_estado.Text = "Estado: Desconectado";
            // 
            // radioButton_respuesta
            // 
            this.radioButton_respuesta.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButton_respuesta.AutoSize = true;
            this.radioButton_respuesta.Location = new System.Drawing.Point(3, 4);
            this.radioButton_respuesta.Name = "radioButton_respuesta";
            this.radioButton_respuesta.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton_respuesta.Size = new System.Drawing.Size(76, 17);
            this.radioButton_respuesta.TabIndex = 13;
            this.radioButton_respuesta.TabStop = true;
            this.radioButton_respuesta.Text = "Respuesta";
            this.radioButton_respuesta.UseVisualStyleBackColor = true;
            // 
            // radioButton_chat
            // 
            this.radioButton_chat.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.radioButton_chat.AutoSize = true;
            this.radioButton_chat.Location = new System.Drawing.Point(32, 27);
            this.radioButton_chat.Name = "radioButton_chat";
            this.radioButton_chat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton_chat.Size = new System.Drawing.Size(47, 17);
            this.radioButton_chat.TabIndex = 14;
            this.radioButton_chat.TabStop = true;
            this.radioButton_chat.Text = "Chat";
            this.radioButton_chat.UseVisualStyleBackColor = true;
            // 
            // label_CuentaAtrasInicio
            // 
            this.label_CuentaAtrasInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_CuentaAtrasInicio.AutoSize = true;
            this.label_CuentaAtrasInicio.BackColor = System.Drawing.Color.Transparent;
            this.label_CuentaAtrasInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label_CuentaAtrasInicio.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label_CuentaAtrasInicio.Location = new System.Drawing.Point(1123, 0);
            this.label_CuentaAtrasInicio.Name = "label_CuentaAtrasInicio";
            this.label_CuentaAtrasInicio.Size = new System.Drawing.Size(130, 67);
            this.label_CuentaAtrasInicio.TabIndex = 15;
            this.label_CuentaAtrasInicio.Text = "3";
            this.label_CuentaAtrasInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer_cuentaInicio
            // 
            this.timer_cuentaInicio.Interval = 1000;
            this.timer_cuentaInicio.Tick += new System.EventHandler(this.timer_cuentaInicio_Tick);
            // 
            // groupBox_nick
            // 
            this.groupBox_nick.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox_nick.BackColor = System.Drawing.SystemColors.ControlDark;
            this.groupBox_nick.Controls.Add(this.button_nick);
            this.groupBox_nick.Controls.Add(this.textBox_nick);
            this.groupBox_nick.Enabled = false;
            this.groupBox_nick.Location = new System.Drawing.Point(3, 3);
            this.groupBox_nick.Name = "groupBox_nick";
            this.groupBox_nick.Size = new System.Drawing.Size(428, 46);
            this.groupBox_nick.TabIndex = 11;
            this.groupBox_nick.TabStop = false;
            this.groupBox_nick.Text = "Elige un nick y entra en la partida";
            // 
            // button_nick
            // 
            this.button_nick.AccessibleName = "";
            this.button_nick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_nick.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button_nick.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_nick.Location = new System.Drawing.Point(266, 18);
            this.button_nick.Name = "button_nick";
            this.button_nick.Size = new System.Drawing.Size(156, 23);
            this.button_nick.TabIndex = 11;
            this.button_nick.Text = "Entrar";
            this.button_nick.UseVisualStyleBackColor = false;
            this.button_nick.Click += new System.EventHandler(this.button_INSCRIBIR_click);
            // 
            // textBox_nick
            // 
            this.textBox_nick.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_nick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_nick.Location = new System.Drawing.Point(6, 19);
            this.textBox_nick.MaxLength = 15;
            this.textBox_nick.Name = "textBox_nick";
            this.textBox_nick.Size = new System.Drawing.Size(262, 20);
            this.textBox_nick.TabIndex = 10;
            // 
            // button_listo
            // 
            this.button_listo.AutoSize = true;
            this.button_listo.BackColor = System.Drawing.Color.ForestGreen;
            this.button_listo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_listo.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_listo.Enabled = false;
            this.button_listo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_listo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_listo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_listo.Location = new System.Drawing.Point(662, 481);
            this.button_listo.Margin = new System.Windows.Forms.Padding(5);
            this.button_listo.Name = "button_listo";
            this.button_listo.Size = new System.Drawing.Size(154, 47);
            this.button_listo.TabIndex = 12;
            this.button_listo.Text = "Estoy listo!";
            this.button_listo.UseVisualStyleBackColor = false;
            this.button_listo.Click += new System.EventHandler(this.button_LISTOPARAJUGAR_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.progressBar1.Location = new System.Drawing.Point(5, 5);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(647, 18);
            this.progressBar1.TabIndex = 16;
            // 
            // label_time
            // 
            this.label_time.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_time.AutoSize = true;
            this.label_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_time.Location = new System.Drawing.Point(660, 4);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(80, 24);
            this.label_time.TabIndex = 7;
            this.label_time.Text = "Tiempo:";
            // 
            // listBox_resultado
            // 
            this.listBox_resultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_resultado.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listBox_resultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_resultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_resultado.ForeColor = System.Drawing.SystemColors.Control;
            this.listBox_resultado.FormattingEnabled = true;
            this.listBox_resultado.ItemHeight = 16;
            this.listBox_resultado.Location = new System.Drawing.Point(662, 33);
            this.listBox_resultado.Margin = new System.Windows.Forms.Padding(5);
            this.listBox_resultado.Name = "listBox_resultado";
            this.listBox_resultado.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_resultado.Size = new System.Drawing.Size(155, 434);
            this.listBox_resultado.TabIndex = 4;
            // 
            // listBox_chat
            // 
            this.listBox_chat.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBox_chat.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.listBox_chat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBox_chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_chat.ForeColor = System.Drawing.SystemColors.Control;
            this.listBox_chat.FormattingEnabled = true;
            this.listBox_chat.HorizontalScrollbar = true;
            this.listBox_chat.ItemHeight = 16;
            this.listBox_chat.Location = new System.Drawing.Point(5, 63);
            this.listBox_chat.Margin = new System.Windows.Forms.Padding(5);
            this.listBox_chat.Name = "listBox_chat";
            this.listBox_chat.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox_chat.Size = new System.Drawing.Size(430, 450);
            this.listBox_chat.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.textbox_respuesta);
            this.panel1.Controls.Add(this.button_enviarRespuesta);
            this.panel1.Controls.Add(this.radioButton_respuesta);
            this.panel1.Controls.Add(this.radioButton_chat);
            this.panel1.Location = new System.Drawing.Point(3, 479);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 51);
            this.panel1.TabIndex = 17;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 27);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1263, 653);
            this.splitContainer1.SplitterDistance = 92;
            this.splitContainer1.TabIndex = 18;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.35294F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.86274F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.78431F));
            this.tableLayoutPanel4.Controls.Add(this.labelPista, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.pictureBox2, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.label_CuentaAtrasInicio, 2, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 14);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1256, 67);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(409, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(708, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.splitContainer2.Panel1.Controls.Add(this.tableLayoutPanel2);
            this.splitContainer2.Panel1MinSize = 440;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer2.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer2.Panel2MinSize = 500;
            this.splitContainer2.Size = new System.Drawing.Size(1263, 533);
            this.splitContainer2.SplitterDistance = 440;
            this.splitContainer2.SplitterWidth = 1;
            this.splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.listBox_chat, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.14865F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.85135F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(440, 521);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.groupBox_nick, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(434, 52);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_time, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listBox_resultado, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.button_listo, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.405406F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.95271F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.51546F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(822, 533);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Cliente.Properties.Resources.brands;
            this.pictureBox1.Location = new System.Drawing.Point(5, 33);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(647, 438);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.label_estado);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "Form1";
            this.Text = "LOGO QUIZ - CLIENTE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox_nick.ResumeLayout(false);
            this.groupBox_nick.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerImagen;
        private System.Windows.Forms.TextBox textbox_respuesta;
        private System.Windows.Forms.Button button_enviarRespuesta;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.Timer timer_cuentaAtras;
        private System.Windows.Forms.Label labelPista;
        private System.Windows.Forms.ToolStripMenuItem conectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desconectarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verLasNormasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_ip;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox_puerto;
        private System.Windows.Forms.ToolStripMenuItem conectarseAlServidorToolStripMenuItem;
        private System.Windows.Forms.Label label_estado;
        private System.Windows.Forms.RadioButton radioButton_respuesta;
        private System.Windows.Forms.RadioButton radioButton_chat;
        private System.Windows.Forms.Label label_CuentaAtrasInicio;
        private System.Windows.Forms.Timer timer_cuentaInicio;
        private System.Windows.Forms.GroupBox groupBox_nick;
        private System.Windows.Forms.Button button_nick;
        private System.Windows.Forms.TextBox textBox_nick;
        private System.Windows.Forms.Button button_listo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.ListBox listBox_resultado;
        private System.Windows.Forms.ListBox listBox_chat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

