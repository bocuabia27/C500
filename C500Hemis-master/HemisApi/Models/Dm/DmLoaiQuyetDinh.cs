using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmLoaiQuyetDinh
{
    public int IdLoaiQuyetDinh { get; set; }

    public string? LoaiQuyetDinh { get; set; }

    public  ICollection<TbChucDanhKhoaHocCuaCanBo> TbChucDanhKhoaHocCuaCanBos { get; set; } = new List<TbChucDanhKhoaHocCuaCanBo>();

    public  ICollection<TbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai> TbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoais { get; set; } = new List<TbQuyetDinhCapPhepChuongTrinhDungChoChuongTrinhNuocNgoai>();
}
