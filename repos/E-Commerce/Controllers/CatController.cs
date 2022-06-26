using E_Commerce.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace E_Commerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class CatController : ControllerBase
    {
        ECommerceDB1Context db;
        public CatController(ECommerceDB1Context _db)
        {
            db = _db;
        }


        [HttpGet]
        public IEnumerable<TblCategory> GetCategorys()
        {
            return db.TblCategories;
        }

        [HttpPost]
        public string Post([FromBody] TblCategory tblcategory)
        {
            db.TblCategories.Add(tblcategory);
            db.SaveChanges();
            return "success";
        }

    }
}
