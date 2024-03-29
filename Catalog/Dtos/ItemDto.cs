﻿using System;

namespace Catalog.Dtos

{
	public record ItemDto
	{
		public Guid id { get; init; }

		public string Name { get; init; }

		public decimal Price { get; init; }

		public DateTimeOffset CreatedDate { get; set; }

	}
}

