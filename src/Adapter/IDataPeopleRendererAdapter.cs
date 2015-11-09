using System.Collections.Generic;

namespace Adapter
{
    // The adapter interface
    public interface IDataPeopleRendererAdapter
    {
        string RenderPeople(IEnumerable<Person> people);
    }
}