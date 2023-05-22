using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Learnings.SampleTask.FileHandling.Serialization
{
    [Serializable()]
    public class EmployeeData
    {
        string EmpName = "";
        int EmpID = 0;

        public EmployeeData(string Name, int ID)
        {
            EmpName = Name;
            EmpID = ID;
        }
    }


    internal class Serialization
    {
        string pathSerial = "E:\\Yogesh\\Live\\Prac\\C#\\Learnings\\Learnings\\SampleTask\\FileHandling\\SampleDoc\\Serial.trace";
        List<EmployeeData> objLsEmployee = null;
        public Serialization()
        {
            objLsEmployee = SampleEmployeeData();
        }

        private List<EmployeeData> SampleEmployeeData()
        {
            List<EmployeeData> obj = new List<EmployeeData>();
            obj.Add(new EmployeeData("Yog", 1));
            obj.Add(new EmployeeData("Alex", 2));
            return obj;
        }

        public object DataDeSerialize()
        {
            object objDeSerialize;
            try
            {
                DataContractSerializer deSerializer = new DataContractSerializer(typeof(List<EmployeeData>));

                using (FileStream fs = File.Open(pathSerial, FileMode.Open))
                {
                    objDeSerialize = deSerializer.ReadObject(fs);
                    fs.Close();
                }
            }
            catch (Exception ex)
            {

                throw;
            }
            return objDeSerialize;
        }


        public void DataSerialize()
        {
            try
            {
                DataContractSerializer serializer = new DataContractSerializer(objLsEmployee.GetType());

                FileMode mod = FileMode.Create;
                if (File.Exists(pathSerial))
                    File.Delete(pathSerial);

                using (FileStream fs = File.Open(pathSerial, mod))
                {
                    serializer.WriteObject(fs, objLsEmployee);
                    fs.Close();
                }

                DataDeSerialize();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
