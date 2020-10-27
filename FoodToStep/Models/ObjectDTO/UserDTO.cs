using FoodToStep.Models.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodToStep.Models.ObjectDTO
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public SubType Sub { get; set; }
        public DateTime DateReg { get; set; }
    }
}
