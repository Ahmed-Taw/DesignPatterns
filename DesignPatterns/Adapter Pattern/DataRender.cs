using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter_Pattern
{

    // the main class which render pattern wants to use 
   public class DataRender
    {
        private readonly IDbDataAdapter _dbDataAdapter;

        public DataRender(IDbDataAdapter dbDataAdapter)
        {
            _dbDataAdapter = dbDataAdapter;
        }

        public void Render (TextWriter textWriter)
        {
            textWriter.WriteLine("Rendering data:");
            var myData = new DataSet();

            _dbDataAdapter.Fill(myData);

            foreach (DataTable table in myData.Tables)
            {
                foreach (DataColumn column in table.Columns)
                {
                    textWriter.Write(column.ColumnName.PadRight(20) + " ");
                }
                textWriter.WriteLine();

                foreach (DataRow row in table.Rows)
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        textWriter.Write(row[i].ToString().PadRight(20) + "  ");
                    }
                    textWriter.WriteLine();
                }
                {

                }
            }
        }
    }
}
