using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wall_Street.Model
{
	public class CorporateGroup
	{
		public int CorporateID { get; set; }
		public string CorporateName { get; set; }
		public List<Street> Streets { get; set; }
	}
}
