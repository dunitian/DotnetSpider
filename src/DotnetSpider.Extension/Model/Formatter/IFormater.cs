﻿using System;

namespace DotnetSpider.Extension.Model.Formatter
{
	[AttributeUsage(AttributeTargets.Property)]
	public abstract class Formatter : System.Attribute
	{
		public abstract string Name { get; internal set; }

		public abstract string Formate(string value);
	}
}