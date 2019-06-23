using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LecERP.Models
{
	public class WarehouseProcess

    {
                    

    	public int Id { get; set; }

    	public byte StatusId { get; set; }

    	public int CreatedBy { get; set; }

    	public DateTime CreatedDate { get; set; }

    	public DateTime? ProcessBeginDate { get; set; }

    	public DateTime? ProcessEndDate { get; set; }

    }
}
            