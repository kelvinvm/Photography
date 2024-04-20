﻿using System;
using System.Linq;

namespace Kbvm.Photograph.Shared.Models
{
	public class Location
	{
		public Guid File { get; set; } = Guid.Empty;
		public Guid Thumbnail { get; set; } = Guid.Empty;
	}
}
