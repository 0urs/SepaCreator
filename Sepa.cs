/*
 * Created by SharpDevelop.
 * User: Ours
 * Date: 06/02/2016
 * Time: 04:15
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Text.RegularExpressions;

namespace SepaWritter
{
	/// <summary>
	/// Description of Sepa.
	/// </summary>
	public class Sepa
	{	
		//Variable de controle
		//bool _isDTDSet 			= false;
		bool _isGroupHeaderSet 	= false;
		bool _isEmetteurSet 	= false;
		bool _isRecepteurSet 	= false;
		
		//Constante
		public const string dtd 		= "<Document xmlns=\"urn:iso:std:iso:20022:tech:xsd:pain.001.001.03\">";
		
		//Accesseur
		public string msgId { get; set; }
		public string nomClient { get; set; }
		
		public string xmlcode { get; private set; }
		public string dateVirement { get; private set; }

		public string montantTotal { get; set; }
		public string montant { get; set; }

		public string nomSalarie { get; set; }
		public string matricule { get; set; }
		
		public string iban { get; set; }
		public string bic { get; set; }
		
		public string ibanDebiteur { get; set; }
		public string bicDebiteur { get; set; }
		
		public bool controlBank { get; set; }

		
		public Sepa(DateTime dV) {
			dateVirement = dateVirementFormat(dV);
		}
		
		public void Initialisation(int nbLignes) {
			xmlcode = "";
			SetPrologue();
			SetDTD();
			GetGroupHeader(nbLignes);
		}

		public void GetEmetteur(int i){
			if (_isEmetteurSet) {
				return;
			}
			string mt = "";
			if (controlBank) {
				mt = montant;
			}
			else {
				mt = montantTotal;
			}

			xmlcode += "<PmtInf>";
			xmlcode += "<PmtInfId>"+ msgId +" /"+ i +"</PmtInfId>";
			xmlcode += "<PmtMtd>TRF</PmtMtd>";																			//Seule la valeur "TRF" est autorisée.
			xmlcode += "<BtchBookg>false</BtchBookg>";
			xmlcode += "<NbOfTxs>1</NbOfTxs>";
			xmlcode += "<CtrlSum>"+ mt +"</CtrlSum>";
			xmlcode += "<PmtTpInf>";
			xmlcode += "<SvcLvl><Cd>SEPA</Cd></SvcLvl>";																	//Seule la valeur "SEPA" est autorisée.
			xmlcode += "</PmtTpInf>";
			xmlcode += "<ReqdExctnDt>"+ dateVirement +"</ReqdExctnDt>";
			xmlcode += "<Dbtr><Nm>"+ nomClient +"</Nm></Dbtr>";
			xmlcode += "<DbtrAcct><Id><IBAN>"+ ibanDebiteur +"</IBAN></Id></DbtrAcct>";
			xmlcode += "<DbtrAgt><FinInstnId><BIC>"+ bicDebiteur +"</BIC></FinInstnId></DbtrAgt>";
			xmlcode += "<ChrgBr>SLEV</ChrgBr>";																			//Seule la valeur "SLEV" est autorisée.
	
			_isEmetteurSet = true;			
		}
		
		public void GetRecepteur(){
			if (_isRecepteurSet) {
				return;
			}

			xmlcode += "<CdtTrfTxInf>";
			xmlcode += "<PmtId>";
			xmlcode += "<InstrId>"+ msgId +"</InstrId>";
			xmlcode += "<EndToEndId>"+ msgId +"</EndToEndId>";
			xmlcode += "</PmtId>";
			xmlcode += "<Amt><InstdAmt Ccy=\"EUR\">"+ montant +"</InstdAmt></Amt>";
			xmlcode += "<CdtrAgt><FinInstnId><BIC>"+ bic +"</BIC></FinInstnId></CdtrAgt>";
			xmlcode += "<Cdtr>";
			xmlcode += "<Nm>"+ nomSalarie +"</Nm>";
			xmlcode += "</Cdtr>";
			xmlcode += "<CdtrAcct><Id><IBAN>"+ iban +"</IBAN></Id></CdtrAcct>";
			xmlcode += "<RmtInf><Ustrd>"+ msgId +"</Ustrd></RmtInf>";
			xmlcode += "</CdtTrfTxInf>";
			
			_isRecepteurSet = true;
		}
		
		void GetGroupHeader(int nbLignes) {
			if (_isGroupHeaderSet) {
				return;
			}

			xmlcode += "<CstmrCdtTrfInitn><GrpHdr>";
			xmlcode += "<MsgId>"+ msgId +"</MsgId>";
			xmlcode += "<CreDtTm>"+ dateFormat() +"</CreDtTm>";
			xmlcode += "<NbOfTxs>"+ nbLignes +"</NbOfTxs>";
			xmlcode += "<CtrlSum>"+ montantTotal +"</CtrlSum>";
			xmlcode += "<InitgPty>";
			xmlcode += "<Nm>"+ nomClient +"</Nm>";
			xmlcode += "</InitgPty>";
			xmlcode += "</GrpHdr>";
			
			_isGroupHeaderSet = true;
		}
		
		public void SetPrologue() {
			xmlcode = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
		}
		
		//Genere le DTD obligatoire en début de fichier
		void SetDTD() {
			xmlcode += "<Document xmlns=\"urn:iso:std:iso:20022:tech:xsd:pain.001.001.03\">";
		}
		
		string dateFormat() {
			var dt = DateTime.Now;
			string maDate = dt.ToString("yyyy-MM-ddTHH:mm:ss");
			return maDate;
		}
		
		string dateVirementFormat(DateTime dv) {
			return dv.ToString("yyyy-MM-dd");
		}
		
		public void CloseEmetteur() {
			xmlcode += "</PmtInf>";
		}

		public void EndEmetteur() {
			xmlcode += "</CstmrCdtTrfInitn></Document>";
		}
		
		public void SetControlToFalse() {
			if (controlBank) {
				_isEmetteurSet = false;
			}
			_isRecepteurSet = false;
		}

		public void SetMontant(string mt) {
			if (String.IsNullOrEmpty(mt) || mt.Length>18) {
				montant = "0.00";
			}
			else {
				montant = mt.Replace(',', '.');
			}
		}

		public bool MontantIsDecimal(string mt) {

			double temp 			= 0;
			bool montantIsDecimal 	= double.TryParse(mt, out temp);
			
			if (montantIsDecimal) {
				return true;
			}
			//Rajouter des test si necessaire
			
			return false;
		}
	}
}
