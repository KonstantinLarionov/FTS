using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace FoodToStep.Models.Enums
{
    public enum SubType
    {
        [EnumMember(Value = "Бизнес подписка")]
        Hard,
        [EnumMember(Value = "Любительская подписка")]
        Medium,
        [EnumMember(Value = "Начальная подписка")]
        Low
    }
}
