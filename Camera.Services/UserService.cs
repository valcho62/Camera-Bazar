
using System.Linq;
using AutoMapper;
using Camera.Models.Entity;
using Camera.Models.View.User;

namespace Camera.Services
{
    public class UserService :Service
    {
        public void RegisterUser(RegisterUserVM user)
        {
            var user1 = Mapper.Map<User>(user);
            Contex.Users.Add(user1);
            Contex.SaveChanges();
        }

        public void Login(LoginVM userToLogin)
        {
            
            var user =Contex.Users.FirstOrDefault(
                    x => x.Username == userToLogin.Username 
                    && x.Password == userToLogin.Password);
            if (user != null)
            {
                var session = new Session();
                session.IsActive = true;
                session.User = user;
                Contex.Sessions.Add(session);
                Contex.SaveChanges();
            }

        }

        public void Logout(string sessionId)
        {
            var session = Contex.Sessions.FirstOrDefault(x => x.SessionId == sessionId);
            session.IsActive = false;
            Contex.SaveChanges();
        }
    }
}
