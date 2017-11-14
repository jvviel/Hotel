using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Camadas.BLL
{
    public class Reserva
    {
        public List<Model.Reserva> Select()
        {
            DAL.Reserva dalReserva = new DAL.Reserva();

            return dalReserva.Select();
        }

        public void Insert(Model.Reserva reserva)
        {
            DAL.Reserva dalReserva = new DAL.Reserva();

            dalReserva.Insert(reserva);
        }

        public void Update(Model.Reserva reserva)
        {
            DAL.Reserva dalReserva = new DAL.Reserva();

            dalReserva.Update(reserva);
        }

        public void Delete(Model.Reserva reserva)
        {
            DAL.Reserva dalReserva = new DAL.Reserva();

            dalReserva.Delete(reserva);
        }
    }
}
