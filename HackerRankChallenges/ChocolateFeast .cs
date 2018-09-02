using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRankChallenges
{
    public class ChocolateFeast
    {
         

        public static int ChocolatesConsumed(int totalMoney, int chocolateCost, int wrappers)
        {
            int chocoaltesBought = totalMoney / chocolateCost;

            int remainingWrappers = chocoaltesBought;

            while (remainingWrappers >= wrappers)
            {
                int chocaltesBoughtWithRemainingWrappers = (remainingWrappers / wrappers);                

                remainingWrappers = (remainingWrappers % wrappers) + chocaltesBoughtWithRemainingWrappers;

                chocoaltesBought = chocoaltesBought + chocaltesBoughtWithRemainingWrappers ;
            }

            return chocoaltesBought;


        }
    }
}
