using AirplaneTickets.Data;

public class CustomerService
{
	public List<Customer> GetAll()
	{
		using (var context = new AppDbContext())
		{
			return context.Customers.ToList();
		}
	}

	public void Add(Customer customer)
	{
		using (var context = new AppDbContext())
		{
			context.Customers.Add(customer);
			context.SaveChanges();
		}
	}

	public void Delete(int customerId)
	{
		using (var context = new AppDbContext())
		{
			var customer = context.Customers.Find(customerId);
			if (customer != null)
			{
				context.Customers.Remove(customer);
				context.SaveChanges();
			}
		}
	}


}