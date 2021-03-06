﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace MVCSample.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Name should not be empty")]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
       
        [Min18Years]
        public DateTime? BirthDate { get; set; }
    }
}