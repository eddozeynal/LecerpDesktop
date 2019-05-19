using LecERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LecERP.ViewModels
{
    public class UserView : User
    {
        public List<PermissionDetail> PermissionDetails { get; set; }

        public LoginSession LoginSession { get; set; }

        public List<CardPermission> CardPermissions { get; set; }
    }
}
