using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sounds_Packing.Classes
{
    class Sound_File
    {
        string Name;
        int Duration;

        // Sound_File Class Constractor
        public Sound_File(string Sound_Name, int Sound_Duration)
        {
            Name = Sound_Name;
            Duration = Sound_Duration;
        }

        // Set Sound Duration
        public void Set_Duration(int Sound_Duration) => Duration = Sound_Duration;
  

        // Add Duration
        //
        public void Add_Duration(int Sound_Duration) => Duration = Duration + Sound_Duration;
        

        // Get Sound Name
        //
        public string Get_Name()
        {
            return Name;
        }

        // Get Soun Duration
        //
        public int Get_Duration()
        {
            return Duration;
        }
    }
}
