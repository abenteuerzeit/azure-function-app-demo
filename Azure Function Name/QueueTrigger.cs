using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Azure_Function_Name
{
    public class QueueTrigger
    {
        /*
                ~~~ CONFIGURATION ~~~
            1. Create a queue in an Azure Storage Account with the name of this function. 
            2. Add a message to the queue
        
            The queue trigger runs when the message is added. 
         */
        [FunctionName("QueueTrigger")]
        public void Run([QueueTrigger("myqueue-items", Connection = "ConStr")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
