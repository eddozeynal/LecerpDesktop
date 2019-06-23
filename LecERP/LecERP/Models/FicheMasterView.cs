using LecERP.ViewModels;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace LecERP.Models
{
	public class FicheMasterView

    {
                    

    	public int Id { get; set; }

    	public byte DocTypeId { get; set; }

    	public string Ficheno { get; set; }

    	public string SourceDocument { get; set; }

    	public int CardId { get; set; }

    	public int SourceWarehouse { get; set; }

    	public int DestinationWarehouse { get; set; }

    	public byte CurrencyId { get; set; }

    	public decimal CurrencyRate { get; set; }

    	public string Note1 { get; set; }

    	public string Note2 { get; set; }

    	public string Note3 { get; set; }

    	public string Note4 { get; set; }

    	public int CreatedBy { get; set; }

    	public DateTime CreatedDate { get; set; }

    	public byte StatusId { get; set; }

    	public int SourceFicheId { get; set; }

    	public decimal LinesTotal { get; set; }

    	public decimal LineDiscountsTotal { get; set; }

    	public decimal LinesNetTotal { get; set; }

    	public decimal FicheDiscount { get; set; }

    	public decimal FicheServicesNetTotal { get; set; }

    	public decimal FicheNetTotal { get; set; }

    	public decimal LineExpensesTotal { get; set; }

    	public decimal FicheTotalAcc { get; set; }

    	public string CurrencyName { get; set; }

    	public string CardNumber { get; set; }

    	public string CardName { get; set; }

    	public string StatusName { get; set; }

        public List<FicheLineView> Lines { get; set; }

        public int ProcessId { get; set; }

    }
            }
            