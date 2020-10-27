using FoodToStep.Models.Enums;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodToStep.Models.ObjectDTO
{
    public class FoodDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImageName { get; set; }
        public double CCal { get; set; }
        public int Steps { get; set; }
        public FoodType Type { get; set; }
        public MoleculesDTO Molecules { get; set; }
        public DateTime DateAdd { get; set; }
    }
}
