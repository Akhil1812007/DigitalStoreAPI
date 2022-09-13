using DigitalStoreAPI.Model;
using DigitalStoreAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DigitalStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MerchantController : ControllerBase
    {
        private readonly IMerchantRepository _repository;


        //checking for correct azure repos
        public MerchantController(IMerchantRepository repository)
        {
            _repository = repository;

        }

        [HttpGet]
        public async Task<ActionResult<List<Merchant>>> GetMerchants()
        {
            return await _repository.GetMerchant();
        }

        


        [HttpGet("{id}")]
        public async Task<ActionResult<Merchant>> GetMerchant(int id)
        {
            try
            {
                return await _repository.GetMerchantByID(id);
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Merchant>> PutMerchant(int id, Merchant merchant)
        {
            return await _repository.UpdateMerchant(id, merchant);

        }

        [HttpPost]
        public async Task<ActionResult<Merchant>> PostMerchant(Merchant merchant)
        {
            return await _repository.InsertMerchant(merchant);


        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMerchant(int id)
        {
            await _repository?.DeleteMerchant(id);

            return NoContent();
        }
        
        
    }
}
