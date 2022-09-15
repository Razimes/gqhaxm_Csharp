using System;
using System.Collections.Generic;
using System.Text;

namespace gqhaxm_prog
{
    class szemetgyujto_demo 
    {
        public static int adattag = 1;
        public szemetgyujto_demo()
        {
            adattag++;
            Console.WriteLine(adattag);
        }

        ~szemetgyujto_demo()
        {
            adattag = 0;
        }
        
       

    }
}
