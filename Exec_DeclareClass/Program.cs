﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Exec_DeclareClass
{
	internal class Program
	{
		static void Main(string[] args)
		{
		}
	}

	class Address
	{
		public string City { get; set; }
		public string ZipCode { get; set; }
		public string Street { get; set; }
	}

	class Telephone
	{
		public string CountryCode { get; set; }
		public string AreaCode { get; set; }
		public string Number { get; set; }
		public string Ext { get; set; }
	}

	class Member
	{
		public string Name { get; set; }
		public string Account { get; set; }
		public string Password { get; set; }
		public string Email { get; set; }
		public Address Addr { get; set; }
		public string CellPhone { get; set; }

		public Telephone Tel { get; set; }

		public void Register (string Name, string Account, string Password, string ConfirmPassword, string Email) 
		{

		}

		public void ForgetPassword (string Name, string Email)
		{

		}

		public void Authenticate(string Account, string Password)
		{

		}
}
}
