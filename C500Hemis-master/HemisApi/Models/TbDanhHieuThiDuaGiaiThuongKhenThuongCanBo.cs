using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class TbDanhHieuThiDuaGiaiThuongKhenThuongCanBo
{
    public int IdDanhHieuThiDuaGiaiThuongKhenThuongCanBo { get; set; }

    public int? IdCanBo { get; set; }

    public int? IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong { get; set; }

    public int? IdThiDuaGiaiThuongKhenThuong { get; set; }

    public int? SoQuyetDinh { get; set; }

    public int? IdPhuongThucKhenThuong { get; set; }

    public DateOnly? NamKhenThuong { get; set; }

    public int? IdCapKhenThuong { get; set; }

    public  TbCanBo? IdCanBoNavigation { get; set; }

    public  DmCapKhenThuong? IdCapKhenThuongNavigation { get; set; }

    public  DmLoaiDanhHieuThiDuaGiaiThuongKhenThuong? IdLoaiDanhHieuThiDuaGiaiThuongKhenThuongNavigation { get; set; }

    public  DmPhuongThucKhenThuong? IdPhuongThucKhenThuongNavigation { get; set; }

    public  DmThiDuaGiaiThuongKhenThuong? IdThiDuaGiaiThuongKhenThuongNavigation { get; set; }
}
