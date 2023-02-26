using InventoryLibrary;
using InventoryLibrary.Models;

namespace InventorySystem
{
    public class Program
    {
        static void Main(string[] args)
        {

            StartingMessage();
            int status = IdentifyUser();

            if (status == 1)
            {
                GetUserInfo();
                StockKeeper.UpdateStock();

            }
            else if(status == 2)
            {
                GetUserInfo();
            }
            else
            {
                Console.WriteLine(" ? ");
            }
            
        }

        public static void StartingMessage()
        {
            Console.WriteLine("\t*****ARPICO CENTER*****\n\t---Created By Nuwan---");
            var date = DateTime.Now;
            Console.WriteLine("\t " + date);
            Console.WriteLine();
        }

        public static int IdentifyUser()
        {
            Console.Write("Please Your Status (Enter : 1 to Stockeeper, 2 to Customer) : ");
            string statusText = Console.ReadLine();
            bool isValidStatus = int.TryParse(statusText, out int status);
            while (isValidStatus == false)
            {
                Console.Write("Please Enter valid Status. : ");
                statusText = Console.ReadLine();
                isValidStatus = int.TryParse(statusText, out status);
            }
            return status;
        }

        public static void GetUserInfo()
        {
            PersonModel person = new PersonModel();
            Console.Write("Enter User Name : ");
            string name = Console.ReadLine();
            person.UserName = name;
        } 
    }
}