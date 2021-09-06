using IG.Core.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dtos
{
  public  class UpdatePerson
    {
        public int Id { get; set; }
        public string FirstNameENG { get; set; }
        public string LastNameENG { get; set; }
        public string FirstNameGEO { get; set; }
        public string LastNameGEO { get; set; }
        public string City { get; set; }
        public Sex Sex { get; set; }
        public DateTime BirthDate { get; set; }

        public long PersonalNumber { get; set; }

        public string PhoneNumber { get; set; }
    }
}
