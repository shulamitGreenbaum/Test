using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.CONVERTERS
{
    public static class MemberConverter
    {
        public static Members11 ConvertMemberToDAL(MembersDTO member)
        {
            return new Members11
            {
                TableID = member.TableID,
                FirstName = member.FirstName,
                LastName = member.LastName,
                Id = member.Id,
                City = member.City,
                Steet = member.Steet,
                Bildingnumber = member.Bildingnumber,
                Birthday = member.Birthday,
                Phone = member.Phone,
                Cellphone = member.Cellphone,
                AvaccinDate = (DateTime)member.AvaccinDate,
                Atipevaccin = member.Atipevaccin,
                Sickdate = (DateTime)member.Sickdate,
                Recoverydate = (DateTime)member.Recoverydate,
                BvaccindDate = (DateTime)member.BvaccindDate,
                Btipevaccin = member.Btipevaccin,
                CvaccinDate = (DateTime)member.CvaccinDate,
                Ctipevaccin = member.Ctipevaccin,
                DvaccinDate = (DateTime)member.DvaccinDate,
                Dtipevaccin = member.Dtipevaccin,
            };
        }
        public static Members11 ConvertMemberToDTO(Members11 member)
        {
            return new Members11
            {
                TableID = member.TableID,
                FirstName = member.FirstName,
                LastName = member.LastName,
                Id = member.Id,
                City = member.City,
                Steet = member.Steet,
                Bildingnumber = member.Bildingnumber,
                Birthday = member.Birthday,
                Phone = member.Phone,
                Cellphone = member.Cellphone,
                AvaccinDate = member.AvaccinDate,
                Atipevaccin = member.Atipevaccin,
                Sickdate = member.Sickdate,
                Recoverydate = member.Recoverydate,
                BvaccindDate = member.BvaccindDate,
                Btipevaccin = member.Btipevaccin,
                CvaccinDate = member.CvaccinDate,
                Ctipevaccin = member.Ctipevaccin,
                DvaccinDate = member.DvaccinDate,
                Dtipevaccin = member.Dtipevaccin,
            };
        }



    }
}
