﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFTimestamps.Interfaces
{
    public interface ISoftDeletable
    {
        DateTime? DeletedAt { get; set; }
    }
}
