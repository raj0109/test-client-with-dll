using System;
using System.Threading.Tasks;
using EMRx;

namespace Test
{
    public class Test
    {
        static void Main()
        {
            RunAsync().GetAwaiter().GetResult();
        }

        static async Task RunAsync()
        {
            Notification.setBaseURL("http://localhost:8989/");
            await Notification.NewInvoiceGenerated("200A");
        }
    }
}