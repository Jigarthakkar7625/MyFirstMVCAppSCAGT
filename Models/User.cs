using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFirstMVCAppSCAGT.Models
{
    public class UserDemo
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// input text
        /// </summary>
        public string UserName { get; set; }
        public string Password { get; set; }

        public string EmailId { get; set; }

        public Country CountryID { get; set; }
        public bool IsActive { get; set; }
        public string Gender { get; set; }


        public List<SelectListItem> UserList { get; set; }

    }

   
}

public enum Country
{
    India = 1,
    USA = 2,
    Canada = 3

}