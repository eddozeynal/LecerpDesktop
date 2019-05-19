using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace LecERP.Models
{
	public class ItemPrice

    {
                    

    	public int Id { get; set; }

    	public byte PriceTypeId { get; set; }

    	public int ItemId { get; set; }

    	public int CardId { get; set; }

    	public decimal Price { get; set; }

    	public int CreatedBy { get; set; }

    	public DateTime CreatedDate { get; set; }

    }
            }
            