using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static kursach.consts;

namespace kursach
{
    class Genom
    {
        //behavior
        public Genom(Random rnd)
        {
            botGenom = new int[GENOM_LENGTH];

            for (int i = 0; i < GENOM_LENGTH; ++i)
            {
                botGenom[i] = rnd.Next() % MAX_COMMAND_NUMBER;
            }
        }

        public void Reset()
        {

        }

        public void Mutate()
        {

        }

        public int getCommand(int state)
        {
            return botGenom[state];
        }

        //state
        private int[] botGenom;
    }
}
