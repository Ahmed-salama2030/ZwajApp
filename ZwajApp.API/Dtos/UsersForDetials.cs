using System;
using System.Collections.Generic;
using ZwajApp.API.Models;

namespace ZwajApp.API.Dtos
{
    public class UsersForDetials
    {
        public int Id { get; set; }
        public string UserName { get; set; }
         
        public string  Gender { get; set; }
        public int  Age { get; set; }
        public string  KnownAs { get; set; }
        public DateTime  Created { get; set; }
        public DateTime  LastActive { get; set; }
        public string  Introduction { get; set; }
        public string  LookingFor { get; set; }
        public string  Interests { get; set; }
        public string  city { get; set; }
        public string  country { get; set; }

        public string  photoURL { get; set; }
      public ICollection<PhotoForDetailsDTO>  Photos { get; set; }


    }
}