using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GolfMvcExercise.Models {
	public class Sponsor {
		public int Id { get; set; }
		public string Name { get; set; }
		public double Amount { get; set; }
		public int PlayerId { get; set; }
		public virtual Player Player { get; set; }

	}
}