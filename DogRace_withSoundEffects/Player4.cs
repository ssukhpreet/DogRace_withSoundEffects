using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace_withSoundEffects
{
   public class Player4
    {
        Random instance_object = new Random();
        public int jump()
        {
            return instance_object.Next(1, instance_object.Next(1, 10));
        }
        public int gameover(int a, Timer tm)
        {
            if (a > 710)
            {
              //  MessageBox.Show("dog 4 is the winner");
                tm.Stop();
                return 4;
            }
            else
            {
                return 0;
            }



        }
    }
}
