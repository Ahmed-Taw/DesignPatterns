using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsTest.AdapterPattern
{
   public class StubDbAdapter : IDbDataAdapter
    {
        public IDbCommand SelectCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDbCommand InsertCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDbCommand UpdateCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public IDbCommand DeleteCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MissingMappingAction MissingMappingAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public MissingSchemaAction MissingSchemaAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ITableMappingCollection TableMappings => throw new NotImplementedException();

        public int Fill(DataSet dataSet)
        {
            var dtable = new DataTable();

            dtable.Columns.Add(new DataColumn("ID", typeof(int)));
            dtable.Columns.Add(new DataColumn("Name", typeof(string)));

            var draw = dtable.NewRow();

            draw[0] = 2;
            draw[1] = "Adapter";

            dtable.Rows.Add(draw);

            dataSet.Tables.Add(dtable);
            dataSet.AcceptChanges();
            
            return 1;
        }

        public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
        {
            throw new NotImplementedException();
        }

        public IDataParameter[] GetFillParameters()
        {
            throw new NotImplementedException();
        }

        public int Update(DataSet dataSet)
        {
            throw new NotImplementedException();
        }
    }
}
