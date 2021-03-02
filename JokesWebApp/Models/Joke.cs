using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// added
/// </summary>
namespace JokesWebApp.Models
{
    public class Joke
    {
        //shortcut tap in prop
        public int Id { get; set; }

        // prop  tab twice
        public String JokeQuestion { get; set; }
        public String JokeAnswer  { get; set; }


        //ctor tabtab
        public Joke()
        {
             
        }
           
    }
}
