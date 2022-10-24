using DAL;
using DTO;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.Migrations;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;


namespace BL
{

    public class MemberBL
    {

        public static Members11[] GetMember()
        {
            using (CovidEntities1 db = new CovidEntities1())
            {
                return db.Members11.ToArray();


            }


        }

        public static void AddMember(MembersDTO member)
        {
            using (CovidEntities1 db = new CovidEntities1())
            {
                db.Members11.Add(CONVERTERS.MemberConverter.ConvertMemberToDAL(member));
                db.SaveChanges();

            }
        }
        public static void Delete(string id)
        {
            using (CovidEntities1 db = new CovidEntities1())
            {
                Members11 member = db.Members11.Where(m => m.Id == id).FirstOrDefault();
                if (member == null)
                {
                    return;
                }
                db.Members11.Remove(member);
                db.SaveChanges();

            }
        }

        public static Members11 GetMemberById(string id)
        {

            using (CovidEntities1 db = new CovidEntities1())
            {
                Members11 member = db.Members11.Where(m => m.Id == id).FirstOrDefault();
                if (member == null)
                {
                    return null;
                }

                return member;

            }

        }
        public static void SaveChanges(Members11 member)
        {
            Members11 newMember = GetMemberById(member.Id);
            using (CovidEntities1 db = new CovidEntities1())
            {

                newMember.Id = member.Id;
                newMember.FirstName = member.FirstName;
                newMember.LastName = member.LastName;
                newMember.City = member.City;
                newMember.Steet = member.Steet;
                newMember.Bildingnumber = member.Bildingnumber;
                newMember.Phone = member.Phone;
                newMember.Cellphone = member.Cellphone;
                DateTime dt6 = DateTime.ParseExact(member.Birthday.ToString(), "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                string s6 = dt6.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                if (member.Sickdate != null) { 
                DateTime dt = DateTime.ParseExact(member.Sickdate.ToString(), "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                string s = dt.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                if (member.Recoverydate != null) { 
                DateTime dt1 = DateTime.ParseExact(member.Recoverydate.ToString(), "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                string s1 = dt1.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                newMember.Atipevaccin = member.Atipevaccin;
                if (member.AvaccinDate != null)
                {
                    DateTime dt2 = DateTime.ParseExact(member.AvaccinDate.ToString(), "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                    string s2 = dt2.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                 newMember.Btipevaccin = member.Btipevaccin;
                if (member.BvaccindDate != null)
                {
                    DateTime dt3 = DateTime.ParseExact(member.BvaccindDate.ToString(), "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                    string s3 = dt3.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                    newMember.Ctipevaccin = member.Ctipevaccin;
                if (member.CvaccinDate != null)
                {
                    DateTime dt4 = DateTime.ParseExact(member.CvaccinDate.ToString(), "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                    string s4 = dt4.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                    newMember.Dtipevaccin = member.Dtipevaccin;
                if (member.DvaccinDate != null)
                {
                    DateTime dt5 = DateTime.ParseExact(member.DvaccinDate.ToString(), "dd/MM/yyyy hh:mm:ss", CultureInfo.InvariantCulture);
                    string s5 = dt5.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                db.Members11.AddOrUpdate(newMember);

                db.SaveChanges();
            }


        }
        
    }
}