﻿using System;

using Catalog.Dtos;

using Catalog.Entities;

namespace Catalog
{
	public static class Extensions
	{
		public static ItemDto AsDTO(this Item item)
		{
			return new ItemDto
			{
				id = item.Id,
				Name = item.Name,
				Price = item.Price,
				CreatedDate = item.CreatedDate,
			};
		}
	}
}

