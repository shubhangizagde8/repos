﻿using E_Commerce.Models;
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
    public class ProdcutController : ControllerBase
    {
        ECommerceDB1Context db;
        public ProdcutController(ECommerceDB1Context _db)
        {
            db = _db;
        }
        [HttpGet]
        public IEnumerable<TblProduct> GetProducts()
        {
            return db.TblProducts;
        }
    }
}