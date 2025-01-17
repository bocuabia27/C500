﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using C500Hemis.Models.DM;
using Microsoft.AspNetCore.Authorization;

namespace C500Hemis.Models;

[Authorize]
public partial class TbCoCauToChuc
{
    [Display(Name = "ID CCTC")]
    [Required(ErrorMessage = "Không được để trống trường ID CCTC")]
    public int IdCoCauToChuc { get; set; }
    
    [Display(Name = "MÃ PHÒNG BAN ĐƠN VỊ")]
 
    public string? MaPhongBanDonVi { get; set; }

    [Display(Name = "ID LOẠI PHÒNG BAN")]
  
    public int? IdLoaiPhongBan { get; set; }

    [Display(Name = "MÃ PHÒNG BAN ĐƠN VỊ CHA")]
   
    public string? MaPhongBanDonViCha { get; set; }

    [Display(Name = "TÊN PHÒNG BAN ĐƠN VỊ")]

    public string? TenPhongBanDonVi { get; set; }

    [Display(Name = "SỐ QUYẾT ĐỊNH THÀNH LẬP")]

    public string? SoQuyetDinhThanhLap { get; set; }

    [Display(Name = "NGÀY RA QUYẾT ĐỊNH")]
    
    public string? NgayRaQuyetDinh { get; set; }

    [Display(Name = "ID TRẠNG THÁI")]
   
    public int? IdTrangThai { get; set; }

    [Display(Name = "ID LOẠI PHÒNG BAN")]
  
    public  DmLoaiPhongBan? IdLoaiPhongBanNavigation { get; set; }

    [Display(Name = "ID TRẠNG THÁI")]
  
    public  DmTrangThaiCoSoGd? IdTrangThaiNavigation { get; set; }
}