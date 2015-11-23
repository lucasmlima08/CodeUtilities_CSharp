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

            watch.Stop();
            long elapsedMs = watch.ElapsedMilliseconds;
            return elapsedMs;
        }
    }
}
