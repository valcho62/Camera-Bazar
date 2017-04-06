

using Camera.Data;

namespace CarDealerApp.Service
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