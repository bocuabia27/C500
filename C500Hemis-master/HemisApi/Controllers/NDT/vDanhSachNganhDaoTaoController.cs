﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HemisApi.Models;

namespace HemisApi.Controllers.NDT
{
    [Route("api/ndt/[controller]")]
    [ApiController]
    public class vDanhSachNganhDaoTaoController : ControllerBase
    {
        private readonly DbHemisC500Context _context;

        public vDanhSachNganhDaoTaoController(DbHemisC500Context context)
        {
            _context = context;
        }

        // GET: api/VDanhSachNganhDaoTao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VDanhSachNganhDaoTao>>> GetVDanhSachNganhDaoTaos()
        {
            return await _context.VDanhSachNganhDaoTaos.ToListAsync();
        }

        // GET: api/VDanhSachNganhDaoTao/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VDanhSachNganhDaoTao>> GetVDanhSachNganhDaoTao(int id)
        {
            var VDanhSachNganhDaoTao = await _context.VDanhSachNganhDaoTaos.FindAsync(id);

            if (VDanhSachNganhDaoTao == null)
            {
                return NotFound();
            }

            return VDanhSachNganhDaoTao;
        }

    }
}
