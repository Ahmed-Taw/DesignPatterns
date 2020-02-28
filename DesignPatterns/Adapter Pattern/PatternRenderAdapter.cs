using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Adapter_Pattern
{
    // Adapter implementation 
    public class PatternRenderAdapter : IPatternRenderAdapter
    {

        public string RenderPatterns(IEnumerable<Pattern> patterns)
        {
            var dataAdapter = new PatternCollectionDataAdapter(patterns);
            var renderData = new DataRender(dataAdapter);

            var stringWriter = new StringWriter();

            renderData.Render(stringWriter);

            return stringWriter.ToString();
        }


        internal class PatternCollectionDataAdapter : IDbDataAdapter
        {
            private readonly IEnumerable<Pattern> _patterns;
            public PatternCollectionDataAdapter(IEnumerable<Pattern> patterns)
            {
                _patterns = patterns;
            }
            public int Fill(DataSet dataSet)
            {
                var dtable = new DataTable();

                dtable.Columns.Add(new DataColumn("ID", typeof(int)));
                dtable.Columns.Add(new DataColumn("Name", typeof(string)));

                foreach (Pattern pattern in _patterns)
                {
                    var draw = dtable.NewRow();

                    draw[0] = pattern.Id;
                    draw[1] = pattern.Name;

                    dtable.Rows.Add(draw);
                }
                

                dataSet.Tables.Add(dtable);
                dataSet.AcceptChanges();

                return 1;
            }

            public IDbCommand SelectCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public IDbCommand InsertCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public IDbCommand UpdateCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public IDbCommand DeleteCommand { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public MissingMappingAction MissingMappingAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public MissingSchemaAction MissingSchemaAction { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public ITableMappingCollection TableMappings => throw new NotImplementedException();

            
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
}
