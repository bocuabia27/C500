﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HemisApi.Models;

namespace HemisApi.Controllers.NH
{
    [Route("api/nh/[controller]")]
    [ApiController]
    public class vThongTinViecLamSauTotNghiepController : ControllerBase
    {
        private readonly DbHemisC500Context _context;

        public vThongTinViecLamSauTotNghiepController(DbHemisC500Context context)
        {
            _context = context;
        }

        // GET: api/VThongTinViecLamSauTotNghiep
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VThongTinViecLamSauTotNghiep>>> GetVThongTinViecLamSauTotNghieps()
        {
            return await _context.VThongTinViecLamSauTotNghieps.ToListAsync();
        }

        // GET: api/VThongTinViecLamSauTotNghiep/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VThongTinViecLamSauTotNghiep>> GetVThongTinViecLamSauTotNghiep(int id)
        {
            var VThongTinViecLamSauTotNghiep = await _context.VThongTinViecLamSauTotNghieps.FindAsync(id);

            if (VThongTinViecLamSauTotNghiep == null)
            {
                return NotFound();
            }

            return VThongTinViecLamSauTotNghiep;
        }

   
    }
}
