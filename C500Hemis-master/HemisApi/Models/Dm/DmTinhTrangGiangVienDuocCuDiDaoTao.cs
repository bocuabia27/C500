using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmTinhTrangGiangVienDuocCuDiDaoTao
{
    public int IdTinhTrangGiangVienDuocCuDiDaoTao { get; set; }

    public string? TinhTrangGiangVienDuocCuDiDaoTao { get; set; }

    public  ICollection<TbGvduocCuDiDaoTao> TbGvduocCuDiDaoTaos { get; set; } = new List<TbGvduocCuDiDaoTao>();
}
