using System;
using System.IO;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace Azure_Function_Name
{
    public class BlobTrigger
    {
        [FunctionName("BlobTrigger")]
        public void Run([BlobTrigger("samples-workitems/{name}", Connection = "ConStr")]Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
        }
    }
}
