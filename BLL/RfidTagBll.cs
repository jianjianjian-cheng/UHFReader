using System;
using System.Collections.Generic;
using UHFReader.DAL;
using UHFReader.Models;

namespace UHFReader.BLL
{
    public class RfidTagBll
    {
        private RfidTagDal _tagDal = new RfidTagDal();

        public bool AddTag(RfidTag tag)
        {
            return _tagDal.AddTag(tag) > 0;
        }

        public bool BindTagToMedicine(string epc, int medicineId, string tid = "")
        {
            var tag = _tagDal.GetTagByEpc(epc);
            if (tag == null)
            {
                tag = new RfidTag
                {
                    Epc = epc,
                    Tid = tid,
                    MedicineId = medicineId,
                    Status = "Bound",
                    BindTime = DateTime.Now
                };
                return _tagDal.AddTag(tag) > 0;
            }
            else
            {
                tag.MedicineId = medicineId;
                tag.Status = "Bound";
                tag.BindTime = DateTime.Now;
                if (!string.IsNullOrEmpty(tid))
                    tag.Tid = tid;
                return _tagDal.UpdateTag(tag) > 0;
            }
        }

        public bool UpdateTagStatus(string epc, string status)
        {
            return _tagDal.UpdateTagStatus(epc, status) > 0;
        }

        public RfidTag GetTagByEpc(string epc)
        {
            return _tagDal.GetTagByEpc(epc);
        }

        public List<RfidTag> GetAllTags()
        {
            return _tagDal.GetAllTags();
        }

        public List<RfidTag> GetTagsByStatus(string status)
        {
            return _tagDal.GetTagsByStatus(status);
        }
    }
}
