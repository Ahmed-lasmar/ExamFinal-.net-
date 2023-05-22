using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
	public class Expertise
	{
		[DataType(DataType.Date,ErrorMessage ="date non valid")]
		public DateTime DateExpertise { get; set; }
		[DataType(DataType.MultilineText)]
		[Range(3, 100)]
		public string AvisTechnique { get; set; }
		public double MontantEstime { get; set; }
		public double Duree { get; set; }
	}
}
