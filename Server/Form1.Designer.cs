namespace Server
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown_puertoEscucha = new System.Windows.Forms.NumericUpDown();
            this.button_StopServer = new System.Windows.Forms.Button();
            this.label_ServerState = new System.Windows.Forms.Label();
            this.label_connectedPlayers = new System.Windows.Forms.Label();
            this.listbox_connectedPlayers = new System.Windows.Forms.ListBox();
            this.buttonStartServer = new System.Windows.Forms.Button();
            this.timer_uptime = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown_maxPlayers = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown_maxRondas = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDown_maxPuntos = new System.Windows.Forms.NumericUpDown();
            this.label_tiempoRonda = new System.Windows.Forms.Label();
            this.numericUpDown_tiempoRonda = new System.Windows.Forms.NumericUpDown();
            this.progressBar_imagenes = new System.Windows.Forms.ProgressBar();
            this.button_kickPlayer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_puertoEscucha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxPlayers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxRondas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxPuntos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tiempoRonda)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(8, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Puerto de escucha";
            // 
            // numericUpDown_puertoEscucha
            // 
            this.numericUpDown_puertoEscucha.Location = new System.Drawing.Point(111, 73);
            this.numericUpDown_puertoEscucha.Maximum = new decimal(new int[] {
            49151,
            0,
            0,
            0});
            this.numericUpDown_puertoEscucha.Minimum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.numericUpDown_puertoEscucha.Name = "numericUpDown_puertoEscucha";
            this.numericUpDown_puertoEscucha.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown_puertoEscucha.TabIndex = 19;
            this.numericUpDown_puertoEscucha.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // button_StopServer
            // 
            this.button_StopServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_StopServer.BackgroundImage")));
            this.button_StopServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_StopServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_StopServer.Enabled = false;
            this.button_StopServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_StopServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.button_StopServer.ForeColor = System.Drawing.SystemColors.Control;
            this.button_StopServer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button_StopServer.Location = new System.Drawing.Point(255, 27);
            this.button_StopServer.Margin = new System.Windows.Forms.Padding(2);
            this.button_StopServer.Name = "button_StopServer";
            this.button_StopServer.Size = new System.Drawing.Size(110, 108);
            this.button_StopServer.TabIndex = 18;
            this.button_StopServer.UseVisualStyleBackColor = true;
            this.button_StopServer.Visible = false;
            this.button_StopServer.Click += new System.EventHandler(this.button_StopServer_Click);
            // 
            // label_ServerState
            // 
            this.label_ServerState.AutoSize = true;
            this.label_ServerState.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_ServerState.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_ServerState.Location = new System.Drawing.Point(8, 39);
            this.label_ServerState.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_ServerState.Name = "label_ServerState";
            this.label_ServerState.Size = new System.Drawing.Size(206, 17);
            this.label_ServerState.TabIndex = 17;
            this.label_ServerState.Text = "Estado del servidor: APAGADO";
            // 
            // label_connectedPlayers
            // 
            this.label_connectedPlayers.AutoSize = true;
            this.label_connectedPlayers.Cursor = System.Windows.Forms.Cursors.Default;
            this.label_connectedPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F);
            this.label_connectedPlayers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_connectedPlayers.Location = new System.Drawing.Point(11, 216);
            this.label_connectedPlayers.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_connectedPlayers.Name = "label_connectedPlayers";
            this.label_connectedPlayers.Size = new System.Drawing.Size(145, 24);
            this.label_connectedPlayers.TabIndex = 16;
            this.label_connectedPlayers.Text = "Inicia el servidor";
            // 
            // listbox_connectedPlayers
            // 
            this.listbox_connectedPlayers.BackColor = System.Drawing.SystemColors.InfoText;
            this.listbox_connectedPlayers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listbox_connectedPlayers.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listbox_connectedPlayers.ForeColor = System.Drawing.Color.Lime;
            this.listbox_connectedPlayers.FormattingEnabled = true;
            this.listbox_connectedPlayers.ItemHeight = 19;
            this.listbox_connectedPlayers.Location = new System.Drawing.Point(11, 249);
            this.listbox_connectedPlayers.Margin = new System.Windows.Forms.Padding(2);
            this.listbox_connectedPlayers.Name = "listbox_connectedPlayers";
            this.listbox_connectedPlayers.Size = new System.Drawing.Size(374, 190);
            this.listbox_connectedPlayers.TabIndex = 15;
            // 
            // buttonStartServer
            // 
            this.buttonStartServer.BackColor = System.Drawing.SystemColors.Control;
            this.buttonStartServer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonStartServer.BackgroundImage")));
            this.buttonStartServer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStartServer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartServer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStartServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F);
            this.buttonStartServer.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonStartServer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonStartServer.Location = new System.Drawing.Point(255, 30);
            this.buttonStartServer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStartServer.Name = "buttonStartServer";
            this.buttonStartServer.Size = new System.Drawing.Size(110, 108);
            this.buttonStartServer.TabIndex = 14;
            this.buttonStartServer.UseVisualStyleBackColor = false;
            this.buttonStartServer.Click += new System.EventHandler(this.buttonStartServer_Click);
            // 
            // timer_uptime
            // 
            this.timer_uptime.Tick += new System.EventHandler(this.timer_uptime_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.notifyIcon1.BalloonTipText = "Servidor Logo Quizz en ejecucion";
            this.notifyIcon1.BalloonTipTitle = "Logo Quiz Server";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Logo Quiz Server";
            this.notifyIcon1.Visible = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(8, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Jugadores Máximos";
            // 
            // numericUpDown_maxPlayers
            // 
            this.numericUpDown_maxPlayers.Location = new System.Drawing.Point(111, 151);
            this.numericUpDown_maxPlayers.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_maxPlayers.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_maxPlayers.Name = "numericUpDown_maxPlayers";
            this.numericUpDown_maxPlayers.ReadOnly = true;
            this.numericUpDown_maxPlayers.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown_maxPlayers.TabIndex = 21;
            this.numericUpDown_maxPlayers.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(7, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Configurar partidas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(8, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Rondas por partida";
            // 
            // numericUpDown_maxRondas
            // 
            this.numericUpDown_maxRondas.Location = new System.Drawing.Point(111, 185);
            this.numericUpDown_maxRondas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_maxRondas.Name = "numericUpDown_maxRondas";
            this.numericUpDown_maxRondas.ReadOnly = true;
            this.numericUpDown_maxRondas.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown_maxRondas.TabIndex = 24;
            this.numericUpDown_maxRondas.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(200, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Max puntuacion";
            // 
            // numericUpDown_maxPuntos
            // 
            this.numericUpDown_maxPuntos.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_maxPuntos.Location = new System.Drawing.Point(289, 151);
            this.numericUpDown_maxPuntos.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_maxPuntos.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_maxPuntos.Name = "numericUpDown_maxPuntos";
            this.numericUpDown_maxPuntos.ReadOnly = true;
            this.numericUpDown_maxPuntos.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown_maxPuntos.TabIndex = 26;
            this.numericUpDown_maxPuntos.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label_tiempoRonda
            // 
            this.label_tiempoRonda.AutoSize = true;
            this.label_tiempoRonda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label_tiempoRonda.Location = new System.Drawing.Point(196, 187);
            this.label_tiempoRonda.Name = "label_tiempoRonda";
            this.label_tiempoRonda.Size = new System.Drawing.Size(87, 13);
            this.label_tiempoRonda.TabIndex = 29;
            this.label_tiempoRonda.Text = "Tiempo de ronda";
            // 
            // numericUpDown_tiempoRonda
            // 
            this.numericUpDown_tiempoRonda.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown_tiempoRonda.Location = new System.Drawing.Point(289, 185);
            this.numericUpDown_tiempoRonda.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown_tiempoRonda.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown_tiempoRonda.Name = "numericUpDown_tiempoRonda";
            this.numericUpDown_tiempoRonda.ReadOnly = true;
            this.numericUpDown_tiempoRonda.Size = new System.Drawing.Size(69, 20);
            this.numericUpDown_tiempoRonda.TabIndex = 28;
            this.numericUpDown_tiempoRonda.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // progressBar_imagenes
            // 
            this.progressBar_imagenes.Location = new System.Drawing.Point(11, 2);
            this.progressBar_imagenes.Margin = new System.Windows.Forms.Padding(2);
            this.progressBar_imagenes.Name = "progressBar_imagenes";
            this.progressBar_imagenes.Size = new System.Drawing.Size(374, 21);
            this.progressBar_imagenes.TabIndex = 30;
            // 
            // button_kickPlayer
            // 
            this.button_kickPlayer.BackColor = System.Drawing.Color.Red;
            this.button_kickPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button_kickPlayer.Enabled = false;
            this.button_kickPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_kickPlayer.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button_kickPlayer.Location = new System.Drawing.Point(235, 217);
            this.button_kickPlayer.Name = "button_kickPlayer";
            this.button_kickPlayer.Size = new System.Drawing.Size(150, 23);
            this.button_kickPlayer.TabIndex = 31;
            this.button_kickPlayer.Text = "Deshacerse de un maleante";
            this.button_kickPlayer.UseVisualStyleBackColor = false;
            this.button_kickPlayer.Click += new System.EventHandler(this.button_kickPlayer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(396, 450);
            this.Controls.Add(this.button_kickPlayer);
            this.Controls.Add(this.progressBar_imagenes);
            this.Controls.Add(this.label_tiempoRonda);
            this.Controls.Add(this.numericUpDown_tiempoRonda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numericUpDown_maxPuntos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numericUpDown_maxRondas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown_maxPlayers);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDown_puertoEscucha);
            this.Controls.Add(this.button_StopServer);
            this.Controls.Add(this.label_ServerState);
            this.Controls.Add(this.label_connectedPlayers);
            this.Controls.Add(this.listbox_connectedPlayers);
            this.Controls.Add(this.buttonStartServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Logo Quiz Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_puertoEscucha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxPlayers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxRondas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_maxPuntos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_tiempoRonda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown_puertoEscucha;
        private System.Windows.Forms.Button button_StopServer;
        private System.Windows.Forms.Label label_ServerState;
        private System.Windows.Forms.Label label_connectedPlayers;
        private System.Windows.Forms.ListBox listbox_connectedPlayers;
        private System.Windows.Forms.Button buttonStartServer;
        private System.Windows.Forms.Timer timer_uptime;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown_maxPlayers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown_maxRondas;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDown_maxPuntos;
        private System.Windows.Forms.Label label_tiempoRonda;
        private System.Windows.Forms.NumericUpDown numericUpDown_tiempoRonda;
        private System.Windows.Forms.ProgressBar progressBar_imagenes;
        private System.Windows.Forms.Button button_kickPlayer;
    }
}

