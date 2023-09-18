﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CFive_Framework.Server.Database.Models
{
	public class User
	{
		[Key] public int Id { get; set; }
		public string FirstName { get; set; }
		public string SurName { get; set; }
	}
}