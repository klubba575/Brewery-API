using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day31___BreweryAPIs.Models
{

	public class BreweryRoot
	{
		public Brew[] Property1 { get; set; }
	}

	public class Brew
	{
		public int id { get; set; }
		public string name { get; set; }
		public string brewery_type { get; set; }
		public string street { get; set; }
		public string city { get; set; }
		public string state { get; set; }
		public string postal_code { get; set; }
		public string country { get; set; }
		public string longitude { get; set; }
		public string latitude { get; set; }
		public string phone { get; set; }
		public string website_url { get; set; }
		public DateTime updated_at { get; set; }
		public object[] tag_list { get; set; }
	}

}
