namespace ERP_System;

public class Person
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public Address Address { get; set; } 
    public string PhoneNumber { get; set; } = "";
    public string Email { get; set; } = "";

    public string GetPersonInfo()
    {
        return $"{FirstName}, {LastName}, {Address}, {PhoneNumber}, {Email}";
    }
}