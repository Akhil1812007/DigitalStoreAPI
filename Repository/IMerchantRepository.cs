using DigitalStoreAPI.Model;

namespace DigitalStoreAPI.Repository
{
    public interface IMerchantRepository
    {
        public Task<List<Merchant>> GetMerchant();
        public Task<Merchant> GetMerchantByID(int MerchantId);
        public Task<Merchant> InsertMerchant(Merchant Merchant);
        public Task DeleteMerchant(int? MerchantId);
        public Task<Merchant> UpdateMerchant(int MerchantId, Merchant merchant);

    }
}
