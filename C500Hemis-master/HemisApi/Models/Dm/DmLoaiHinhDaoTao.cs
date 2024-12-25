using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmLoaiHinhDaoTao
{
    public int IdLoaiHinhDaoTao { get; set; }

    public string? LoaiHinhDaoTao { get; set; }

    public  ICollection<TbChiTieuTuyenSinhTheoNganh> TbChiTieuTuyenSinhTheoNganhs { get; set; } = new List<TbChiTieuTuyenSinhTheoNganh>();

    public  ICollection<TbLoaiHinhDaoTaoKhacDuocChoPhepMoNganh> TbLoaiHinhDaoTaoKhacDuocChoPhepMoNganhs { get; set; } = new List<TbLoaiHinhDaoTaoKhacDuocChoPhepMoNganh>();

    public  ICollection<TbQuaTrinhDaoTaoCuaCanBo> TbQuaTrinhDaoTaoCuaCanBos { get; set; } = new List<TbQuaTrinhDaoTaoCuaCanBo>();

    public  ICollection<TbThongTinHocTapNghienCuuSinh> TbThongTinHocTapNghienCuuSinhs { get; set; } = new List<TbThongTinHocTapNghienCuuSinh>();
}
