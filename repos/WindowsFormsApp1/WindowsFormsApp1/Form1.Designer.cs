namespace WindowsFormsApp1
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
            this.btnexecutar = new System.Windows.Forms.Button();
            this.lstviewdados = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.txtDevice = new System.Windows.Forms.TextBox();
            this.txtdescricao = new System.Windows.Forms.TextBox();
            this.txtip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnParar = new System.Windows.Forms.Button();
            this.btnRemoveLinha = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnexecutar
            // 
            this.btnexecutar.Location = new System.Drawing.Point(398, 23);
            this.btnexecutar.Margin = new System.Windows.Forms.Padding(2);
            this.btnexecutar.Name = "btnexecutar";
            this.btnexecutar.Size = new System.Drawing.Size(116, 33);
            this.btnexecutar.TabIndex = 0;
            this.btnexecutar.Text = "Start";
            this.btnexecutar.UseVisualStyleBackColor = true;
            this.btnexecutar.Click += new System.EventHandler(this.Executar_Click);
            // 
            // lstviewdados
            // 
            this.lstviewdados.FullRowSelect = true;
            this.lstviewdados.GridLines = true;
            this.lstviewdados.HideSelection = false;
            this.lstviewdados.Location = new System.Drawing.Point(10, 11);
            this.lstviewdados.Margin = new System.Windows.Forms.Padding(2);
            this.lstviewdados.Name = "lstviewdados";
            this.lstviewdados.Size = new System.Drawing.Size(384, 320);
            this.lstviewdados.TabIndex = 1;
            this.lstviewdados.UseCompatibleStateImageBehavior = false;
            this.lstviewdados.View = System.Windows.Forms.View.Details;
            this.lstviewdados.SelectedIndexChanged += new System.EventHandler(this.Lstviewdados_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 337);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 24);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Field";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // txtDevice
            // 
            this.txtDevice.Location = new System.Drawing.Point(71, 368);
            this.txtDevice.Margin = new System.Windows.Forms.Padding(2);
            this.txtDevice.Name = "txtDevice";
            this.txtDevice.Size = new System.Drawing.Size(76, 20);
            this.txtDevice.TabIndex = 3;
            // 
            // txtdescricao
            // 
            this.txtdescricao.Location = new System.Drawing.Point(71, 390);
            this.txtdescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtdescricao.Name = "txtdescricao";
            this.txtdescricao.Size = new System.Drawing.Size(76, 20);
            this.txtdescricao.TabIndex = 4;
            // 
            // txtip
            // 
            this.txtip.Location = new System.Drawing.Point(71, 414);
            this.txtip.Margin = new System.Windows.Forms.Padding(2);
            this.txtip.Name = "txtip";
            this.txtip.Size = new System.Drawing.Size(76, 20);
            this.txtip.TabIndex = 5;
            this.txtip.TextChanged += new System.EventHandler(this.txtip_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 371);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Device";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 393);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1, 414);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "IP";
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(398, 73);
            this.btnParar.Margin = new System.Windows.Forms.Padding(2);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(116, 33);
            this.btnParar.TabIndex = 9;
            this.btnParar.Text = "Stop";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.BtnParar_Click);
            // 
            // btnRemoveLinha
            // 
            this.btnRemoveLinha.Location = new System.Drawing.Point(103, 337);
            this.btnRemoveLinha.Margin = new System.Windows.Forms.Padding(2);
            this.btnRemoveLinha.Name = "btnRemoveLinha";
            this.btnRemoveLinha.Size = new System.Drawing.Size(99, 24);
            this.btnRemoveLinha.TabIndex = 10;
            this.btnRemoveLinha.Text = "Remove Field";
            this.btnRemoveLinha.UseVisualStyleBackColor = true;
            this.btnRemoveLinha.Click += new System.EventHandler(this.BtnRemoveLinha_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(542, 20);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(74, 36);
            this.btnsave.TabIndex = 11;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.Btnsave_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // PBar1
            // 
            this.PBar1.Location = new System.Drawing.Point(415, 414);
            this.PBar1.Name = "PBar1";
            this.PBar1.Size = new System.Drawing.Size(201, 23);
            this.PBar1.TabIndex = 12;
            this.PBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 445);
            this.Controls.Add(this.PBar1);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnRemoveLinha);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtip);
            this.Controls.Add(this.txtdescricao);
            this.Controls.Add(this.txtDevice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstviewdados);
            this.Controls.Add(this.btnexecutar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexecutar;
        private System.Windows.Forms.ListView lstviewdados;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDevice;
        private System.Windows.Forms.TextBox txtdescricao;
        private System.Windows.Forms.TextBox txtip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnParar;
        private System.Windows.Forms.Button btnRemoveLinha;
        private System.Windows.Forms.Button btnsave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar PBar1;
    }
}

