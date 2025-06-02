namespace Domain.ValueObjects;

public class ExternalCode(string system, string id) : ValueObject
{
    public string System { get; private set; } = system;

    public string Id { get; private set; } = id;

    protected override IEnumerable<object> GetEqualityComponents()
    {
        yield return System;
        yield return Id;
    }
}
