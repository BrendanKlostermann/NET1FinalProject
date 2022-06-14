using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataObjects;

namespace DataAccessLayer
{
    public class AmmoDataAccessor
    {

        public static List<Ammo> RetrieveAmmoList()
        {
            List<Ammo> ammoList = new List<Ammo>();
            char[] seperator = { ',' };
            try
            {
                StreamReader fileReader = new StreamReader(AppData.DataPath + "\\" + AppData.AmmoFileName);
                while(fileReader.EndOfStream == false)
                {
                    string line = fileReader.ReadLine();
                    string[] parts;

                    if(line.Length > 10)
                    {
                        parts = line.Split(seperator);
                        if(parts.Count() == 5)
                        {
                            Ammo newAmmo = new Ammo();
                            newAmmo.ammoType = parts[0];
                            newAmmo.ammoWeight = parts[1];
                            newAmmo.ammoCharge = parts[2];
                            newAmmo.ammoPrimer = parts[3];
                            newAmmo.ammoLength = parts[4];

                            ammoList.Add(newAmmo);
                        }
                    }
                }
                fileReader.Close();

            }
            catch (Exception up)
            {
                throw up;
            }
            return ammoList;

        } // end of RetrieveAmmoList

        public static Ammo RetrieveAmmoItem(int indexValue)
        {
            List<Ammo> _ammoList= RetrieveAmmoList();
            Ammo ammoItem = _ammoList[indexValue];

            return ammoItem;
        } // end of RetreiveAmmoItem

        public static bool UpdateAmmo(Ammo ammoItem, int Index)
        {
            bool result = false;
            StreamWriter csvWriter = null;
            List<Ammo> ammoList = RetrieveAmmoList();

            try
            {
                csvWriter = new StreamWriter(AppData.DataPath + "\\" + AppData.AmmoFileName);
                ammoList[Index] = ammoItem;

                foreach (Ammo a in ammoList)
                {
                    csvWriter.WriteLine(a.ammoType + "," + a.ammoWeight + "," + a.ammoCharge +
                        "," + a.ammoPrimer + "," + a.ammoLength);
                }

                result = true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                csvWriter.Close();
            }

            return result;
        } // end of UpdateAmmo

        public static bool AddAmmo(List<Ammo> al)
        {
            bool result = false;
            StreamWriter csvWriter = null;
            List<Ammo> ammoList = al;

            try
            {
                csvWriter = new StreamWriter(AppData.DataPath + "\\" + AppData.AmmoFileName);

                foreach (Ammo a in ammoList)
                {
                    csvWriter.WriteLine(a.ammoType + "," + a.ammoWeight + "," + a.ammoCharge +
                        "," + a.ammoPrimer + "," + a.ammoLength);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                csvWriter.Close();
            }

            return result;
        }

    } // end of class AmmoDataAccessor

}
