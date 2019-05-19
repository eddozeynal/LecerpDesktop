using System;
using System.Collections.Generic;
using System.Runtime.Serialization;


namespace LecERP.Models
{
	public class DataLog

    {
                    

    	public int Id { get; set; }

    	public DateTime LogDate { get; set; }

    	public byte LogDataType { get; set; }

    	public int LogDataId { get; set; }

    	public int DoneBy { get; set; }

    	public string Data { get; set; }

    }
            }
            