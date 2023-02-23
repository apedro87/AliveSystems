using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using AliveSystems.Properties;
using System.IO;
using System.Net.Mail;
using System.Threading;
using System.Collections;
using System.Collections.Specialized;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        DateTime now = DateTime.Now;
        StringCollection myCol = new StringCollection();
        ListViewItem item = new ListViewItem();
        bool pingable = false;
        Ping pinger = null;
        public Form1()
        {
            InitializeComponent();
        }
        
        public StringCollection GetSettings()
        {
            
            myCol = Settings.Default.ListaIps;
            return myCol;
            
        }

        public void SaveSettings()
        {

            myCol = Settings.Default.ListaIps;
            Settings.Default.Save();

        }
        
        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtip.Text != "")
            {
                
                ListViewItem item = new ListViewItem(txtHotel.Text);
                item.SubItems.Add(txtdescricao.Text);
                item.SubItems.Add(txtip.Text);
                lstviewdados.Items.Add(item);
                txtHotel.Clear();
                txtdescricao.Clear();
                txtip.Clear();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetSettings();

            lstviewdados.View = View.Details;
            lstviewdados.Columns.Add("Hotel");
            lstviewdados.Columns.Add("Descrição");
            lstviewdados.Columns.Add("IP");
            

            for (int i = 0; i < myCol.Count; i=i+3)
            {
                
                lstviewdados.Items.Add(
                new ListViewItem(new[]
                {

                myCol[i],
                myCol[i + 1],
                myCol[i + 2],
                }));
            }



            for (int i = 0; i < lstviewdados.Columns.Count; i++)
               {
                  lstviewdados.Columns[i].Width = -2;
               }
            

        }

        public void Lstviewdados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Processamento()
        {

            
        }
        private void Executar_Click(object sender, EventArgs e)
        {
            int contaLista = 0;
            //ListViewItem item = new ListViewItem();
            int[] array1;
            contaLista = lstviewdados.Items.Count;
            array1 = new int[contaLista];
            if (lstviewdados.Items.Count != 0)
            {

                pinger = new Ping();
                for (int x = 0; x <= contaLista - 1; x++)
                {
                    try
                    {
                        //MessageBox.Show(lstviewdados.Items[x].SubItems[2].Text);
                        PingReply reply = pinger.Send(lstviewdados.Items[x].SubItems[2].Text);
                        if (reply.Status == IPStatus.Success)
                        {
                            pingable = true;
                            //MessageBox.Show(lstviewdados.Items[x].SubItems[2].Text + " está a pingar");
                            lstviewdados.Items[x].UseItemStyleForSubItems = false;
                            lstviewdados.Items[x].SubItems[2].ForeColor = Color.Green;
                        }
                        //pingable = reply.Status == IPStatus.Success;

                    }
                    catch (PingException)
                    {
                        //MessageBox.Show(lstviewdados.Items[x].SubItems[2].Text + " não está a pingar");
                        lstviewdados.Items[x].UseItemStyleForSubItems = false;
                        lstviewdados.Items[x].SubItems[2].ForeColor = Color.Red;
                        pingable = false;
                        /* MailMessage mail = new MailMessage();
                         SmtpClient SmtpServer = new SmtpClient("smtp.office365.com");

                         mail.From = new MailAddress("");
                         mail.To.Add("");
                         mail.Subject = lstviewdados.Items[x].SubItems[1].Text + " " + lstviewdados.Items[x].SubItems[0].Text + " - Inactivo";
                         mail.Body = now.ToString("F") + "\n\n Estado: Sem Resposta";

                         SmtpServer.Port = 587;
                         SmtpServer.Credentials = new System.Net.NetworkCredential("", "");
                         SmtpServer.EnableSsl = true;

                         SmtpServer.Send(mail); */
                    }
                }
            }
            if (!backgroundWorker1.IsBusy)
            {
                backgroundWorker1.RunWorkerAsync();
            }
         

        }

        private void BtnParar_Click(object sender, EventArgs e)
        {

        }

        private void BtnRemoveLinha_Click(object sender, EventArgs e)
        {
            for (int i = lstviewdados.Items.Count - 1; i >= 0; i--)
            {
                if (lstviewdados.Items[i].Selected)
                {
                    lstviewdados.Items[i].Remove();
                }
            }
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            int contaLista = 0;
            myCol.Clear();
             contaLista = lstviewdados.Items.Count;
            for (int x = 0; x <= contaLista - 1; x++)
                for (int y = 0; y <= 2; y++)
                {
                  myCol.Add(lstviewdados.Items[x].SubItems[y].ToString().Substring(18).Replace("}", ""));
                }

            SaveSettings();

            //int contaLista = 0;

            //FileStream file = new FileStream(@"C:\Users\adriano.pedro\source\repos\WindowsFormsApp1\WindowsFormsApp1\teste.txt", FileMode.Create, FileAccess.Write);
            //StreamWriter sw = new StreamWriter(file);
            //contaLista = lstviewdados.Items.Count;
            //for (int x = 0; x <= contaLista - 1; x++)
            //    for (int y = 0; y <= 2; y++)
            //    {
            //        sw.WriteLine(lstviewdados.Items[x].SubItems[y].ToString().Substring(18).Replace("}",""));
            //    }

            //sw.Close();
            //file.Close();

        }
        
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            
        }

        private void txtip_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
