using FoodToStep.Models.Enums;
using FoodToStep.Models.Object;

using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodToStep.Controllers.Interface
{
    public interface AndroidAPI
    {
        JsonResult GetFood(FoodTypeGet type);

    }
}
