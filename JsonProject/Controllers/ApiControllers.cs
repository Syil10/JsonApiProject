using Microsoft.AspNetCore.Mvc;
using System.IO;
using Newtonsoft.Json;

namespace JsonProject.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ApiControllers : ControllerBase
    {

        private readonly ILogger<ApiControllers> _logger;

        public ApiControllers(ILogger<ApiControllers> logger)
        {
            _logger = logger;
        }
        [HttpPost]   
        public IActionResult Post([FromBody] Models.JsonModel jsonData)
        {
            try
            {

                string jsonDirectoryPath = @"C:\Users\selen.yildirim\Desktop\folder";
                string fileName = $"{DateTime.Now:yyyyMMddHHmmssfff}.json";
                string jsonFilePath = Path.Combine(jsonDirectoryPath, fileName);

                string jsonString = JsonConvert.SerializeObject(jsonData, Formatting.Indented);

                System.IO.File.WriteAllText(jsonFilePath, jsonString);

                return Ok("Data inserted successfully and saved to a file");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return StatusCode(500, "An error occurred while processing the request.");
            }
        }


        [HttpGet]
        [Route("api/get")]
        public IActionResult Get()
        {
            try
            {
                string jsonFolderPath = @"C:\Users\selen.yildirim\Desktop\folder";

                
                DirectoryInfo directoryinfo = new DirectoryInfo(jsonFolderPath);
                FileInfo[] files = directoryinfo.GetFiles("*.json");

               
                FileInfo latestFile = files.OrderByDescending(f => f.CreationTime).FirstOrDefault();
                string jsonData = System.IO.File.ReadAllText(latestFile.FullName);
                return Ok(jsonData);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return StatusCode(500, "There is an error while processing the request.");
            }
        }




    }
}
