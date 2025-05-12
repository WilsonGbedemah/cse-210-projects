using System.ComponentModel.DataAnnotations;

public class Job
{
    public string _companyName = "";
    public string _jobTitle = "";
    public string _startYear = "";
    public string _endYear = "";

    public  void DisplayJobDetails()
    {
        Console.WriteLine($"{_jobTitle} ({_companyName}) {_startYear}-{_endYear} ");
    }
}