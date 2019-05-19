using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace LecERP.Models
{
	public class Parameter

    {
                    

    	public string ParameterKey { get; set; }

    	public string ParameterDescription { get; set; }

    	public string ParameterValue { get; set; }

    	public bool CanAdminChange { get; set; }

    	public bool CanUserChange { get; set; }

    }
            }
            