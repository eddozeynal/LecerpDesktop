using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace LecERP.Models
{
	public class User

    {
                    

    	public int Id { get; set; }

    	public string Login { get; set; }

    	public string UserName { get; set; }

    	public string PassHash { get; set; }

    	public bool IsActive { get; set; }

    	public bool IsAdmin { get; set; }

    }
}
            