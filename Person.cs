namespace ERP_System;

public class Person
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string FullName => FirstName + " " + LastName;
    public Address Address { get; set; } = new Address();
    public string PhoneNumber { get; set; } = "";
    public string Email { get; set; } = "";

    public string GetPersonInfo()
    {
        return $"{FirstName}, {LastName}, {Address}, {PhoneNumber}, {Email}";
    }
}
