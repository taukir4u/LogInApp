using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LogInApp.Models
{
    public class User
    {
        public int UserID { set; get; }
        [Display(Name="User Name")]
        public string UserName { set; get; }
         [Display(Name = "Password")]
        public string Password { set; get; }
    }
}