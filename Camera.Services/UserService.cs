
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

        public void Login(LoginVM userToLogin, string sessionId)
        {
            if (!this.Contex.Sessions.Any(login => login.SessionId == sessionId))
            {
                this.Contex.Sessions.Add(new Session() { SessionId = sessionId });
                this.Contex.SaveChanges();
            }

            var user =Contex.Users.FirstOrDefault(
                    x => x.Username == userToLogin.Username 
                    && x.Password == userToLogin.Password);
            if (user != null)
            {
                var session = Contex.Sessions.FirstOrDefault(x => x.SessionId == sessionId);
                session.IsActive = true;
                session.User = user;
                Contex.SaveChanges();
            }

        }

        public void Logout(string sessionId)
        {
            var session = Contex.Sessions.FirstOrDefault(x => x.SessionId == sessionId);
            session.IsActive = false;
            Contex.SaveChanges();
        }

        public UserProfileVM MakeProfileVm(int id)
        {
            var user = Contex.Users.Find(id);
            var profileVM = Mapper.Map<UserProfileVM>(user);
            
            profileVM.InstockCamera = user.OwnCameras.Count(x => x.Quantity > 0);
            profileVM.OutStockCamera = user.OwnCameras.Count(x => x.Quantity == 0);

            return profileVM;
        }
    }
}
