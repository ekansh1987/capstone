using capstone.Model;
using Microsoft.EntityFrameworkCore;

namespace capstone.Repository
{
    public class CustomerRepository : IDataRepository<Customer>
    {
        private CapstoneDBContext _dbContext;
        public CustomerRepository(CapstoneDBContext capstoneDBContext)
        {
            _dbContext = capstoneDBContext;
        }
        public void Add(Customer entity)
        {
            _dbContext.Customers.Add(entity);
            _dbContext.SaveChanges();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public async Task<Customer> Get(int id)
        {
            return await _dbContext.Customers
                 .FirstOrDefaultAsync(e => e.Id == id);
        }

        public async Task<IEnumerable<Customer>> GetAll()
        {
            return await _dbContext.Customers.ToListAsync();
        }

        public async Task<IEnumerable<offers>> GetAlloffers(long servicenumber,long simnumber)
        {
            return await _dbContext.offers.Where(x=>x.SimNumber==simnumber && x.ServiceNumber==servicenumber).ToListAsync();
        }

        public async Task<string> Update(Customer dbEntity, Customer entity)
        {
            string result = string.Empty;
            dbEntity.Address=entity.Address;
            dbEntity.City=entity.City;
            dbEntity.State=entity.State;
            dbEntity.PinCode=entity.PinCode;
            await Task.Run(() =>
            {
                _dbContext.Customers.Update(dbEntity);
                _dbContext.SaveChanges();
            });
            result = "Address Update Successfully.";
            return result;
        }

        public async Task<string> Validate(Customer entity)
        {
            string result = string.Empty;
            if(entity.ServiceNumber != null  && entity.SimNumber != null && entity.SimNumber!=0 && entity.ServiceNumber!=0)
            {
                var result_temp = await _dbContext.Customers.FirstOrDefaultAsync(x => x.SimNumber == entity.SimNumber && x.ServiceNumber == entity.ServiceNumber);
                if (result_temp == null)
                {
                    result= "Sim and service number combination not found.";
                }
                else
                {
                    result= "Sim validated successfully.";
                }
            }

            
            if (entity.Email != null && entity.DOB != null)
            {
                var result_temp = await _dbContext.Customers.FirstOrDefaultAsync(x => x.Email == entity.Email && x.DOB == entity.DOB);
                if (result_temp == null)
                {
                    result = "Invalid Customer! This Customer does not exists.";
                }
                else
                {
                    result = "Customer Details validated successfully.";
                }
            }

            if (entity.FirstName != null && entity.LastName != null && entity.Email !=null)
            {
                var result_temp = await _dbContext.Customers.FirstOrDefaultAsync(x => x.FirstName==entity.FirstName && x.LastName==entity.LastName && x.Email == entity.Email);
                if (result_temp == null)
                {
                    result = "Invalid Customer! This Customer does not exists.";
                }
                else
                {
                    result = "Customer Details validated successfully.";
                }
            }

            if (entity.FirstName != null && entity.LastName != null && entity.AdharNumber!=null)
            {
                var result_temp = await _dbContext.Customers.FirstOrDefaultAsync(x => x.FirstName == entity.FirstName && x.LastName == entity.LastName && x.AdharNumber==entity.AdharNumber);
                if (result_temp == null)
                {
                    result = "Customer Not Found.";
                }
                else
                {

                    result = "SIM activated Successfully";
                }
            }

            return result;
            
        }
    }
}
