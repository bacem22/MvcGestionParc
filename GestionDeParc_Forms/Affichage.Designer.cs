namespace GestionDeParc_Forms
{
    partial class Affichage
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.list_Veh = new System.Windows.Forms.ListBox();
            this.textBox_Nom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Marq = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Mat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Cou = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Montant = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox_type = new System.Windows.Forms.TextBox();
            this.but_mod = new System.Windows.Forms.Button();
            this.but_sup = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.list_Veh);
            this.groupBox1.Location = new System.Drawing.Point(12, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Liste Des Véhicule";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.but_sup);
            this.groupBox2.Controls.Add(this.but_mod);
            this.groupBox2.Controls.Add(this.textBox_type);
            this.groupBox2.Controls.Add(this.textBox_id);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox_Montant);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBox_Cou);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox_Mat);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox_Marq);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBox_Nom);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(362, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(343, 325);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // list_Veh
            // 
            this.list_Veh.FormattingEnabled = true;
            this.list_Veh.Location = new System.Drawing.Point(6, 42);
            this.list_Veh.Name = "list_Veh";
            this.list_Veh.Size = new System.Drawing.Size(321, 264);
            this.list_Veh.TabIndex = 0;
            this.list_Veh.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox_Nom
            // 
            this.textBox_Nom.Location = new System.Drawing.Point(130, 45);
            this.textBox_Nom.Name = "textBox_Nom";
            this.textBox_Nom.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nom.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nom de Véhicule";
            // 
            // textBox_Marq
            // 
            this.textBox_Marq.Location = new System.Drawing.Point(130, 70);
            this.textBox_Marq.Name = "textBox_Marq";
            this.textBox_Marq.Size = new System.Drawing.Size(100, 20);
            this.textBox_Marq.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Marque";
            // 
            // textBox_Mat
            // 
            this.textBox_Mat.Location = new System.Drawing.Point(131, 95);
            this.textBox_Mat.Name = "textBox_Mat";
            this.textBox_Mat.Size = new System.Drawing.Size(100, 20);
            this.textBox_Mat.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Matrécule";
            // 
            // textBox_Cou
            // 
            this.textBox_Cou.Location = new System.Drawing.Point(131, 124);
            this.textBox_Cou.Name = "textBox_Cou";
            this.textBox_Cou.Size = new System.Drawing.Size(100, 20);
            this.textBox_Cou.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Couleur";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Type de Véhicule";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 189);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 195);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Date d\'entrer";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(131, 223);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(191, 20);
            this.dateTimePicker2.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Date de sortir";
            // 
            // textBox_Montant
            // 
            this.textBox_Montant.Location = new System.Drawing.Point(130, 258);
            this.textBox_Montant.Name = "textBox_Montant";
            this.textBox_Montant.Size = new System.Drawing.Size(100, 20);
            this.textBox_Montant.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Montant";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(130, 16);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(100, 20);
            this.textBox_id.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "ID Véhicule";
            // 
            // textBox_type
            // 
            this.textBox_type.Location = new System.Drawing.Point(131, 159);
            this.textBox_type.Name = "textBox_type";
            this.textBox_type.Size = new System.Drawing.Size(100, 20);
            this.textBox_type.TabIndex = 25;
            // 
            // but_mod
            // 
            this.but_mod.Location = new System.Drawing.Point(45, 296);
            this.but_mod.Name = "but_mod";
            this.but_mod.Size = new System.Drawing.Size(75, 23);
            this.but_mod.TabIndex = 26;
            this.but_mod.Text = "Modifier";
            this.but_mod.UseVisualStyleBackColor = true;
            this.but_mod.Click += new System.EventHandler(this.but_mod_Click);
            // 
            // but_sup
            // 
            this.but_sup.Location = new System.Drawing.Point(225, 296);
            this.but_sup.Name = "but_sup";
            this.but_sup.Size = new System.Drawing.Size(75, 23);
            this.but_sup.TabIndex = 27;
            this.but_sup.Text = "Supprimer";
            this.but_sup.UseVisualStyleBackColor = true;
            this.but_sup.Click += new System.EventHandler(this.but_sup_Click);
            // 
            // Affichage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 375);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Affichage";
            this.Text = "Affichage";
            this.Load += new System.EventHandler(this.Affichage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox list_Veh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Nom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Marq;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Mat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Cou;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Montant;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox_type;
        private System.Windows.Forms.Button but_sup;
        private System.Windows.Forms.Button but_mod;
    }
}