Employee e = new Employee();
e.FirstName = "John";
e.LastName = "Doe";

class Employee
{
    public string FirstName
    {
        get
        {
            return _firstName;    
        }
        set
        {
            _firstName = value;
        }
    }
    private string _firstName;

    public string LastName
    {
        get
        {
            return _lastName;
        }
        set
        {
            _lastName = value;
        }
    }
    private string _lastName;
}

