using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using jualapi.Models;

namespace jualapi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class QuestionsController : ControllerBase
  {
    [HttpGet]
    //https://localhost:5001/api/Questions
    //In order by times seen
    public IEnumerable<Questions> Get()
    {
      var db = new jualoverflowContext();
      return db.Questions.OrderBy(o => o.AvgQueVotes);
    }
  }
}