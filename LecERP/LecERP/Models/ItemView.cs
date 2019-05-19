using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LecERP.Models
{
	public class ItemView

    {
                    

    	
		public int Id { get; set; }

    	
		public byte ItemTypeId { get; set; }

    	
		public string ItemCode { get; set; }

    	
		public string ItemName { get; set; }

    	
		public string Group1 { get; set; }

    	
		public string Group2 { get; set; }

    	
		public string Group3 { get; set; }

    	
		public string Group4 { get; set; }

    	
		public int CreatedBy { get; set; }

    	
		public DateTime CreatedDate { get; set; }

    	
		public decimal Length { get; set; }

    	
		public decimal Width { get; set; }

    	
		public byte LineCalcTypeId { get; set; }

    	
		public string ItemTypeName { get; set; }

    	
		public decimal DefaultSalePrice { get; set; }

    	
		public decimal DefaultPurchasePrice { get; set; }

    }
            }
            