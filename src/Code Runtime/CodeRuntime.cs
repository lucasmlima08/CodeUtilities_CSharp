using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeUtilities
{
    class CodeRuntime
    {
        public long timeMiliseconds()
        {
            var watch = System.Diagnostics.Stopwatch.StartNew();

            // code execution..
            for(int i=0; i<999999999; i++);
            // code execution..
            
            long elapsedMs = watch.ElapsedMilliseconds;
            watch.Stop();
            
            return elapsedMs;
        }
    }
}
