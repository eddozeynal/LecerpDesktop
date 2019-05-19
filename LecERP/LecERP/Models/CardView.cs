using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace LecERP.Models
{
	public class CardView

    {
                    

    	public int Id { get; set; }

    	public byte CardTypeId { get; set; }

    	public string CardNumber { get; set; }

    	public string CardName { get; set; }

    	public decimal DebtLimit { get; set; }

    	public byte CurrencyId { get; set; }

    	public string TaxCode { get; set; }

    	public string LocationAddress { get; set; }

    	public string Phone1 { get; set; }

    	public string Phone2 { get; set; }

    	public string Phone3 { get; set; }

    	public string Country { get; set; }

    	public string City { get; set; }

    	public string Town { get; set; }

    	public string District { get; set; }

    	public float Latitude { get; set; }

    	public float Longitude { get; set; }

    	public bool IsActive { get; set; }

    	public int CreatedBy { get; set; }

    	public DateTime CreatedDate { get; set; }

    	public string CardTypeName { get; set; }

    	public string CurrencyName { get; set; }

    	public bool ByPermission { get; set; }

    	public bool RemainingCalculated { get; set; }

    	public bool TransactionCalculated { get; set; }

    }
            }
            