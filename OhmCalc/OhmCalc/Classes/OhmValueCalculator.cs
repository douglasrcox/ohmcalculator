using OhmCalc.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace OhmCalc.Classes
{
    public class OhmValueCalculator : IOhmValueCalculator
    {
        private Dictionary<string, int> Ohm
        {
            get
            {
                return new Dictionary<string, int> {
                    {"black", 0},
                    {"brown", 1},
                    {"red", 2},
                    {"orange", 3},
                    {"yellow", 4},
                    {"green", 5},
                    {"blue", 6},
                    {"violet", 7},
                    {"gray", 8},
                    {"white", 9}
                };

            }
        }

        private Dictionary<string, int> Multiplier
        {
            get
            {
                return new Dictionary<string, int> {
                    {"pink", -3},
                    {"silver", -2},
                    {"gold", -1},
                    {"black", 0},
                    {"brown", 1},
                    {"red", 2},
                    {"orange", 3},
                    {"yellow", 4},
                    {"green", 5},
                    {"blue", 6},
                    {"violet", 7},
                    {"gray", 8},
                    {"white", 9}
                };
            }
        }

        private Dictionary<string, double> Tolerance
        {
            get
            {
                return new Dictionary<string, double> {
                    {"pink", 0},
                    {"silver", 0.10},
                    {"gold", 0.05},
                    {"black", 0},
                    {"brown", 0.01},
                    {"red", 0.02},
                    {"orange", 0},
                    {"yellow", 0.05},
                    {"green", 0.005},
                    {"blue", 0.0025},
                    {"violet", 0.001},
                    {"gray", 0.0005},
                    {"white", 0}
                };
            }
        }

        private string CleanBandColorName(string bandColor)
        {
            return bandColor.ToLower().Replace(",", string.Empty).Trim();
        }


        public int CalculateOhmValue(string bandAColor, string bandBColor, string bandCColor, string bandDColor)
        {
            int ohmFirstValue = 0;
            int ohmSecondValue = 0;
            int multiplier = 0;
            double tolerance = 0;

            if(!string.IsNullOrEmpty(bandAColor) && Ohm.ContainsKey(CleanBandColorName(bandAColor)))
            {
                ohmFirstValue = Ohm[CleanBandColorName(bandAColor)];
            }
            
            if (!string.IsNullOrEmpty(bandBColor) && Ohm.ContainsKey(CleanBandColorName(bandBColor)))
            {
                ohmSecondValue = Ohm[CleanBandColorName(bandBColor)];
            }
            
            if (!string.IsNullOrEmpty(bandCColor) && Multiplier.ContainsKey(CleanBandColorName(bandCColor)))
            {
                multiplier = Multiplier[CleanBandColorName(bandCColor)];
            }
            

            if (!string.IsNullOrEmpty(bandDColor) && Tolerance.ContainsKey(CleanBandColorName(bandDColor)))
            {
                tolerance = Tolerance[CleanBandColorName(bandDColor)];
            }
            else
            {
                tolerance = 0.20;
            }
            
            int ohmValue = Convert.ToInt32(string.Format("{0}{1}", ohmFirstValue, ohmSecondValue));

            // Rounds off to an integer value. Upper bound tolerance value returned only.
            return (int)(ohmValue * Math.Pow(10, multiplier) * (1 + tolerance));
        }
    }
}
