﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Common.Request
{
	public class NewsRequestParameters : RequestParameters
	{
        public int? CategoryId { get; set; }
        public int? BrandId { get; set; }
    }
}