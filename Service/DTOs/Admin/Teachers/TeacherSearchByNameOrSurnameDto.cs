﻿using System;
namespace Service.DTOs.Admin.Teachers
{
	public class TeacherSearchByNameOrSurnameDto
	{
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Salary { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }
    }
}

