﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using C500Hemis.Models.DM;
using Microsoft.AspNetCore.Authorization;


namespace C500Hemis.Models;

[Authorize]
public partial class TbChucDanhKhoaHocCuaCanBo
{
    [Display(Name = "ID CHỨC DANH KHOA HỌC CỦA CÁN BỘ")]
    [Required(ErrorMessage = "ID CHỨC DANH KHOA HỌC CỦA CÁN BỘ là bắt buộc.")]
    public int IdChucDanhKhoaHocCuaCanBo { get; set; }

    [Display(Name = "ID CÁN BỘ")]
    [Required(ErrorMessage = "ID Cán bộ là bắt buộc.")]
    public int? IdCanBo { get; set; }

    [Display(Name = "ID CHỨC DANH KHOA HỌC")]
    public int? IdChucDanhKhoaHoc { get; set; }

    [Display(Name = "ID THẨM QUYỀN QUYẾT ĐỊNH")]
    public int? IdThamQuyenQuyetDinh { get; set; }

    [Display(Name = "SỐ QUYẾT ĐỊNH")]
    public string? SoQuyetDinh { get; set; }

    [Display(Name = "NGÀY QUYẾT ĐỊNH")]
    [DataType(DataType.Date)]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime NgayQuyetDinh { get; set; }

    [Display(Name = "CÁN BỘ")]
    public  TbCanBo? IdCanBoNavigation { get; set; }

    [Display(Name = "CHỨC DANH KHOA HỌC")]
    public  DmChucDanhKhoaHoc? IdChucDanhKhoaHocNavigation { get; set; }

    [Display(Name = "THẨM QUYỀN QUYẾT ĐỊNH")]
    public  DmLoaiQuyetDinh? IdThamQuyenQuyetDinhNavigation { get; set; }
}