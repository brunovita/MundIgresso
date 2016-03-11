using System;

namespace MundIgresso.Domain
{
    public class User
    {
        public int UserID { get; set; } 
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DateOfBirth { get; set; }
        public char Gender { get; set; }
        public Address Address { get; set; }

    }
}
