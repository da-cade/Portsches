using System;
using System.Collections.Generic;
using Portsches.Models;
using Portsches.Repositories;
//TODO implement admin privileges into the methods
//TODO discuss what the primary key is for an inventory item
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
			return _repo.Get();
		}

		internal InventoryItem Get(int id)
		{
			InventoryItem item = _repo.Get(id);
			if (item == null)
			{
				throw new Exception("Item not found");
			}
			return item;
		}

		internal InventoryItem Create(InventoryItem itemData, string id)
		{
			return _repo.Create(itemData);
		}

		internal InventoryItem Edit(InventoryItem itemData, string id)
		{
			InventoryItem original = Get(itemData.Id);
			original.Image = itemData.Image ?? original.Image;
			original.InStock = itemData.InStock;
			original.Name = itemData.Name;
			original.Notes = itemData.Notes ?? original.Notes;
			original.PriceCurrent = itemData.PriceCurrent;
			original.PriceRetail = itemData.PriceRetail;
			original.Quantity = itemData.Quantity;
			original.SKU = itemData.SKU ?? original.SKU;
			original.StoreLocation = itemData.StoreLocation;
			original.Tags = itemData.Tags ?? original.Tags;

			_repo.Edit(itemData);

			return Get(original.Id);
		}

		internal void Delete(int id, string userId)
		{
			Get(id);
			_repo.Delete(id);
		}
	}
}