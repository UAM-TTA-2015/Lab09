using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UamTTA.GUI.Contracts;

namespace UamTTA.GUI.Models
{
	public class BudgetService : IBudgetService
	{
	    public Task<ICollection<Budget>> GetBudgetsAsync()
	    {
	        return Task.FromResult<ICollection<Budget>>(null);
	    }
	}
}