using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations;
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
        [DisplayName("User Name 123")]
        [Required(ErrorMessage = "UserName is required!!! ")]
        [StringLength(10, MinimumLength = 4, ErrorMessage = "Maximun character is 10")]
        public string UserName { get; set; }
            
        [DisplayName("Password")]
        [Required(ErrorMessage = "Password is required!!! ")]
        public string Password { get; set; }

        [DisplayName("Confirm password")]
        [Required(ErrorMessage = "ConfirmPassword is required!!! ")]
        [System.ComponentModel.DataAnnotations.Compare("Password", ErrorMessage = "Password and Comfirm password should be same!! ")]
        public string ConfirmPassword { get; set; }

        [DisplayName("Email Address")]
        [Required(ErrorMessage = "Email is required!!! ")]
        [EmailAddress(ErrorMessage = "Email address is not valid!!")]
        public string EmailId { get; set; }

        [DisplayName("Age")]
        [Range(18, 35, ErrorMessage = "Please enter age between 18 to 35")]
        public string Age { get; set; }

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