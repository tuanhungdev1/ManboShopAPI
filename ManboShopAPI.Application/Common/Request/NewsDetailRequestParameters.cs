using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Common.Request
{
	public class NewsDetailRequestParameters : RequestParameters
	{
        public int? NewsId { get; set; }
        public int? ProductId { get; set; }
    }
}
