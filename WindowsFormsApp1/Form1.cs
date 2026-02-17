using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Principal;
using System.DirectoryServices.AccountManagement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            notifyIcon1.Icon = SystemIcons.Information;
            LoadUserInformation();
        }

        private void LoadUserInformation()
        {
            try
            {
                WindowsIdentity identity = WindowsIdentity.GetCurrent();
                string userName = identity.Name;

                labelUserName.Text = "Utilisateur : " + userName;
                labelDomain.Text = "Domaine : " + Environment.UserDomainName;
                labelMachine.Text = "Machine : " + Environment.MachineName;

                try
                {
                    using (PrincipalContext context = new PrincipalContext(ContextType.Domain))
                    {
                        UserPrincipal user = UserPrincipal.FindByIdentity(context, identity.Name);

                        if (user != null)
                        {
                            labelDisplayName.Text = "Nom complet : " + (user.DisplayName ?? "Non disponible");
                            labelEmail.Text = "Email : " + (user.EmailAddress ?? "Non disponible");

                            var groups = user.GetAuthorizationGroups();
                            listBoxGroups.Items.Clear();
                            listBoxGroups.Items.Add("Groupes AD :");

                            foreach (Principal group in groups)
                            {
                                try
                                {
                                    listBoxGroups.Items.Add("  - " + group.Name);
                                }
                                catch { }
                            }
                        }
                        else
                        {
                            labelDisplayName.Text = "Nom complet : Non disponible (pas de domaine AD)";
                            labelEmail.Text = "Email : Non disponible";
                            listBoxGroups.Items.Add("Groupes AD : Non disponible (pas de domaine AD)");
                        }
                    }
                }
                catch (Exception ex)
                {
                    labelDisplayName.Text = "Nom complet : Non disponible (pas de domaine AD)";
                    labelEmail.Text = "Email : Non disponible";
                    listBoxGroups.Items.Add("Groupes AD : " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des informations : " + ex.Message);
            }
        }

        private void buttonNotification_Click(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "Notification";
            notifyIcon1.BalloonTipText = "Vous avez cliqué sur le bouton !";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(3000);
        }
    }
}
