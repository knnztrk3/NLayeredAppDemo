﻿using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Abstract
{
	public interface IProductService
	{
		List<Product> GetAll();
		List<Product> GetProductsByCategory(int categoryId);
		List<Product> GetProductsByProductsName(string searchText);
		void Add(Product product);
		void Update(Product product);
		void Delete(Product product);
	}
}
