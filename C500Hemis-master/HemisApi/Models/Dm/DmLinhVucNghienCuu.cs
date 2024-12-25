using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmLinhVucNghienCuu
{
    public int IdLinhVucNghienCuu { get; set; }

    public string? LinhVucNghienCuu { get; set; }

    public  ICollection<TbChuyenGiaoCongNgheVaDaoTao> TbChuyenGiaoCongNgheVaDaoTaos { get; set; } = new List<TbChuyenGiaoCongNgheVaDaoTao>();

    public  ICollection<TbLinhVucNghienCuuCuaCanBo> TbLinhVucNghienCuuCuaCanBos { get; set; } = new List<TbLinhVucNghienCuuCuaCanBo>();

    public  ICollection<TbNhiemVuKhcn> TbNhiemVuKhcns { get; set; } = new List<TbNhiemVuKhcn>();

    public  ICollection<TbPhongThiNghiem> TbPhongThiNghiems { get; set; } = new List<TbPhongThiNghiem>();

    public  ICollection<TbPhongThucHanh> TbPhongThucHanhs { get; set; } = new List<TbPhongThucHanh>();

    public  ICollection<TbTapChiKhoaHoc> TbTapChiKhoaHocs { get; set; } = new List<TbTapChiKhoaHoc>();
}
