using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_41_Interfaces_Section_41_2_Explicit_interface_implementation
{

    interface IChauffeur
    {
        string Drive();
    }


    interface IGolfPlayer
    {
        string Drive();
    }


    class GolfingChauffeur : IChauffeur, IGolfPlayer
    {
        public string Drive()
        {
            return "Vroom!";
        }
        string IChauffeur.Drive()
        {
            {
                return "Took a swing ...";
            }
        }
    }


    public class Golfer : IGolfPlayer
    {
         string IGolfPlayer.Drive()
        {
            return "Swinging hard...";
        }

        //public void Swing()
        //{
        //    Drive(); // Compiler error: No such method
        //}
    }
}
