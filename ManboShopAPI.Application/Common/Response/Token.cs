using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManboShopAPI.Application.Common.Response
{
	public class Token
	{
        public string AssessToken { get; set; }
		public string RefreshToken { get; set; }
    }
}
