using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Annotation_User_Registration
{
    internal class Program
    {
        
        public static void Main(string[] args) 
        {
           User_Reg user_Reg = new User_Reg();
            user_Reg.FirstName = "Sanjana";
            user_Reg.LastName = "Dhenge";
            user_Reg.Email = "abc@5123gmail.com";
            user_Reg.PhoneNumber= "1234567890";
            ValidationContext context = new ValidationContext(user_Reg, null, null);
            List<ValidationResult> results = new List<ValidationResult>();
            bool valid = Validator.TryValidateObject(user_Reg, context, results, true);
            if (!valid)
            {
                foreach (ValidationResult result in results)
                {
                    Console.WriteLine("Member Name :{0}", result.MemberNames.First(), Environment.NewLine);
                    Console.WriteLine("Error Message :: {0}{1}", result.ErrorMessage, Environment.NewLine);
                }
            }
            else
            {
                Console.WriteLine(user_Reg.FirstName);
                Console.WriteLine(user_Reg.LastName);
                Console.WriteLine(user_Reg.Email);
                Console.WriteLine(user_Reg.PhoneNumber);
            }
        }
    }
}
