using System;
using System.Collections.Generic;
using Portsches.Models;
using Portsches.Repositories;

namespace Portsches.Services
{
	public class InventoryItemsService
	{
		private readonly InventoryItemsRepository _repo;

		public InventoryItemsService(InventoryItemsRepository repo)
		{
			_repo = repo;
		}

		internal List<InventoryItem> Get()
		{
			throw new NotImplementedException();
		}

		internal InventoryItem Get(int id)
		{
			throw new NotImplementedException();
		}

		internal InventoryItem Create(InventoryItem itemData, string id)
		{
			throw new NotImplementedException();
		}

		internal InventoryItem Edit(InventoryItem itemData, string id)
		{
			throw new NotImplementedException();
		}

		internal void Delete(int id, string userId)
		{
			throw new NotImplementedException();
		}
	}
}