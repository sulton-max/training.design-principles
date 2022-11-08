namespace PrinciplesExamples;

// Objects in a program should be replaceable with instances of their subtypes without altering the correctness of that program
// Child shouldn't do what parent does with wrong way
public interface IStorageService
{
    void Store(IFormFile file);
}

public class DriveStorageService : IStorageService
{
    public virtual void Store(IFormFile file)
    {
        // Validate
        
        // Store locally
    }
}

public class CloudServerStorageService : DriveStorageService
{
    public override void Store(IFormFile file)
    {
        // Check connection
        
        // Check service
        
        // Store to cloud ( if fails retry and do other stuff
    }
}