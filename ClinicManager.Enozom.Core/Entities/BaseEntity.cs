﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace ClinicManager.Enozom.Core.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }
    }
}
