using EasyCashIdentityProject.BusinnesLayer.Abstract;
using EasyCashIdentityProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyCashIdentityProject.BusinnesLayer.Concrete
{
	internal class CustomerAccountManager : ICustomerAccountService
	{
		private readonly ICustomerAccountService _customerAccountService;

		public CustomerAccountManager(ICustomerAccountService customerAccountService)
		{
			_customerAccountService = customerAccountService;
		}

		public void TDelete(CustomerAccount t)
		{
			_customerAccountService.TDelete(t);
		}

		public CustomerAccount TGetById(int id)
		{
			return _customerAccountService.TGetById(id);
		}

		public List<CustomerAccount> TGetList()
		{
			return _customerAccountService.TGetList();
		}

		public void TInsert(CustomerAccount t)
		{
			_customerAccountService.TInsert(t);
		}

		public void TUpdate(CustomerAccount t)
		{
			_customerAccountService.TUpdate(t);
		}
	}
}
