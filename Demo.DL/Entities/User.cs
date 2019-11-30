using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.DL.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string EmailId { get; set; }
        public string ContactNumber { get; set; }

        public User(int id, string fullName, string emailId, string contactNumber)
        {
            Id = id;
            FullName = fullName;
            EmailId = emailId;
            ContactNumber = contactNumber;
        }
    }
}
