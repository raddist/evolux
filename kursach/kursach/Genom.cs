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

        // copy ctor
        public Genom(Genom genomToCopy)
        {
            botGenom = new int[GENOM_LENGTH];
            for (int i = 0; i < GENOM_LENGTH; ++i)
            {
                botGenom[i] = genomToCopy.botGenom[i];
            }
        }


        public void Reset()
        {

        }

        public Genom Mutate(int procents, Random rnd)
        {
            int counter = 1;
            Genom mutateGenom = new Genom(this);

            while (counter/(double)GENOM_LENGTH < (double)procents)
            {
                int index = rnd.Next() % GENOM_LENGTH;
                int command = rnd.Next() % MAX_COMMAND_NUMBER;
                mutateGenom.botGenom[index] = command;
                counter++;
            }

            return mutateGenom;
        }

        public int getCommand(int state)
        {
            return botGenom[state];
        }

        //state
        private int[] botGenom;
    }
}
