using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LecERP.Models
{
	public class WarehouseProcessDetail

    {
                    

    	public int Id { get; set; }

    	public int ProcessId { get; set; }

    	public int ServiceItemId { get; set; }

    	public bool IsCompleted { get; set; }

    	public int CompletedBy { get; set; }

    	public DateTime? CompletedDate { get; set; }

    }
}
            