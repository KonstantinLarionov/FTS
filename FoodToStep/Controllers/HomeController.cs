using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using FoodToStep.Controllers.Interface;
using FoodToStep.Models;
using FoodToStep.Models.Enums;
using FoodToStep.Models.ObjectDTO;
using FoodToStep.Models.Extensions;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodToStep.Models.Object;

namespace FoodToStep.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase, AndroidAPI
    {
        HomeContext Context = new HomeContext(new DbContextOptions<HomeContext>());
        public HomeController()
        { }

        [HttpGet(Name = "GetFood")]
        [Route("GetFood")]
        public JsonResult GetFood([FromHeader] FoodTypeGet food)
        {
            FoodType type = food.foodType.GetEnum<FoodType>();

            List<FoodDTO> foodDTO = null;
            foodDTO = Context.Foods.Where(x => x.Type == type).ToList();
            return new JsonResult(foodDTO);
        }
    }
}
