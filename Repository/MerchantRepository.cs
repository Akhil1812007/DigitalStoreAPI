using DigitalStoreAPI.Model;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;
using System.Text;

namespace DigitalStoreAPI.Repository
{
    public class MerchantRepository
    {
        private readonly DigitalStoreContext _context;
        private readonly IConfiguration _configuration;
        public MerchantRepository(DigitalStoreContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public async Task DeleteMerchant(int? MerchantId)
        {
            try
            {
                Merchant merchant = _context.Merchants.Find(MerchantId);
                _context.Merchants.Remove(merchant);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new NotImplementedException();
            }
        }

        public async Task<List<Merchant>> GetMerchant()
        {
            try
            {
                return await _context.Merchants.ToListAsync();
            }
            catch
            {
                throw new NotImplementedException();

            }
        }

        public async Task<Merchant> GetMerchantByID(int MerchantId)
        {
            return await _context.Merchants.FindAsync(MerchantId);

        }

       

        public async Task<Merchant> InsertMerchant(Merchant merchant)
        {
            _context.Merchants.Add(merchant);
            await _context.SaveChangesAsync();
            return merchant;


        }
        private bool IsMerchant(int id)
        {
            var isMerchant = _context.Merchants.Find(id);
            if (isMerchant != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public async Task<Merchant> UpdateMerchant(int MerchantId, Merchant Merchant)
        {
            //Merchant _merchant = await _context.Merchants.FindAsync(MerchantId);
            _context.Update(Merchant);
            _context.SaveChanges();
            return Merchant;

        }
        

    }
}
