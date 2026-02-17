public class PersonRepository
{
    private readonly PersonParser _parser;
    private readonly FileReader _reader;

    public PersonRepository()
    {
        _reader = new FileReader();
        _parser = new PersonParser();
    }
    
    public IQueryable<Person> Query()
    {
        var dataLines = _reader.ReadLines("data.csv");
        var persons = dataLines.Select(_parser.Parse);
        return persons.AsQueryable();
    }
}