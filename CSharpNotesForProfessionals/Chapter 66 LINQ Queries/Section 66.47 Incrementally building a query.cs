using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_66_LINQ_Queries
{
    internal class Section_66_47
    {
        public VehicleModel _entities;
        public Section_66_47()
        {
            _entities = new VehicleModel();
        }

        IEnumerable<VehicleModel> BuildQuery(int vehicleType, SearchModel search, int start = 1, int count = -1)
        {
            IEnumerable<VehicleModel> query = _entities.Vehicles
            .Where(x => x.Active && x.Type == vehicleType)
            .Select(x => new VehicleModel
            {
                Id = _entities.Id,
                Year = _entities.Year,
                Class = _entities.Class,
                Make = _entities.Make,
                Model = _entities.Model
            });

            if (!search.Years.Contains("all"))
                query = query.Where(v => search.Years.Contains(v.Year));
            if (!search.Makes.Contains("all"))
            {
                query = query.Where(v => search.Makes.Contains(v.Make));
            }
            if (!search.Models.Contains("all"))
            {
                query = query.Where(v => search.Models.Contains(v.Model));
            }
            if (!search.Cylinders.Equals("all"))
            {
                decimal minCylinders = 0;
                decimal maxCylinders = 0;
                switch (search.Cylinders)
                {
                    case "2-4":
                        maxCylinders = 4;
                        break;
                    case "5-6":
                        minCylinders = 5;
                        maxCylinders = 6;
                        break;
                    case "8":
                        minCylinders = 8;
                        maxCylinders = 8;
                        break;
                    case "10+":
                        minCylinders = 10;
                        break;
                }
                if (minCylinders > 0)
                {
                    query = query.Where(v => v.Cylinders >= minCylinders);
                }
                if (maxCylinders > 0)
                {
                    query = query.Where(v => v.Cylinders <= maxCylinders);
                }
            }
            switch (search.SortingColumn.ToLower())
            {
                case "make_model":
                    query = query.OrderBy(v => v.Make).ThenBy(v => v.Model);
                    break;
                case "year":
                    query = query.OrderBy(v => v.Year);
                    break;
                case "engine_size":
                    query = query.OrderBy(v => v.EngineSize).ThenBy(v => v.Cylinders);
                    break;
                default:
                    query = query.OrderBy(v => v.Year); //The default sorting.
                    break;
            }
            query = query.Skip(start - 1);

            if (count > -1)
            {
                query = query.Take(count);
            }
            return query;
        }

        public class VehicleModel
        {
            public int Id { get; set; }
            public string Year { get; set; }
            public string Class { get; set; }
            public string Make { get; set; }
            public string Model { get; set; }
            public int Cylinders { get; set; }
            public List<Vehicles> Vehicles { get; set; }
            public int EngineSize { get; set; }
        }
        public class SearchModel
        {
            public string Years { get; set; }
            public string Makes { get; set; }
            public string Models { get; set; }
            public string? Cylinders { get; set; }
            public string SortingColumn { get; set; }
        }

        public class Vehicles
        {
            public int Type { get; set; }
            public bool Active { get; set; }
        }

    }
}
