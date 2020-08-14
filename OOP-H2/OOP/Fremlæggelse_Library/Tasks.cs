using System;
using System.Threading.Tasks;

namespace FremlæggelseLibrary
{
    public class Tasks
    {
        public static Task<string> get(string endpoint)
        {
            Task<string> task = new Task<string>(() =>
            {
                //Task.Delay(5000).Wait();
                string resp = EndpointService.get(endpoint);
                return resp;
            });

            task.Start();

            return task;
        }
    }
}