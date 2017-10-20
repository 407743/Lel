using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWorkingModel
{
    class FileHandler
    {
        private static FileHandler m_getInstance;

        private FileHandler()
        {
            try
            {

                string fileName = System.IO.Path.GetFullPath(Directory.GetCurrentDirectory() + @"\..\..\patients.csv");
                Console.WriteLine(fileName);
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] fields = line.Split(';');
                        PatientController.Instance().AddPatient(fields[0], fields[1], fields[2], fields[3], fields[4], fields[5]);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
            }
        }

        public static FileHandler Instance()
        {
            if(m_getInstance == null)
            {
                m_getInstance = new FileHandler();
            }
            return m_getInstance;
        }
    }
}
