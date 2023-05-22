using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Domain
{
	public class Sinistre
	{
		public int SinistreId { get; set; }
		public DateTime DateDeclaration { get; set; }
		public string Lieu { get; set; }
		public string Description { get; set; }
		public virtual Assurance Assurance { get; set; }
		[ForeignKey("Assurance")]
		public int AssuranceFK { get; set; }
	}
}