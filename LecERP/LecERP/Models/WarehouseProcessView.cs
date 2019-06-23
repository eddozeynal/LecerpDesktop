using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LecERP.Models
{
	public class WarehouseProcessView
    {
                    
    	public int Id { get; set; }

    	public byte StatusId { get; set; }

    	public int CreatedBy { get; set; }

    	public DateTime CreatedDate { get; set; }

    	public DateTime? ProcessBeginDate { get; set; }

    	public DateTime? ProcessEndDate { get; set; }

        public string UserName { get; set; }

        public string StatusName { get; set; }

        public List<WarehouseProcessDetail> Details { get; set; }

        public List<WarehouseProcessFiche> Fiches { get; set; }
    }
}
            