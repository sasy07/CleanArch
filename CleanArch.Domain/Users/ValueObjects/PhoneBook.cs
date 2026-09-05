using CleanArch.Domain.Shared;

namespace CleanArch.Domain.Users.ValueObjects;

public class PhoneBook(PhoneNumber telNumber, PhoneNumber fax) : BaseValueObject
{
    public PhoneNumber TelNumber { get; } = telNumber;
    public PhoneNumber Fax { get; } = fax;
}