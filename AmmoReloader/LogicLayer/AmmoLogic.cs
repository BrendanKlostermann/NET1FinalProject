using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;
using DataAccessLayer;

namespace LogicLayer
{
    public class AmmoLogic
    {
        public List<Ammo> FetchAmmoList()
        {
            List<Ammo> ammoList = null;

            try
            {
                ammoList = AmmoDataAccessor.RetrieveAmmoList();
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Your data was not available", ex);
            }

            return ammoList;
        } // end of FetchAmmoList

        public static Ammo FetchAmmoItem(int i)
        {
            int index = i;
            Ammo ammo = null;
            try
            {
                ammo = AmmoDataAccessor.RetrieveAmmoItem(i);
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Your data was not available", ex);
            }

            return ammo;
        } // end of FetchAmmoItem

        public static bool ModifyAmmo(Ammo ammo, int Index)
        {
            bool result = false;

            try
            {
                result = AmmoDataAccessor.UpdateAmmo(ammo, Index);
            }
            catch (Exception ex)
            {

                throw new ApplicationException("Ammo information was not saved!", ex);
            }

            return result;
        }// End of ModifyAmmo

        public static bool UpdateAmmoList(List<Ammo> al)
        {
            bool result = false;
            List<Ammo> newAmmoList = al;

            try
            {
                result = AmmoDataAccessor.AddAmmo(newAmmoList);
                result = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return result;
        } // end of UpdateAmmoList

        public static bool CheckForNum(String val)
        {
            bool isNum = false;
            double number;
            if(double.TryParse(val, out number))
            {
                isNum = true;
            }
            return isNum;
        }

        public static double TotalCharge(String ch, int amount)
        {
            double charge = double.Parse(ch);
            double total;
            total = charge * amount;
            return total;
        }

    } // end of class AmmoLogic
}
