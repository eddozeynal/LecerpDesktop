using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace LecERP.Models
{
	public class FicheLineServiceView

    {
                    

    	public int Id { get; set; }

    	public int FicheLineId { get; set; }

    	public int ServiceItemId { get; set; }

    	public decimal Quantity { get; set; }

    	public decimal ItemPrice { get; set; }

    	public decimal LinePrice { get; set; }

    	public decimal LineTotal { get; set; }

    	public decimal LineDiscount { get; set; }

    	public decimal LineNet { get; set; }

        public string ItemCode { get; set; }

        public string ItemName { get; set; }

    }
            }
            