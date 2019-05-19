using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ERPService.Models
{
	public class CashTransactionView

    {
                    

    	public int Id { get; set; }

    	public byte CashTypeId { get; set; }

    	public string Ficheno { get; set; }

    	public int SourceCardId { get; set; }

    	public int DestCardId { get; set; }

    	public decimal Total { get; set; }

        public byte CurrencyId { get; set; }

        public decimal CurrencyRate { get; set; }

        public byte StatusId { get; set; }

    	public string Note { get; set; }

    	public int CreatedBy { get; set; }

    	public DateTime CreatedDate { get; set; }

    	public int ConnectedFicheId { get; set; }

    	public string CashTypeName { get; set; }

    	public string CurrencyName { get; set; }

    	public string UserName { get; set; }

    	public string StatusName { get; set; }

    	public bool SourceCardByPermission { get; set; }

    	public string SourceCardNumber { get; set; }

    	public string SourceCardName { get; set; }

    	public bool DestCardByPermission { get; set; }

    	public string DestCardNumber { get; set; }

    	public string DestCardName { get; set; }

    	public string ConnectedInvoice { get; set; }

        public decimal DmTotal { get; set; }
    }
            }
            