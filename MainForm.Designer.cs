/*
 * Created by SharpDevelop.
 * User: Ours
 * Date: 06/02/2016
 * Time: 02:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SepaWritter
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMatricule;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNom;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrenom;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIbanDebiteur;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBicDebiteur;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMontant;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIban;
		private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBicCrediteur;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label15;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button1 = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.label14 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label15 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.ColumnMatricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnPrenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnIbanDebiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnBicDebiteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnMontant = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnIban = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColumnBicCrediteur = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button4 = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.panel3.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToOrderColumns = true;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(3, 6);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(812, 597);
			this.dataGridView1.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(906, 283);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(129, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Ouvrir un document";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dateTimePicker1.Location = new System.Drawing.Point(1013, 456);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(95, 20);
			this.dateTimePicker1.TabIndex = 3;
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(906, 562);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(129, 23);
			this.button3.TabIndex = 4;
			this.button3.Text = "Enregistrer";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(881, 365);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(182, 20);
			this.textBox1.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(881, 351);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(182, 23);
			this.label1.TabIndex = 6;
			this.label1.Text = "Libellé du virement";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(15, 195);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(261, 47);
			this.label2.TabIndex = 7;
			this.label2.Text = "Si aucune date n\'est selectionnée, celle d\'aujourd\'hui sera mise par défaut";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(3, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(238, 14);
			this.label3.TabIndex = 8;
			this.label3.Text = "-Première étape : Ouvrir un fichier au format excel";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(3, 42);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(261, 32);
			this.label4.TabIndex = 9;
			this.label4.Text = "-Deuxième étape : Taper le libellé désiré dans la case pourvu à cet effet";
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.GreenYellow;
			this.button2.Location = new System.Drawing.Point(277, 195);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(27, 23);
			this.button2.TabIndex = 10;
			this.button2.Text = "?";
			this.button2.UseVisualStyleBackColor = false;
			// 
			// panel1
			// 
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Location = new System.Drawing.Point(821, 6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(309, 271);
			this.panel1.TabIndex = 12;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(15, 232);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(289, 23);
			this.label13.TabIndex = 17;
			this.label13.Text = "Si vous avez un problème, cliquez sur le bouton vert à coté";
			// 
			// label12
			// 
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(3, 172);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 16;
			this.label12.Text = "Remarque :";
			// 
			// label10
			// 
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Red;
			this.label10.Location = new System.Drawing.Point(33, 109);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(57, 14);
			this.label10.TabIndex = 13;
			this.label10.Text = "Attention :";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(3, 139);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(238, 23);
			this.label9.TabIndex = 13;
			this.label9.Text = "-Dernière étape: Enregistrez votre document";
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(96, 109);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(190, 30);
			this.label7.TabIndex = 13;
			this.label7.Text = "ceci ne modifiera pas la date de création du fichier de virement";
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.MediumBlue;
			this.label8.Location = new System.Drawing.Point(84, 2);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(129, 17);
			this.label8.TabIndex = 14;
			this.label8.Text = "Marche à suivre";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(36, 91);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(177, 18);
			this.label6.TabIndex = 13;
			this.label6.Text = "-Modifier la date d\'ordre du virement";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(3, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 17);
			this.label5.TabIndex = 10;
			this.label5.Text = "- Optionnel :";
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 2);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1144, 635);
			this.tabControl1.TabIndex = 13;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.label14);
			this.tabPage1.Controls.Add(this.panel3);
			this.tabPage1.Controls.Add(this.label11);
			this.tabPage1.Controls.Add(this.textBox2);
			this.tabPage1.Controls.Add(this.checkBox1);
			this.tabPage1.Controls.Add(this.panel1);
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Controls.Add(this.button1);
			this.tabPage1.Controls.Add(this.button3);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.dateTimePicker1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1136, 609);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Sepa";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(858, 456);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 14);
			this.label14.TabIndex = 17;
			this.label14.Text = "Montant Total :";
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.label15);
			this.panel3.Location = new System.Drawing.Point(858, 473);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(111, 46);
			this.panel3.TabIndex = 16;
			// 
			// label15
			// 
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(3, 6);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(105, 33);
			this.label15.TabIndex = 0;
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(881, 388);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(182, 14);
			this.label11.TabIndex = 15;
			this.label11.Text = "Nom du client";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(881, 405);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(182, 20);
			this.textBox2.TabIndex = 14;
			// 
			// checkBox1
			// 
			this.checkBox1.Location = new System.Drawing.Point(1013, 482);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(95, 32);
			this.checkBox1.TabIndex = 13;
			this.checkBox1.Text = "Multi-banque";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.dataGridView2);
			this.tabPage2.Controls.Add(this.button4);
			this.tabPage2.Controls.Add(this.panel2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1136, 609);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Fichier";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.ColumnMatricule,
			this.ColumnNom,
			this.ColumnPrenom,
			this.ColumnIbanDebiteur,
			this.ColumnBicDebiteur,
			this.ColumnMontant,
			this.ColumnIban,
			this.ColumnBicCrediteur});
			this.dataGridView2.Location = new System.Drawing.Point(6, 6);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(845, 597);
			this.dataGridView2.TabIndex = 6;
			// 
			// ColumnMatricule
			// 
			this.ColumnMatricule.HeaderText = "Matricule";
			this.ColumnMatricule.Name = "ColumnMatricule";
			// 
			// ColumnNom
			// 
			this.ColumnNom.HeaderText = "Nom";
			this.ColumnNom.Name = "ColumnNom";
			// 
			// ColumnPrenom
			// 
			this.ColumnPrenom.HeaderText = "Prénom";
			this.ColumnPrenom.Name = "ColumnPrenom";
			// 
			// ColumnIbanDebiteur
			// 
			this.ColumnIbanDebiteur.HeaderText = "IBAN débiteur";
			this.ColumnIbanDebiteur.Name = "ColumnIbanDebiteur";
			// 
			// ColumnBicDebiteur
			// 
			this.ColumnBicDebiteur.HeaderText = "BIC débiteur";
			this.ColumnBicDebiteur.Name = "ColumnBicDebiteur";
			// 
			// ColumnMontant
			// 
			this.ColumnMontant.HeaderText = "Montant";
			this.ColumnMontant.Name = "ColumnMontant";
			// 
			// ColumnIban
			// 
			this.ColumnIban.HeaderText = "IBAN créditeur";
			this.ColumnIban.Name = "ColumnIban";
			// 
			// ColumnBicCrediteur
			// 
			this.ColumnBicCrediteur.HeaderText = "BIC créditeur";
			this.ColumnBicCrediteur.Name = "ColumnBicCrediteur";
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(947, 236);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(105, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "Enregistrer";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.Button4Click);
			// 
			// panel2
			// 
			this.panel2.Location = new System.Drawing.Point(869, 6);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(261, 160);
			this.panel2.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1168, 649);
			this.Controls.Add(this.tabControl1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "MainForm";
			this.Text = "SepaWritter";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
