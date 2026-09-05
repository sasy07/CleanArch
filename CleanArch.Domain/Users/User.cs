using CleanArch.Domain.Users.ValueObjects;

namespace CleanArch.Domain.Users;

public class User(string firstName, string lastName, PhoneBook phoneBook)
{
    public string FirstName { get; private set; } = firstName;
    public string LastName { get; private set; } = lastName;
    public PhoneBook PhoneBook { get; private set; } = phoneBook;
}

