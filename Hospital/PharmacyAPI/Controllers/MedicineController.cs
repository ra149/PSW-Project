using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyAPI.DTO;
using PharmacyAPI.Model;
using PharmacyLibrary.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyAPI.Controllers
{
    [Route("api3/[controller]")]
    [ApiController]
    public class MedicineController : ControllerBase
    {

        private readonly IMedicineService medicineService;
        private readonly PharmacyDbContext dbContext;

        public MedicineController(IMedicineService medicineService, PharmacyDbContext context)
        {
            this.medicineService = medicineService;
            this.dbContext = context;
        }

        [HttpGet]       // GET /api3/pharmacy
        public List<Medicine> GetAllPharmacies()
        {
            return medicineService.Get();
        }

        [HttpGet("{id?}")]
        public Medicine Get(int id)
        {
            return medicineService.Get(id);
        }

        [HttpPost]
        public Boolean Add(Medicine newMedicine)
        {
            return medicineService.Add(newMedicine);
        }

        [HttpDelete("{id?}")]
        public Boolean Delete(int id)
        {
            return medicineService.Delete(id);
        }


        [HttpPut]
        public Boolean Update(Medicine m)
        {
            return medicineService.Update(m);
        }
         
        [HttpGet("{id}/{quantity}")]  // api/medicine/id/quantity
        public bool CheckAvaliableQuantity(int id, int quantity)
        {
            return medicineService.CheckAvaliableQuantity(id, quantity);
        }

        [HttpPost("{hospitalApiKey?}")] 
        public IActionResult CheckIfExists(SearchMedicineDTO searchMedicine, string hospitalApiKey)
        {
            //ovo treba refaktorisati zbog dbContexta
            List<Hospital> result = new List<Hospital>();
            dbContext.Hospitals.ToList().ForEach(hospital => result.Add(hospital));
            foreach (Hospital hospital in result)
            {
                if (hospital.HospitalApiKey == hospitalApiKey)
                {
                    return Ok(medicineService.CheckIfExists(searchMedicine.medicineName, searchMedicine.medicineAmount));
                }
            }
            return NotFound();
        }

        [HttpPut("{hospitalApiKey}")]
        public IActionResult reduceQuantityOfMedicine(SearchMedicineDTO searchMedicine, string hospitalApiKey)
        {
            //ovo treba refaktorisati zbog dbContexta
            List<Hospital> result = new List<Hospital>();
            dbContext.Hospitals.ToList().ForEach(hospital => result.Add(hospital));
            foreach (Hospital hospital in result)
            {
                if (hospital.HospitalApiKey == hospitalApiKey)
                {
                    return Ok(medicineService.reduceQuantityOfMedicine(searchMedicine.medicineName, searchMedicine.medicineAmount));
                }
            }
            return NotFound();
        }
    }
}
