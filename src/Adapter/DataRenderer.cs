using System.Data;
using System.IO;

namespace Adapter
{
    // The Adaptee, we want to use that class from a consumer.
    public class DataRenderer
    {
        private readonly IDataAdapter _dataAdapter;

        public DataRenderer(IDataAdapter dataAdapter)
        {
            _dataAdapter = dataAdapter;
        }

        public void Render(TextWriter writer)
        {
            var dataSet = new DataSet();
            _dataAdapter.Fill(dataSet);

            foreach (DataTable table in dataSet.Tables)
            {
                foreach (DataColumn column in table.Columns)
                {
                    writer.Write(column.ColumnName.PadRight(20) + " ");
                }
                writer.WriteLine();
                foreach (DataRow row in table.Rows)
                {
                    for (int i = 0; i < table.Columns.Count; i++)
                    {
                        writer.Write(row[i].ToString().PadRight(20) + " ");
                    }
                    writer.WriteLine();
                }
            }
        }
    }
}