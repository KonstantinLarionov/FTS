using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodToStep.Models.ObjectDTO
{
    public class MoleculesDTO
    {
        public int Id { get; set; }
        //Белки
        public double Proteins { get; set; }
        //Жиры
        public double Fats { get; set; }
        //Углеводы
        public double Carbohydrates { get; set; }
    }
}
