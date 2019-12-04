using System;
using People;
using Microsoft.CSharp;
using Microsoft.AspNet.Mvc;
/// <summary>
/// Summary description for Class1
/// </summary>
public class PeopleController
{
	public IActionResult Index()
	{
		
		return View();
	}
}
