using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaServicios.Business
{
    class Vehiculo_Servicios
    {
        public Model.Vehiculo_Servicios BuscarVehiculo_ServicioId(int ID_Vehiculo_Servicio)
        {

            DataAccess.GestorDeVehiculo_Servicios elGestorDeVehiculo = new DataAccess.GestorDeVehiculo_Servicios();
            return elGestorDeVehiculo.ConsultarVehiculo_Servicio(ID_Vehiculo_Servicio);

        }
        public List<Model.Vehiculo_Servicios> ListarVehiculo()
        {
            DataAccess.GestorDeVehiculo_Servicios elGestorDeVehiculo = new DataAccess.GestorDeVehiculo_Servicios();
            return elGestorDeVehiculo.ListarVehiculo_Servicio();
        }
    }
}
