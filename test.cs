﻿using System;

class TestClass
{
	static void Main(string[] args)
	{
		Scraper scrap = new Scraper("https://www.sainsburys.co.uk/gol-ui/SearchDisplayView?filters[keyword]=Cherry%Bakewell");

		//scrap.ShowTitle();
		scrap.Sainsexample();
		Console.WriteLine("Hello World");
	}
}
