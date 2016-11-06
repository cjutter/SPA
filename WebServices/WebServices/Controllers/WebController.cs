using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebServices.Models;

namespace WebServices.Controllers
{
    public class WebController : ApiController
 
    {
        private ReservationRespository repo = ReservationRespository.Current;

        public IEnumerable<Reservation> GetAllReservations()
        {
            return repo.GetAll();
        }

        public Reservation GetReservation(int id)
        {
            return repo.Get(id);
        }

        //public Reservation PostReservation(Reservation item)
        //{
        //    return repo.Add(item);
        //}

        [HttpPost]
        public Reservation CreateReservation(Reservation item)
        {
            return repo.Add(item);
        }

        public void DeleteReservation(int id)
        {
            repo.Remove(id);
        }

        [HttpPut]
        public bool UpdateReservation(Reservation item)
        {
            return repo.Update(item);
        }

    }
}
