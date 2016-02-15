/*
 * Created by SharpDevelop.
 * User: Ours
 * Date: 06/02/2016
 * Time: 02:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Windows.Forms;
using System.Data;

namespace SepaWritter
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		sepadll.Sepa monSepa;
		DataSet ds 		= new DataSet();
		double total 	= 0;

		public MainForm() {
			InitializeComponent();
		}

		void Button1Click(object sender, EventArgs e) {
			try {
				if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
					ds = ExcelLibrary.DataSetHelper.CreateDataSet(openFileDialog1.FileName);
				}
				//DataGrid update...
				UpdateDataGrid();

				GetMontantTotal();
				UpdateLabelMontant();
			}
			catch {
				MessageBox.Show("Erreur! Impossible d'ouvrir le fichier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		void GetMontantTotal() {
	        foreach (DataRow row in ds.Tables[0].Rows) {
	        	if (row[5].ToString().Length == 0) {
	        		continue;
	        	}
				total += Convert.ToDouble(row[5].ToString());
	        }			
		}

		void CreateVirement() {

	        int i 					= 1;
	        DateTime dateVirement 	= dateTimePicker1.Value;
	        UpdateLabelMontant();
	        //Bank get start at 1, not at 0
	        monSepa 				= new sepadll.Sepa(dateVirement);

	        monSepa.msgId 			= string.IsNullOrEmpty(textBox1.Text)?"Aucun libellé":textBox1.Text;
	        monSepa.montantTotal 	= total.ToString().Replace(',', '.');
	        monSepa.controlBank 	= checkBox1.Checked;
	        monSepa.nomClient 		= string.IsNullOrEmpty(textBox2.Text)?"Aucun nom":textBox2.Text;

	        monSepa.Initialisation(ds.Tables[0].Rows.Count+1);

	        foreach (DataRow row in ds.Tables[0].Rows) {
					//montant need to be a decimal
					if (!monSepa.MontantIsDecimal(row[5].ToString())) {
					    continue;
					}
	        		monSepa.matricule 		= row[0].ToString();
	        		monSepa.nomSalarie 		= row[1].ToString().Trim()+' '+row[2].ToString().Trim();
	        		monSepa.iban 			= row[3].ToString();
	        		monSepa.bic 			= row[4].ToString();
	        		monSepa.ibanDebiteur 	= row[6].ToString();
	        		monSepa.bicDebiteur 	= row[7].ToString();
	        		monSepa.SetMontant(row[5].ToString());	        		
	        		
					monSepa.GetEmetteur(i);
	        		monSepa.GetRecepteur();
		        	monSepa.SetControlToFalse();
	        		
		        	if (checkBox1.Checked) {
		        		monSepa.CloseEmetteur();
		        	}
	        		i++;
	        }
	        
	        if (!checkBox1.Checked) {
	        	monSepa.CloseEmetteur();
	        }
	        monSepa.EndEmetteur();
		}

		void Button3Click(object sender, EventArgs e) {
			//if no excel file loaded...
	        if (ds.Tables.Count == 0 ) {
	        	return;
	        }
			
			CreateVirement();
		    
			saveFileDialog1.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*"  ;
		    saveFileDialog1.Title = "Save your xml";
		    saveFileDialog1.RestoreDirectory = true ;
		    System.IO.Stream myStream;
		    
		    if (saveFileDialog1.ShowDialog() == DialogResult.OK) {

		        if ((myStream = saveFileDialog1.OpenFile()) != null) {

					System.IO.StreamWriter file = new System.IO.StreamWriter(myStream);
					file.WriteLine(monSepa.xmlcode);
					file.Close();
			        myStream.Close();
		        
		    	}
		     	else {
		     		MessageBox.Show("Erreur! Impossible d'enregistrer le fichier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
		     	}
		     }
		}
		
		/*
		 * Update label for montant
		 */ 
		void UpdateLabelMontant() {
			label15.Text = total.ToString();
		}

		/*
		 * Update Data grid
		 */
		void UpdateDataGrid() {
			dataGridView1.DataSource = ds.Tables[0];
		}

		void Button4Click(object sender, EventArgs e) {
			
			var da = new DataSet();
			var dt = new DataTable();
            
			for (int i=0; i<dataGridView2.Columns.Count; i++) {
				dt.Columns.Add(dataGridView2.Columns[i].Name.Remove(0, 6));
			}
			
			foreach (DataGridViewRow row in dataGridView2.Rows) {
				DataRow dr = dt.NewRow();
				
				for (int j=0; j<dataGridView2.Columns.Count; j++) {
					dr[j] = row.Cells[j].FormattedValue;
				}
				
				dt.Rows.Add(dr);
            }
            
			da.Tables.Add(dt);
            
			var workbook = new ExcelLibrary.SpreadSheet.Workbook();
			ExcelLibrary.DataSetHelper.CreateWorkbook("Feuille_compta.xls", da);		        
		}
	}
}
