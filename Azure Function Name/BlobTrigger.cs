using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Azure_Function_Name
{
    public class BlobTrigger
    {
        /*
        ~~~ CONFIGURATION ~~~
            1. Create a new blob container in an Azure Storage Account with the name of this function. 
               While running, the function will go to the specified connection string and listen for "sample-workitems"
            2. Upload a file (might take some time)

        Publish the code to the portal in Visual Studio by right clicking on the Azure Function App name and select Publish
         */
        [FunctionName("BlobTrigger")]
        public void Run([BlobTrigger("samples-workitems/{name}", Connection = "ConStr")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
