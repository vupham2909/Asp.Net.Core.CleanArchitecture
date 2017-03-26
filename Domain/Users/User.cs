using Domain.Common.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Users
{
    public class User : IEntity
    {
        public int Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string TimeZoneInfoId { get; set; }
        
    }
}
