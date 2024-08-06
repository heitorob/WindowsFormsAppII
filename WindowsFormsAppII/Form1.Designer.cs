namespace WindowsFormsAppII
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtOUTROS = new System.Windows.Forms.TextBox();
            this.txtELETRICA = new System.Windows.Forms.TextBox();
            this.txtALIMENTO = new System.Windows.Forms.TextBox();
            this.txtTV = new System.Windows.Forms.TextBox();
            this.txtAGUA = new System.Windows.Forms.TextBox();
            this.btnCALCULAR = new System.Windows.Forms.Button();
            this.btnNOVO = new System.Windows.Forms.Button();
            this.btnFECHAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblGASTOS = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblSALDO = new System.Windows.Forms.Label();
            this.txtRENDA = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtOUTROS);
            this.groupBox1.Controls.Add(this.txtELETRICA);
            this.groupBox1.Controls.Add(this.txtALIMENTO);
            this.groupBox1.Controls.Add(this.txtTV);
            this.groupBox1.Controls.Add(this.txtAGUA);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(39, 130);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(479, 358);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gastos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 26);
            this.label6.TabIndex = 11;
            this.label6.Text = "Outros Gastos:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 26);
            this.label5.TabIndex = 10;
            this.label5.Text = "Alimentação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "TV / Celular / Internet:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 26);
            this.label3.TabIndex = 8;
            this.label3.Text = "Água:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "Energia Elétrica:";
            // 
            // txtOUTROS
            // 
            this.txtOUTROS.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOUTROS.Location = new System.Drawing.Point(314, 252);
            this.txtOUTROS.Name = "txtOUTROS";
            this.txtOUTROS.Size = new System.Drawing.Size(100, 24);
            this.txtOUTROS.TabIndex = 6;
            // 
            // txtELETRICA
            // 
            this.txtELETRICA.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtELETRICA.Location = new System.Drawing.Point(314, 68);
            this.txtELETRICA.Name = "txtELETRICA";
            this.txtELETRICA.Size = new System.Drawing.Size(100, 24);
            this.txtELETRICA.TabIndex = 2;
            // 
            // txtALIMENTO
            // 
            this.txtALIMENTO.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtALIMENTO.Location = new System.Drawing.Point(314, 206);
            this.txtALIMENTO.Name = "txtALIMENTO";
            this.txtALIMENTO.Size = new System.Drawing.Size(100, 24);
            this.txtALIMENTO.TabIndex = 5;
            // 
            // txtTV
            // 
            this.txtTV.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTV.Location = new System.Drawing.Point(314, 160);
            this.txtTV.Name = "txtTV";
            this.txtTV.Size = new System.Drawing.Size(100, 24);
            this.txtTV.TabIndex = 4;
            // 
            // txtAGUA
            // 
            this.txtAGUA.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAGUA.Location = new System.Drawing.Point(314, 114);
            this.txtAGUA.Name = "txtAGUA";
            this.txtAGUA.Size = new System.Drawing.Size(100, 24);
            this.txtAGUA.TabIndex = 3;
            // 
            // btnCALCULAR
            // 
            this.btnCALCULAR.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnCALCULAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCALCULAR.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCALCULAR.Location = new System.Drawing.Point(38, 494);
            this.btnCALCULAR.Name = "btnCALCULAR";
            this.btnCALCULAR.Size = new System.Drawing.Size(135, 61);
            this.btnCALCULAR.TabIndex = 7;
            this.btnCALCULAR.Text = "Calcular";
            this.btnCALCULAR.UseVisualStyleBackColor = false;
            this.btnCALCULAR.Click += new System.EventHandler(this.btnCALCULAR_Click);
            // 
            // btnNOVO
            // 
            this.btnNOVO.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNOVO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNOVO.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNOVO.Location = new System.Drawing.Point(211, 494);
            this.btnNOVO.Name = "btnNOVO";
            this.btnNOVO.Size = new System.Drawing.Size(135, 61);
            this.btnNOVO.TabIndex = 8;
            this.btnNOVO.Text = "Limpar";
            this.btnNOVO.UseVisualStyleBackColor = false;
            this.btnNOVO.Click += new System.EventHandler(this.btnNOVO_Click);
            // 
            // btnFECHAR
            // 
            this.btnFECHAR.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnFECHAR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFECHAR.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnFECHAR.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnFECHAR.Location = new System.Drawing.Point(382, 494);
            this.btnFECHAR.Name = "btnFECHAR";
            this.btnFECHAR.Size = new System.Drawing.Size(135, 61);
            this.btnFECHAR.TabIndex = 9;
            this.btnFECHAR.Text = "Fechar";
            this.btnFECHAR.UseVisualStyleBackColor = false;
            this.btnFECHAR.Click += new System.EventHandler(this.btnFECHAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Renda Familiar:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(102, 630);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(148, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total de Gastos:";
            // 
            // lblGASTOS
            // 
            this.lblGASTOS.AutoSize = true;
            this.lblGASTOS.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGASTOS.Location = new System.Drawing.Point(352, 630);
            this.lblGASTOS.Name = "lblGASTOS";
            this.lblGASTOS.Size = new System.Drawing.Size(53, 23);
            this.lblGASTOS.TabIndex = 7;
            this.lblGASTOS.Text = "0,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(102, 700);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "Saldo:";
            // 
            // lblSALDO
            // 
            this.lblSALDO.AutoSize = true;
            this.lblSALDO.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSALDO.Location = new System.Drawing.Point(352, 700);
            this.lblSALDO.Name = "lblSALDO";
            this.lblSALDO.Size = new System.Drawing.Size(53, 23);
            this.lblSALDO.TabIndex = 9;
            this.lblSALDO.Text = "0,00";
            // 
            // txtRENDA
            // 
            this.txtRENDA.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRENDA.Location = new System.Drawing.Point(202, 67);
            this.txtRENDA.Name = "txtRENDA";
            this.txtRENDA.Size = new System.Drawing.Size(200, 24);
            this.txtRENDA.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(561, 787);
            this.ControlBox = false;
            this.Controls.Add(this.lblSALDO);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblGASTOS);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFECHAR);
            this.Controls.Add(this.btnNOVO);
            this.Controls.Add(this.btnCALCULAR);
            this.Controls.Add(this.txtRENDA);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtELETRICA;
        private System.Windows.Forms.TextBox txtOUTROS;
        private System.Windows.Forms.TextBox txtALIMENTO;
        private System.Windows.Forms.TextBox txtTV;
        private System.Windows.Forms.TextBox txtAGUA;
        private System.Windows.Forms.Button btnCALCULAR;
        private System.Windows.Forms.Button btnNOVO;
        private System.Windows.Forms.Button btnFECHAR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblGASTOS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblSALDO;
        private System.Windows.Forms.TextBox txtRENDA;
    }
}

