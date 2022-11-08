using PrinciplesExamples.Models;

namespace PrinciplesExamples;

// A class should have one and only one reason to change, meaning that a class should have only one job
public class PrintService
{
    // Ok, that's print
    public void Print(string path)
    {
        
    }

    // Ok, this for printing too
    public void AdjustForPrinter(string path)
    {
        
    }

    // Avoid concurrency, wait ... 
    public void CopyTheFileToAvoidConcurrency(string path)
    {
        
    }
}