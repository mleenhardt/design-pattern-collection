using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Adapter
{
    // The adapter concrete implementation
    public class DataPeopleRendererAdapter : IDataPeopleRendererAdapter
    {
        public string RenderPeople(IEnumerable<Person> people)
        {
            var personAdapter = new PersonCollectionDataAdapter(people);
            var dataRenderer = new DataRenderer(personAdapter);
            using (var sw = new StringWriter())
            {
                dataRenderer.Render(sw);
                return sw.ToString();
            }
        }

        // A private implementation of IDataAdapter required to provide the adaptee with.
        private class PersonCollectionDataAdapter : IDataAdapter
        {
            private readonly IEnumerable<Person> _people;

            public PersonCollectionDataAdapter(IEnumerable<Person> people)
            {
                _people = people;
            }

            public int Fill(DataSet dataSet)
            {
                var dataTable = new DataTable();
                dataTable.Columns.Add(new DataColumn("Id", typeof(int)));
                dataTable.Columns.Add(new DataColumn("Age", typeof(int)));
                dataTable.Columns.Add(new DataColumn("Name", typeof(string)));

                foreach (Person person in _people)
                {
                    DataRow row = dataTable.NewRow();
                    row[0] = person.Id;
                    row[1] = person.Age;
                    row[2] = person.Name;
                    dataTable.Rows.Add(row);
                }
                dataSet.Tables.Add(dataTable);
                dataSet.AcceptChanges();

                return dataTable.Rows.Count;
            }

            // We would implement all that stuff in a real world scenario
            public DataTable[] FillSchema(DataSet dataSet, SchemaType schemaType)
            {
                throw new System.NotImplementedException();
            }

            public IDataParameter[] GetFillParameters()
            {
                throw new System.NotImplementedException();
            }

            public int Update(DataSet dataSet)
            {
                throw new System.NotImplementedException();
            }

            public MissingMappingAction MissingMappingAction { get; set; }
            public MissingSchemaAction MissingSchemaAction { get; set; }
            public ITableMappingCollection TableMappings { get; private set; }
        }
    }
}