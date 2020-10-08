using HotelFinder.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelFinder.DAL.Abstract
{
    public interface IHotelRepository
    {
        List<Hotel> GetAllHotels();

        Hotel GetHotelById(int id);

        Hotel GetHotelByName(String name);

        Hotel CreateHotel(Hotel hotel);

        Hotel UpdateHotel(Hotel hotel);

        void DeleteHotel(int id);
    }
}
