using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
//using MusicStore.Models;

//using Microsoft.EntityFrameworkCore;

using System.Collections.Generic;

namespace MySample.Controllers
{
    [Route("api/[controller]")]
    public class ValueController: Controller
    {
        public ValueController()
        {

        }


    [HttpGet()]      
    public List<string> GetValue()
    {
            List<string> valuelist = new  List<string>();
            valuelist.Add("value 1");
            valuelist.Add("value 2");

            return valuelist;

        }
    }
}