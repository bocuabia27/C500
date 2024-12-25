using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmQuocTich
{
    public int IdQuocTich { get; set; }

    public string? TenNuoc { get; set; }

    public  ICollection<TbChuongTrinhDaoTao> TbChuongTrinhDaoTaos { get; set; } = new List<TbChuongTrinhDaoTao>();

    public  ICollection<TbDoanCongTac> TbDoanCongTacs { get; set; } = new List<TbDoanCongTac>();

    public  ICollection<TbGvduocCuDiDaoTao> TbGvduocCuDiDaoTaos { get; set; } = new List<TbGvduocCuDiDaoTao>();

    public  ICollection<TbNguoi> TbNguois { get; set; } = new List<TbNguoi>();

    public  ICollection<TbQuaTrinhDaoTaoCuaCanBo> TbQuaTrinhDaoTaoCuaCanBos { get; set; } = new List<TbQuaTrinhDaoTaoCuaCanBo>();

    public  ICollection<TbThietBiPtnThtren500Tr> TbThietBiPtnThtren500Trs { get; set; } = new List<TbThietBiPtnThtren500Tr>();

    public  ICollection<TbToChucHopTacQuocTe> TbToChucHopTacQuocTes { get; set; } = new List<TbToChucHopTacQuocTe>();
}
