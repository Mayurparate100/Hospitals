using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Hospitals.Data;

namespace Hospitals.Models
{
    public class HdetailModel
    {
        public int HospitalId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public string photo { get; set; }

        public string SaveHdetail(HdetailModel model)
        {
            string msg = "";
            HospitalsEntities Db = new HospitalsEntities();
            {
                var saveHdetail = new Tbl_Hdetail()
                {
                    HospitalId = model.HospitalId,
                    Name = model.Name,
                    Mobile = model.Mobile,
                    Email = model.Email,
                    City = model.City,
                    Description = model.Description,
                    photo = model.photo,
                   
                };
                Db.Tbl_Hdetail.Add(saveHdetail);
                Db.SaveChanges();
                msg = saveHdetail.HospitalId.ToString();
                return msg;

            }
        }

        public List<HdetailModel> GetHdetailList()
        {
            HospitalsEntities Db = new HospitalsEntities();
            List<HdetailModel> lstHdetail = new List<HdetailModel>();
            var AddHdetailList = Db.Tbl_Hdetail.ToList();
            if (AddHdetailList != null)
            {
                foreach (var detail in AddHdetailList)
                {
                    lstHdetail.Add(new HdetailModel()
                    {
                        HospitalId = detail.HospitalId,
                        Name = detail.Name,
                        Mobile = detail.Mobile,
                        Email = detail.Email,
                        City = detail.City,
                        Description = detail.Description,
                        photo = detail.photo,



                    });
                }
            }
            return lstHdetail;

        }


    }
}