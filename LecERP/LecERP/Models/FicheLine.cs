using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace LecERP.Models
{
	public class FicheLine

    {
                    

    	public int Id { get; set; }

    	public int FicheId { get; set; }

    	public byte ItemTypeId { get; set; }

    	public int ItemId { get; set; }

    	public int LineNumber { get; set; }

    	public string Note { get; set; }

    	public decimal Quantity { get; set; }

    	public decimal ShippedQuantity { get; set; }

    	public decimal Length { get; set; }

    	public decimal Width { get; set; }

    	public decimal ItemPrice { get; set; }

    	public decimal LinePrice { get; set; }

    	public decimal LineTotal { get; set; }

    	public decimal LineDiscount { get; set; }

    	public decimal LineNetTotal { get; set; }

    	public decimal LineExpense { get; set; }

    	public decimal LineTotalAcc { get; set; }

        public bool IsCustomerItem { get; set; }

        public bool IsSketched { get; set; }

        public bool IsTemplated { get; set; }

    }
            }
            