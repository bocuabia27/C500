﻿using System;
using System.Collections.Generic;

namespace HemisApi.Models;

public partial class DmLinhVucNhomNganh
{
    public int IdLinhVucNhomNganh { get; set; }

    public int? IdLinhVucDaoTao { get; set; }

    public int? IdNhomNganh { get; set; }

    public  DmLinhVucDaoTao? IdLinhVucDaoTaoNavigation { get; set; }

    public  DmNhomNganh? IdNhomNganhNavigation { get; set; }
}
