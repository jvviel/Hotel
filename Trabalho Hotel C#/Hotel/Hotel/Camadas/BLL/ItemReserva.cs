using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel.Camadas.BLL
{
    public class ItemReserva
    {
        public List<Model.ItemReserva> Select()
        {
            DAL.ItemReserva dalItemReserva = new DAL.ItemReserva();

            return dalItemReserva.Select();
        }

        public List<Model.ItemReserva> SelectByReserva(int reserva)
        {
            DAL.ItemReserva dalItemReserva = new DAL.ItemReserva();

            return dalItemReserva.SelectByReserva(reserva);

        }


        public void Insert(Model.ItemReserva itemReserva)
        {
            DAL.ItemReserva dalItemReserva = new DAL.ItemReserva();
            
            Camadas.BLL.Quarto bllQuarto = new Camadas.BLL.Quarto();
           
            Model.Quarto quarto = new Model.Quarto();
            List<Model.Quarto> lstQuarto = new List<Model.Quarto>();
            lstQuarto = bllQuarto.SelectById(itemReserva.quarto);
            quarto = lstQuarto[0];
            
            quarto.status = 'R';

            
            bllQuarto.Update(quarto);

            
            dalItemReserva.Insert(itemReserva);
        }

        public void Update(Model.ItemReserva itemReserva)
        {
            DAL.ItemReserva dalItemReserva = new DAL.ItemReserva();
            
            Camadas.BLL.Quarto bllQuarto = new Camadas.BLL.Quarto();
            
            Model.Quarto quarto = new Model.Quarto();
            List<Model.Quarto> lstQuarto = new List<Model.Quarto>();
            lstQuarto = bllQuarto.SelectById(itemReserva.quarto);
            quarto = lstQuarto[0];
            
            quarto.status = 'R';

            
            bllQuarto.Update(quarto);

            
            dalItemReserva.Update(itemReserva);
        }

        public void Delete(Model.ItemReserva itemReserva)
        {
            DAL.ItemReserva dalItemReserva = new DAL.ItemReserva();

            dalItemReserva.Delete(itemReserva);
        }
    }
}
