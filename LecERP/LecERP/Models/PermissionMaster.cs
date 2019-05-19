using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace LecERP.Models
{
	public class PermissionMaster

    {
                    

    	public int Id { get; set; }

    	public int ParentId { get; set; }

    	public string Name { get; set; }

    	public string KeyWord { get; set; }

    	public bool IsActive { get; set; }

    }
}
            