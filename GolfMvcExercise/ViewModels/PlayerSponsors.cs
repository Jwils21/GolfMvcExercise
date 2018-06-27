using GolfMvcExercise.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GolfMvcExercise.ViewModels {
	public class PlayerSponsors {
		public Player Player { get; set; }
		public IEnumerable<Sponsor> Sponsors { get; set; }
	}
}