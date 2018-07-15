using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }
    }
}