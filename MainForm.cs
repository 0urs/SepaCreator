/*
 * Created by SharpDevelop.
 * User: Ours
 * Date: 06/02/2016
 * Time: 02:08
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;
using System.Data.OleDb;

namespace SepaWritter
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Sepa monSepa;
		DataSet ds = new DataSet();

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e) {
			try {
				if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
					connectionOleDb(openFileDialog1.FileName);
				}
				UpdateDataGrid();
			}
			catch {
				MessageBox.Show("Erreur! Impossible d'ouvrir le fichier", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		void connectionOleDb(string filename) {

			string connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + filename + ";Extended Properties=\"Excel 8.0\";";

			var connection = new OleDbConnection(connectionString);
			connection.Open();

			var command = new OleDbCommand();
			command.Connection = connection;

			string sheetName = GetSheetName(connection);

			command.CommandText = "SELECT * FROM ["+sheetName+"]";

			var dt = new DataTable();
			dt.TableName = sheetName;

			var da = new OleDbDataAdapter(command);
			da.Fill(dt);
			
			ds.Tables.Add(dt);
			
	        command = null;
	        connection.Close();
	        /*
	         * Probleme : Si le fichier excel ne contient pas d'entete, il bouffe la premiere ligne
	         */
		}
		
		void UpdateDataGrid() {
			dataGridView1.DataSource = ds.Tables[0];
		}
		
		string GetSheetName(OleDbConnection connection) {

	        DataTable dtSheet = connection.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
	        string sheetName = "";
	        
	        foreach (DataRow dr in dtSheet.Rows) {
	        	sheetName = dr["TABLE_NAME"].ToString();
	        	
	        	if (!sheetName.EndsWith("$")) {
	        		continue;
	        	}
	        }			
			
	        return sheetName;
		}

		void CreateVirement() {

	        double total 			= 0;
	        int i 					= 1;
	        DateTime dateVirement 	= dateTimePicker1.Value;
	        
	        foreach (DataRow row in ds.Tables[0].Rows) {
	        	if (row[6].ToString().Length == 0) {
	        		continue;
	        	}
	        	total += Convert.ToDouble(row[6].ToString());
	        }
			
	        //Il faut ajouter 1 pour que le compte tombe juste. Les banques ne commencent pas les list a 0...
	        monSepa 		= new Sepa(ds.Tables[0].Rows.Count+1, dateVirement);
	        monSepa.msgId 	= "On sen fou";
	        monSepa.montantTotal = total.ToString();

	        foreach (DataRow row in ds.Tables[0].Rows) {
	        	foreach(DataColumn column in ds.Tables[0].Columns) {

	        		monSepa.ibanDebiteur 	= row[7].ToString();
	        		monSepa.iban 			= row[4].ToString();
	        		monSepa.bicDebiteur 	= row[8].ToString();
	        		monSepa.SetMontant(row[6].ToString());
	        		monSepa.bic 			= row[5].ToString();
	        		monSepa.matricule 		= row[1].ToString();
	        		monSepa.nomSalarie 		= row[2].ToString().Trim()+' '+row[3].ToString().Trim();

	        		monSepa.GetEmetteur(i);
	        		monSepa.GetRecepteur();
	        		
	        	}

	        	monSepa.SetControlToFalse();
	        	monSepa.CloseEmetteur();
	        	i++;
	        }
	        monSepa.EndEmetteur();
		}

		void Button3Click(object sender, EventArgs e) {
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
					// Write the string to a file.
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
	}
}
