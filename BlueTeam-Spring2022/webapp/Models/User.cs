using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace WebApp1.Models
{
    public class User
    {
        public int UserID {get; set;}
        public int Password {get; set;}
    }
}