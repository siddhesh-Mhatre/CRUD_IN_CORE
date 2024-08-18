﻿using System.ComponentModel.DataAnnotations;

namespace CRUD_IN_CORE.Models
{
	public class Car
	{
		[Key]
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
		[Required]
		public string Model { get; set; }
		[Required]
		public string Color { get; set; }
		[Required]
		public int Year { get; set; }
 

	}
}
