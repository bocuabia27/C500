﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HemisApi.Models;

namespace HemisApi.Controllers.HTQT
{
    [Route("api/htqt/[controller]")]
    [ApiController]
    public class vThanhPhanThamGiaDoanCongTacController : ControllerBase
    {
        private readonly DbHemisC500Context _context;

        public vThanhPhanThamGiaDoanCongTacController(DbHemisC500Context context)
        {
            _context = context;
        }

        // GET: api/VThanhPhanThamGiaDoanCongTac
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VThanhPhanThamGiaDoanCongTac>>> GetVThanhPhanThamGiaDoanCongTacs()
        {
            return await _context.VThanhPhanThamGiaDoanCongTacs.ToListAsync();
        }

        // GET: api/VThanhPhanThamGiaDoanCongTac/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VThanhPhanThamGiaDoanCongTac>> GetVThanhPhanThamGiaDoanCongTac(int id)
        {
            var VThanhPhanThamGiaDoanCongTac = await _context.VThanhPhanThamGiaDoanCongTacs.FindAsync(id);

            if (VThanhPhanThamGiaDoanCongTac == null)
            {
                return NotFound();
            }

            return VThanhPhanThamGiaDoanCongTac;
        }

 
    }
}
