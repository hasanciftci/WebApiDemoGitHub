using System;
using System.Collections.Generic;

namespace WebAPIDemo.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string Username { get; set; } = null!;
        public string Firstname { get; set; } = null!;
        public string Lastname { get; set; } = null!;
        public DateTime BirthDate { get; set; }
    }
}
