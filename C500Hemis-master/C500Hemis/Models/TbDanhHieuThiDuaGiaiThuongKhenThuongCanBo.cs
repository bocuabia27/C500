using System;
using System.Collections.Generic;
using C500Hemis.Models.DM;
using System.ComponentModel.DataAnnotations;

namespace C500Hemis.Models;

public partial class TbDanhHieuThiDuaGiaiThuongKhenThuongCanBo
{
    public int IdDanhHieuThiDuaGiaiThuongKhenThuongCanBo { get; set; }
  
    public int? IdCanBo { get; set; }

    public int? IdLoaiDanhHieuThiDuaGiaiThuongKhenThuong { get; set; }
    public int? IdThiDuaGiaiThuongKhenThuong { get; set; }

    public int? SoQuyetDinh { get; set; }

    public int? IdPhuongThucKhenThuong { get; set; }
    [DisplayFormat(DataFormatString = "{0:yyyy}", ApplyFormatInEditMode = true)]

    public DateTime? NamKhenThuong { get; set; }

    public int? IdCapKhenThuong { get; set; }

    public  TbCanBo? IdCanBoNavigation { get; set; }

    public  DmCapKhenThuong? IdCapKhenThuongNavigation { get; set; }

    public  DmLoaiDanhHieuThiDuaGiaiThuongKhenThuong? IdLoaiDanhHieuThiDuaGiaiThuongKhenThuongNavigation { get; set; }
    public  DmPhuongThucKhenThuong? IdPhuongThucKhenThuongNavigation { get; set; }
    public  DmThiDuaGiaiThuongKhenThuong? IdThiDuaGiaiThuongKhenThuongNavigation { get; set; }
}
