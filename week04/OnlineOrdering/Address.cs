public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    private string _zipCode;

    public Address(string street, string city, string state, string zipCode, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _country = country;
    }

    public bool IsInUSA()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public string GetFullAddress()
    {
        return $"{_street}\n{_city}, {_state} {_zipCode}\n{_country}";
    }


    // Getters and Setters
    public string GetStreet() { return _street; }

    public void SetStreet(string street) { _street = street;}

    public string GetCity() { return _city; }

    public void SetCity(string city) { _city = city; }

    public string GetState() { return _state; }

    public void SetState(string state) { _state = state; }

    public string GetZipCode() { return _zipCode; }

    public void SetZipCode(string zipCode) {  _zipCode = zipCode; }

    public string GetCountry() { return _country; }
    
    public void SetCountry(string country) { _country = country; }
}