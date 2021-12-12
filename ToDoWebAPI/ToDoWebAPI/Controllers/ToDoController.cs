using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDoWebAPI.Data;

namespace ToDoWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        private readonly ApiDBContext _dBContext;

        public ToDoController(ApiDBContext dBContext)
        {
            _dBContext = dBContext;
        }

        [HttpGet]
        [Route("getallitems")]
        public async Task<IActionResult> GetAllItems()
        {
            var Items = await _dBContext.Items.ToListAsync();
            return Ok(Items);
        }

        [HttpPost]
        [Route("saveitem")]
        public async Task<IActionResult> GetAllItems()
        {
            var Items = await _dBContext.Items.ToListAsync();
            return Ok(Items);
        }
    }
}
