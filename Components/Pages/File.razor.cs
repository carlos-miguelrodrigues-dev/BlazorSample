using Microsoft.AspNetCore.Components;
using static DriveV3Snippets.UploadBasic;


namespace BlazorSample.Components.Pages;

public partial class File
{
    private ElementReference fileInput;
    private string statusMessage = "";

    private async Task BrowseFile()
    {
        await fileInput.FocusAsync();
    }

    private async Task SubmitFile()
    {
        if (fileInput.ToString == null)
        {
            statusMessage = "No file selected!";
            return;
        }
        string path = fileInput.ToString() ?? string.Empty;
        
        Console.WriteLine($"Submitting file: {path}");
        DriveUploadBasic(path);
        statusMessage = "File submitted successfully!";
        await Task.Delay(2000);
        statusMessage = "";
    }
}