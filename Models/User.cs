using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstMVCAppSCAGT.Models
{
    public class User
    {
        /// <summary>
        /// Primary Key
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// input text
        /// </summary>
        public string UserName { get; set; }
    }
}