
using System.Linq;
using Camera.Data;
using Camera.Models.Entity;

namespace Camera.Services
{
    public class AuthenticationManager
    {
        public static CameraBazarContex contex = new CameraBazarContex();

        public static bool IsLoged(string sessionId)
        {
            var session = contex.Sessions.FirstOrDefault(x => x.SessionId==sessionId);
            if (session != null && session.IsActive)
            {
                return true;
            }

            return false;
        }

        public static User GetUser(string sessionId)
        {
            var session = contex.Sessions.FirstOrDefault(x => x.SessionId == sessionId);

            if (session != null)
            {
                return session.User;
            }
            return null;
        }

        public static void Logout(string sessionId)
        {
            var session = contex.Sessions.FirstOrDefault(x => x.SessionId == sessionId);
            session.IsActive = false;
            contex.SaveChanges();
        }
    }
}
