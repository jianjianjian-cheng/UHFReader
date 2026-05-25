using System.Collections.Generic;
using UHFReader.DAL;
using UHFReader.Models;

namespace UHFReader.BLL
{
  public class MedicineBll
  {
    private MedicineDal _medicineDal = new MedicineDal();

    public bool AddMedicine(Medicine medicine)
    {
      return _medicineDal.AddMedicine(medicine) > 0;
    }

    public bool UpdateMedicine(Medicine medicine)
    {
      return _medicineDal.UpdateMedicine(medicine) > 0;
    }

    public bool DeleteMedicine(int id)
    {
      return _medicineDal.DeleteMedicine(id) > 0;
    }

    public Medicine GetMedicineById(int id)
    {
      return _medicineDal.GetMedicineById(id);
    }

    public List<Medicine> GetAllMedicines()
    {
      return _medicineDal.GetAllMedicines();
    }

    public List<Medicine> SearchMedicines(string keyword)
    {
      return _medicineDal.SearchMedicines(keyword);
    }

    public bool ExistsByCode(string code)
    {
      return _medicineDal.ExistsByCode(code);
    }
  }
}
