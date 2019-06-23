using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LecERP.Models
{
	public class WarehouseProcessDetailView

    {
                    

    	public int Id { get; set; }

    	public int ProcessId { get; set; }

    	public int ServiceItemId { get; set; }

    	public bool IsCompleted { get; set; }

    	public int CompletedBy { get; set; }

    	public DateTime? CompletedDate { get; set; }

        public string ItemCode { get; set; }

        public string ItemName { get; set; }

        public string CompletedByUserName { get; set; }

    }
}
            