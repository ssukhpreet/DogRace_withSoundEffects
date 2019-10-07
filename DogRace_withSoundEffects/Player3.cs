using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogRace_withSoundEffects
{
  public  class Player3
    {

        Random instance_object = new Random();
        public int jump()
        {
            return instance_object.Next(1, instance_object.Next(1, 12));
        }

        public int gameover(int a, Timer tm)
        {
            if (a > 710)
            {
               // MessageBox.Show("dog 3 is the winner");
                tm.Stop();
                return 3;
            }
            else
            {
                return 0;
            }



        }
    }
}
