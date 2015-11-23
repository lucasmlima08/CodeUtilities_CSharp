using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CodeUtilities
{
    class InvokeThread
    {
        public void thread()
        {
            Thread threadExecution = new Thread(method);
            threadExecution.Start();
        }

        public void method()
        {
            System.Windows.Application.Current.Dispatcher.Invoke((Action)(() =>
            {
                // code changes the interface.
                //Size size = new Size(canvas.Width, canvas.Height);
                //canvas.Measure(size);
                //canvas.Arrange(new Rect(size));
            }));
        }
    }
}
