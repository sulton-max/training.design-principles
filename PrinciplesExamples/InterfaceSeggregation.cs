namespace PrinciplesExamples;

// Clients ( Implementation of interfaces ) never should be forced to implement method that they never use
public interface IContentAnalyzingService
{
    int CalculateReadingTime(string content);

    int CalculateContentQuality(string content);

    // Ok, what but is this ?! ... 
    int CanBePublishedToMedium(string content);
}