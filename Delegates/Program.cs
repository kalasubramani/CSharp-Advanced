
using Delegates;

String path = "C:\\Photos\\image.jpg";

PhotoProcessor processor = new PhotoProcessor();

//client
var filters = new PhotoFilters();
//call only required 
//PhotoProcessor.PhotoFilterHandler filterHandler = filters.ApplyBrightness;

//use action delegates
Action<Photo> filterHandler = filters.ApplyBrightness;

//add more fns to delegate
filterHandler += filters.ApplyContrast;
filterHandler += RemoveRedEyeFilter;
processor.Process(path,filterHandler);

//create new method to add on to delegate
//must math delegate signature
static void RemoveRedEyeFilter(Photo photo)
{
    Console.WriteLine("Applying remove red eye filter");
}