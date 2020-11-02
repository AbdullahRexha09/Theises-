using Microsoft.AspNetCore.Mvc;
using MyWebAPi.Services;
using Microsoft.Extensions.Logging;
using MyWebAPi.dtomodels;
using MyWebAPi.models;

namespace MyWebAPi.Controllers
{
    [ApiController]
    public class VisualMediaController : ControllerBase
    {
        #region 
        private readonly IVisualMediaService visualMediaService;
        //private readonly ILogger logger;
        #endregion

        public VisualMediaController(IVisualMediaService visualMediaService/*, ILogger logger*/){
            this.visualMediaService = visualMediaService;
            //this.logger = logger;
        }
        [HttpPost("postvisualmedia")]
        public ActionResult PostVisualMedia([FromBody]NewVisualMediaRequest newRequest){
            var visualMedia = new VisualMedia{
                // Id = newRequest.Id,
                Category = newRequest.Category,
                Caption = newRequest.Caption
            };
            visualMediaService.Post(visualMedia);
            return Ok($"Book Created :{visualMedia.Caption}");
        }
        [HttpGet("test")]
        public ActionResult Test() 
        {
            var x = "asd";
            return Ok(x);
        }

    }
}