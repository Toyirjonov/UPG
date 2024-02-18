﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Categories.Catalogs;

public class Housing_Category
{
    public int ID { get; set; }
    public List<Housing> Accessories { get; set; } = new List<Housing>();
}
