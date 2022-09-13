using System.Data;

namespace Portsches.Repositories
{
	public class InventoryItemsRepository
	{
		private readonly IDbConnection _db;

		public InventoryItemsRepository(IDbConnection db)
		{
			_db = db;
		}
	}
}