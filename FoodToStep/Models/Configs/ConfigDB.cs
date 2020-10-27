using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodToStep.Models.Configs
{
    public static class ConfigDB
    {
        public static string ConnectionSting { get; } = "Server=localhost;Database=foodDb;User=fts;Password=123321;";
    }
}
