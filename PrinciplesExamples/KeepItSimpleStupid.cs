namespace PrinciplesExamples;

// Don't use advanced code than needed
// Clear variable names
public interface IFormFile
{
    
}

public class ProfileService
{
    public void UploadPhoto(IFormFile file)
    {
        // Validate extensions
        
        // Validate size
        
        // Upload
    }

    // Do we really need this ?!
    public void UploadPhotoAdvanced(IFormFile file)
    {
        // Validate extensions
        
        // Validate size
        
        // Validate photo content
        
        // Check photo taken location
        
        // Check photo taken time
        
        // Compare with other photos to avoid duplicates
        
        // Upload
    }
    
    
}