using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data;

namespace LogBook
{
    public static class Export
    {
        public static void ToCSV(DataTable dt, string filePath)
        {
            FileStream fs = null;
            StreamWriter sw = null;

            try
            {
                fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                sw = new StreamWriter(fs, Encoding.Default);
                
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    string[] arr = new string[dt.Columns.Count];
                    for (int j = 0; j < dt.Columns.Count; j++)
                        arr[j] = dt.Rows[i][j].ToString();
                    sw.WriteLine(string.Join(";", arr));
                }
            }
            finally
            {
                sw?.Close();
                fs?.Close();
            }
        }
    }
}
