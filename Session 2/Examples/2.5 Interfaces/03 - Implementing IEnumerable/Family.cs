class Family : IEnumerable<Person>
{
    private readonly Person[] _persons;

    public Family()
    {
        _persons = new Person[]
        {
            new Person("John", 42),
            new Person("Jane", 38),
            new Person("Baby", 0)
        };
    }

    public IEnumerator<Person> GetEnumerator()
    {
        yield return _persons[0];
        yield return _persons[1];
        yield return _persons[2];

        //int i = 0;
        //while (true)
        //{
        //    yield return _persons[i++];
        //    if (i == 3)
        //    {
        //        yield break;
        //    }
        //}
    }

    #region Never mind! ;-)

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    #endregion
}
