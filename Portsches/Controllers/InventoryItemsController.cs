using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeWorks.Auth0Provider;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Portsches.Models;
using Portsches.Services;

namespace Portsches.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class InventoryItemsController : ControllerBase
	{
		private readonly InventoryItemsService _iis;
		public InventoryItemsController(InventoryItemsService iis)
		{
			_iis = iis;
		}
		[HttpGet]
		public ActionResult<List<InventoryItem>> Get()
		{
			try
			{
				List<InventoryItem> items = _iis.Get();
				return Ok(items);
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
		[HttpGet("{id}")]
		public ActionResult<InventoryItem> Get(int id)
		{
			try
			{
				InventoryItem item = _iis.Get(id);
				return Ok(item);
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
		[HttpPost]
		[Authorize]
		public async Task<ActionResult<InventoryItem>> Create([FromBody] InventoryItem itemData)
		{
			try
			{
				Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
				InventoryItem newItem = _iis.Create(itemData, userInfo.Id);
				return Ok(newItem);
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
		[HttpPut("{id}")]
		[Authorize]
		public async Task<ActionResult<InventoryItem>> Edit([FromBody] InventoryItem itemData)
		{
			try
			{
				Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
				InventoryItem updatedItem = _iis.Edit(itemData, userInfo.Id);
				return Ok(updatedItem);
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
		[HttpDelete("{id}")]
		[Authorize]
		public async Task<ActionResult<String>> Delete(int id)
		{
			try
			{
				Account userInfo = await HttpContext.GetUserInfoAsync<Account>();
				_iis.Delete(id, userInfo.Id);
				return Ok("Deletion Successful");
			}
			catch (Exception e)
			{
				return BadRequest(e.Message);
			}
		}
	}
}