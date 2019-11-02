using System.IO;

namespace TestNinja.Fundamentals
{
    public class Reservation
    {
        public User MadeBy { get; set; }

        public bool CanBeCancelledBy(User user)
        {
            bool result;

//            return (user.IsAdmin || MadeBy == user);
            if (user.IsAdmin)
            {
                result =  true;
            }
            else if (MadeBy == user)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            return result;
        }
        
    }

    public class User
    {
        public bool IsAdmin { get; set; }
    }
}