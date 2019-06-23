using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace LecERP.Models
{
	public class FicheReportLineView

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

    	public string ItemName { get; set; }

    	public string ItemCode { get; set; }

    	public string ItemTypeName { get; set; }

    	public decimal ServiceLineNetTotalSum { get; set; }

    	public decimal? LineFinalSum { get; set; }

    	public DateTime CreatedDate { get; set; }

    	public decimal CurrencyRate { get; set; }

        public string Ficheno { get; set; }
    }
            }
            