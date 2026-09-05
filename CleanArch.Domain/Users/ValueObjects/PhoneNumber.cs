using CleanArch.Domain.Shared;

namespace CleanArch.Domain.Users.ValueObjects;

public class PhoneNumber:BaseValueObject
{
    public string Value { get; }

    public PhoneNumber(string value)
    {
        if(value.Length is < 11 or > 11)
        {
            throw new ArgumentException("Invalid phone number format");
        }
        Value = value;
    }
}