using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace LecERP.Models
{
	public class CardType

    {
                    

    	public byte Id { get; set; }

    	public string CardTypeName { get; set; }

    	public bool ByPermission { get; set; }

    	public bool RemainingCalculated { get; set; }

    	public bool TransactionCalculated { get; set; }

    }
}