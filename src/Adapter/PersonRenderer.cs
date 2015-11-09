using System.Collections.Generic;

namespace Adapter
{
    // The consumer
    public class PersonRenderer
    {
        private readonly IDataPeopleRendererAdapter _dataPeopleRendererAdapter;
        
        public PersonRenderer(IDataPeopleRendererAdapter dataPeopleRendererAdapter)
        {
            _dataPeopleRendererAdapter = dataPeopleRendererAdapter;
        }

        public string RenderPeople(IEnumerable<Person> people)
        {
            return _dataPeopleRendererAdapter.RenderPeople(people);
        }
    }
}