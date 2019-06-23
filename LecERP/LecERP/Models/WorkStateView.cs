using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace LecERP.Models
{
	public class WorkStateView

    {
                    

    	public int Id { get; set; }

    	public int ParentId { get; set; }

    	public byte JobId { get; set; }

    	public int PersonnelId { get; set; }

    	public string JobName { get; set; }

    	public string PersonnelName { get; set; }

    }
            }
            