namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonNotification = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageNotification = new System.Windows.Forms.TabPage();
            this.listBoxGroups = new System.Windows.Forms.ListBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelDisplayName = new System.Windows.Forms.Label();
            this.labelMachine = new System.Windows.Forms.Label();
            this.labelDomain = new System.Windows.Forms.Label();
            this.labelUserName = new System.Windows.Forms.Label();
            this.tabPageListe = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tabPageNotification.SuspendLayout();
            this.tabPageListe.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNotification
            // 
            this.buttonNotification.Location = new System.Drawing.Point(280, 350);
            this.buttonNotification.Name = "buttonNotification";
            this.buttonNotification.Size = new System.Drawing.Size(200, 50);
            this.buttonNotification.TabIndex = 0;
            this.buttonNotification.Text = "Afficher une notification";
            this.buttonNotification.UseVisualStyleBackColor = true;
            this.buttonNotification.Click += new System.EventHandler(this.buttonNotification_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "Mon Application";
            this.notifyIcon1.Visible = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageNotification);
            this.tabControl1.Controls.Add(this.tabPageListe);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPageNotification
            // 
            this.tabPageNotification.Controls.Add(this.listBoxGroups);
            this.tabPageNotification.Controls.Add(this.labelEmail);
            this.tabPageNotification.Controls.Add(this.labelDisplayName);
            this.tabPageNotification.Controls.Add(this.labelMachine);
            this.tabPageNotification.Controls.Add(this.labelDomain);
            this.tabPageNotification.Controls.Add(this.labelUserName);
            this.tabPageNotification.Controls.Add(this.buttonNotification);
            this.tabPageNotification.Location = new System.Drawing.Point(4, 22);
            this.tabPageNotification.Name = "tabPageNotification";
            this.tabPageNotification.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNotification.Size = new System.Drawing.Size(792, 424);
            this.tabPageNotification.TabIndex = 0;
            this.tabPageNotification.Text = "Informations Utilisateur";
            this.tabPageNotification.UseVisualStyleBackColor = true;
            // 
            // listBoxGroups
            // 
            this.listBoxGroups.FormattingEnabled = true;
            this.listBoxGroups.Location = new System.Drawing.Point(20, 140);
            this.listBoxGroups.Name = "listBoxGroups";
            this.listBoxGroups.Size = new System.Drawing.Size(750, 186);
            this.listBoxGroups.TabIndex = 6;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(20, 110);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(38, 13);
            this.labelEmail.TabIndex = 5;
            this.labelEmail.Text = "Email :";
            // 
            // labelDisplayName
            // 
            this.labelDisplayName.AutoSize = true;
            this.labelDisplayName.Location = new System.Drawing.Point(20, 85);
            this.labelDisplayName.Name = "labelDisplayName";
            this.labelDisplayName.Size = new System.Drawing.Size(77, 13);
            this.labelDisplayName.TabIndex = 4;
            this.labelDisplayName.Text = "Nom complet :";
            // 
            // labelMachine
            // 
            this.labelMachine.AutoSize = true;
            this.labelMachine.Location = new System.Drawing.Point(20, 60);
            this.labelMachine.Name = "labelMachine";
            this.labelMachine.Size = new System.Drawing.Size(54, 13);
            this.labelMachine.TabIndex = 3;
            this.labelMachine.Text = "Machine :";
            // 
            // labelDomain
            // 
            this.labelDomain.AutoSize = true;
            this.labelDomain.Location = new System.Drawing.Point(20, 35);
            this.labelDomain.Name = "labelDomain";
            this.labelDomain.Size = new System.Drawing.Size(55, 13);
            this.labelDomain.TabIndex = 2;
            this.labelDomain.Text = "Domaine :";
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(20, 10);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(59, 13);
            this.labelUserName.TabIndex = 1;
            this.labelUserName.Text = "Utilisateur :";
            // 
            // tabPageListe
            // 
            this.tabPageListe.Controls.Add(this.listBox1);
            this.tabPageListe.Location = new System.Drawing.Point(4, 22);
            this.tabPageListe.Name = "tabPageListe";
            this.tabPageListe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListe.Size = new System.Drawing.Size(792, 424);
            this.tabPageListe.TabIndex = 1;
            this.tabPageListe.Text = "Liste";
            this.tabPageListe.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(786, 418);
            this.listBox1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Application de Notification";
            this.tabControl1.ResumeLayout(false);
            this.tabPageNotification.ResumeLayout(false);
            this.tabPageNotification.PerformLayout();
            this.tabPageListe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonNotification;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageNotification;
        private System.Windows.Forms.TabPage tabPageListe;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelDomain;
        private System.Windows.Forms.Label labelMachine;
        private System.Windows.Forms.Label labelDisplayName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.ListBox listBoxGroups;
    }
}

