using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace LecERP.Models
{
	public class CashTransaction

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
    }
            }
            