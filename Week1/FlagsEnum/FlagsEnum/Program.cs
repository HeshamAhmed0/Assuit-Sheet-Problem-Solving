namespace FlagsEnum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Flags Enum
            Humans humans = new Humans();
            //humans.Id = 1;
            //humans.Name = "test";
            //humans.Properties = Properties.Delete;
            humans.Properties = (Properties)3;
            //Console.WriteLine(humans.Properties);
            //humans.Properties = humans.Properties ^ Properties.read;
            //Console.WriteLine(humans.Properties); 

            // Check for permission
            if ((humans.Properties&Properties.read)==Properties.read)
            {
                Console.WriteLine("This Human Has Read Permission ");
            }
            else
            {
                Console.WriteLine("This Human Not Has Read Property");
                humans.Properties^=Properties.read;
                Console.WriteLine("Operation Add Property Read Done Succcesful");
                Console.WriteLine(humans.Properties);

            }
            #endregion
        }
    }
}
