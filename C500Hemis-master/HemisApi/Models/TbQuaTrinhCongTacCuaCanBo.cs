using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbQuaTrinhCongTacCuaCanBo
{
    public int IdQuaTrinhCongTacCuaCanBo { get; set; }

    public int? IdCanBo { get; set; }

    public DateOnly? TuThangNam { get; set; }

    public DateOnly? DenThangNam { get; set; }

    public int? IdChucVu { get; set; }

    public int? IdChucDanhGiangVien { get; set; }

    public string? DonViCongTac { get; set; }

    public  TbCanBo? IdCanBoNavigation { get; set; }

    public  DmChucDanhGiangVien? IdChucDanhGiangVienNavigation { get; set; }

    public  DmChucVu? IdChucVuNavigation { get; set; }
}
