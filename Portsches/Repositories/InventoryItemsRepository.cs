using System;
using System.Collections.Generic;
using System.Data;
using Portsches.Models;

namespace Portsches.Repositories
{
	public class InventoryItemsRepository
	{
		private readonly IDbConnection _db;

		public InventoryItemsRepository(IDbConnection db)
		{
			_db = db;
		}

		internal List<InventoryItem> Get()
		{
			throw new NotImplementedException();
		}
		internal InventoryItem Get(int id)
		{
			throw new NotImplementedException();
		}

		internal InventoryItem Create(InventoryItem itemData)
		{
			throw new NotImplementedException();
		}

		internal void Edit(InventoryItem itemData)
		{
			throw new NotImplementedException();
		}

		internal void Delete(int id)
		{
			throw new NotImplementedException();
		}
	}
}