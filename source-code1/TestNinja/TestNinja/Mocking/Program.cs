namespace TestNinja.Mocking
{
    public class Program
    {
        public static void Main()
        {
            VideoService service = new VideoService();
            
            //injecting dependencies via method parameters
            //var title = service.ReadVideoTitle(new FileReader());

            var title = service.ReadVideoTitle();
        }
    }
}