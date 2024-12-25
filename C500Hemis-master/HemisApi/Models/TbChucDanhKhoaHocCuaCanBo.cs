using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbChucDanhKhoaHocCuaCanBo
{
    public int IdChucDanhKhoaHocCuaCanBo { get; set; }

    public int? IdCanBo { get; set; }

    public int? IdChucDanhKhoaHoc { get; set; }

    public int? IdThamQuyenQuyetDinh { get; set; }

    public string? SoQuyetDinh { get; set; }

    public DateOnly? NgayQuyetDinh { get; set; }

    public  TbCanBo? IdCanBoNavigation { get; set; }

    public  DmChucDanhKhoaHoc? IdChucDanhKhoaHocNavigation { get; set; }

    public  DmLoaiQuyetDinh? IdThamQuyenQuyetDinhNavigation { get; set; }
}
