using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    class ReadFromCsv
    {
        public static List<Visitor> ReadFromCsvToList(string path)
        {
            var list = new List<Visitor>();
            try
            {
                if (!File.Exists(path)) return list;
                using (var fileStream = File.OpenRead(path))
                {
                    using (var streamReader = new StreamReader(fileStream))
                    {
                        var lines= "";
                        string justReadFirstLine = streamReader.ReadLine();
                        while ((lines = streamReader.ReadLine()) != null)
                        {
                            var splitVisitor = lines.Split(',');
                            list.Add(new Visitor(int.Parse(splitVisitor[0]), splitVisitor[1],
                                int.Parse(splitVisitor[2]),
                                splitVisitor[3], splitVisitor[4], splitVisitor[5], splitVisitor[6], splitVisitor[7],
                                splitVisitor[8], splitVisitor[9]));
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "From Read From CSV File.");
                return null;
            }
            return list;
        }
    }
}