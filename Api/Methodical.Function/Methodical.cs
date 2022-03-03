using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Methodical.Infrastructure.Data;
using System.Linq;
using System.Collections.Generic;
using Methodical.Core.Entities;

namespace Methodical.Function
{
    public static class Methodical
    {
        [FunctionName("Methodical")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get",Route = null)] HttpRequest req,
            ILogger log)
        {
            MethodicalDBContext methodicalDBContext = new MethodicalDBContext();
            var item = methodicalDBContext.PathSamples.ToList();
            var responseMessage = JsonConvert.SerializeObject(item);
            return new OkObjectResult(responseMessage);
        }
        [FunctionName("MethodicalPost")]
        public static async Task<IActionResult> RunPost(
           [HttpTrigger(AuthorizationLevel.Function, "post", Route = null)] HttpRequest req,
           ILogger log)
        {
            var content = await new StreamReader(req.Body).ReadToEndAsync();
            List<PathSample> pathSample = JsonConvert.DeserializeObject<List<PathSample>>(content);
            if (pathSample == null || pathSample.Count == 0)
                return new BadRequestObjectResult("invalid data");
            MethodicalDBContext methodicalDBContext = new MethodicalDBContext();
            methodicalDBContext.PathSamples.AddRange(pathSample);
            methodicalDBContext.SaveChanges();
            return new OkObjectResult(true);
        }
    }
}
