using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace LecERP.Models
{
	public class ExchangeTransaction

    {
                    

    	public int Id { get; set; }

    	public string Ficheno { get; set; }

    	public int SourceCardId { get; set; }

    	public int DestCardId { get; set; }

    	public decimal Total { get; set; }

    	public decimal CurrencyRate { get; set; }

    	public string Note { get; set; }

    	public int CreatedBy { get; set; }

    	public DateTime CreatedDate { get; set; }
        

    }
            }
            