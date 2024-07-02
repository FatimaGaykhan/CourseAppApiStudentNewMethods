using System;
using Domain.Entities;

namespace Repository.Repositories.Interfaces
{
	public interface IGroupRepository:IBaseRepository<Group>
    {
		Task<List<Group>> SearchByName(string searchName);

		Task<List<Group>> SortBy(string text,bool isDescending=false);
	}
}

