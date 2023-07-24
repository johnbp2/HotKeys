using System;
using System.Collections.Generic;
using System.Linq;

namespace JohnBPearson.Windows.Forms.Recruiting
{
    public class Planets
    {
        private PlanetsListItems type;
        public PlanetsListItems Type
        {
            get
            {
                return this.type;
            }  
        }

        private string text = "";
        public string Text
        {
            get
            {
                return this.text;
            }
        } 

        public Planets(PlanetsListItems type)
        {
            this.type = type;
            this.text = this.findText(this.type);
        }

        private static List<Planets> planetsLists = new List<Planets>();
        public static IEnumerable<Planets> PlanetsLists
        {
            get
            {
                if (Planets.planetsLists.FirstOrDefault<Planets>() == null)
                {
                    Planets.planetsLists = buildPlanetsList() ;
                  
                }
                    
                        
                        return Planets.planetsLists;
            }
            private set { }
        }

        public static List<Planets> buildPlanetsList()
        {
            var result = new List<Planets>();
            foreach (var planetsItemType in Enum.GetValues(typeof(PlanetsListItems)))
            {
                var planetsType = (PlanetsListItems)Enum.Parse(typeof(PlanetsListItems), planetsItemType.ToString(), true);
                var planets = new Planets(planetsType);
                result.Add(planets);
                // Debug.Print(planetsItemType.ToString());
            }
            return result;
        }

        private string findText(PlanetsListItems type)
        {
           

            switch (type)
            {
                case PlanetsListItems.A:
                    return "Tython/Ord Mantell/Coruscant/Fleet";
                
                case PlanetsListItems.B:
                    return "Korriban/Dromund Kaas/Hutta";
                case PlanetsListItems.C:
                    return "Corellia/Alderaan/Balmorra/Taris";
                case PlanetsListItems.D:
                    return "Yavin 4/Onderon/Manaan";
                case PlanetsListItems.E:
                    return "Voss/Ossus/Quesh";
                case PlanetsListItems.F:
                    return "Nar Shaddaa/Makeb/Rishi";
                case PlanetsListItems.G:
                    return "Tatooine/Belsavis/Hoth";
                case PlanetsListItems.H:
                    return "Ruhnuk/Odessen/Ilum/CZ-198";
                case PlanetsListItems.I:
                    return "Ziost, Oricon, Dantooine";
                default:
                    return "";
                   
            }
        }
    }
}
