using System.Collections.Generic;
using System.Linq;
using AngularUnit.Models;
using Microsoft.AspNetCore.Mvc;

public class NewsController : Controller
{
	ApplicationDbContext _context;
	public NewsController(ApplicationDbContext context)
	{
		_context = context;
		if (!_context.News.Any())
		{
			_context.News.Add(new News {  Date = "09.10.1999", Header = "Никогда такого не было и вот опять", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." });
			_context.News.Add(new News {  Date = "01.10.1999", Header = "Никогда такого не было и вот опять", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." });
			_context.News.Add(new News {  Date = "02.10.1999", Header = "Никогда такого не было и вот опять", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." });
			_context.News.Add(new News {  Date = "05.10.1999", Header = "Никогда такого не было и вот опять", Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum." });
			_context.SaveChanges();
		}
	}
	[HttpGet]
	[Route("/news")]
	public IEnumerable<News> Index()
	{
		return _context.News.ToList();
	}

}