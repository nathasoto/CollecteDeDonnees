﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryDonnesAPI
{
    public interface IRequest
    {
        String doRequest(String URL);
    }
}
