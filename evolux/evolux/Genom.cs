﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static kursach.Preferences;

namespace kursach
{
    class Genom
    {
        //behavior
        public Genom(Random rnd)
        {
            botGenom = new int[Preferences.GENOM_LENGTH_prop];

            for (int i = 0; i < Preferences.GENOM_LENGTH_prop; ++i)
            {
                botGenom[i] = rnd.Next() % Preferences.MAX_COMMAND_NUMBER_prop;
            }
        }

        // copy ctor
        public Genom(Genom genomToCopy)
        {
            botGenom = new int[Preferences.GENOM_LENGTH_prop];
            for (int i = 0; i < Preferences.GENOM_LENGTH_prop; ++i)
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

            while (counter / (double)Preferences.GENOM_LENGTH_prop < (double)procents)
            {
                int index = rnd.Next() % Preferences.GENOM_LENGTH_prop;
                int command = rnd.Next() % Preferences.MAX_COMMAND_NUMBER_prop;
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
