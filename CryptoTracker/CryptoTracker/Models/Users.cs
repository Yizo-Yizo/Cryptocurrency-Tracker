using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace CryptoTracker.Models
{
    public class Users
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }

        [MaxLength(10)]
        public string ContactNumber { get; set; }
        public string Password { get; set; }
    }
}
