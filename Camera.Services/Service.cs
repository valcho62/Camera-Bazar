
using Camera.Data;

namespace Camera.Services
{
    public class Service
    {
        private CameraBazarContex contex;

        public Service()
        {
            this.contex =new CameraBazarContex();
        }

        public CameraBazarContex Contex => this.contex;
    }
}