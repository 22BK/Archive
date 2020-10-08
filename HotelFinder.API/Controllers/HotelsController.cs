﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HotelFinder.Business.Abstract;
using HotelFinder.Business.Concrete;
using HotelFinder.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelsController : ControllerBase
    {
        private IHotelService _hotelService;

        public HotelsController(IHotelService hotelService)
        {
            _hotelService = hotelService;
        }

        /// <summary>
        /// Get All Hotels
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var hotels = await _hotelService.GetAllHotels();
            return Ok(hotels); // response code : 200 + data
        }

        /// <summary>
        /// Get Hotel By Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]/{id}")]//[Route("GetHotelById/{id}")] api/hotels/gethotelbyid/2
        public async Task<IActionResult> GetHotelById(int id)
        {
            var hotel = await _hotelService.GetHotelById(id);
            if (hotel != null)
            {
                return Ok(hotel);
            }
            return NotFound(); // response code : 404
        }

        /// <summary>
        /// Get Hotel By Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("[action]/{name}")] //api/hotels/gethotelbyname/Hilton
        public async Task<IActionResult> GetHotelByName(string name)
        {
            var hotel = await _hotelService.GetHotelByName(name);
            if (hotel != null)
            {
                return Ok(hotel);
            }
            return NotFound();
                
        }

        // two parameters sample
        //[HttpGet]
        //[Route("[action]")] //with no parameters api/hotels/gethotelbyIdAndName?id=2&name=Hilton
        //public IActionResult GetHotelByIdAndName(int id, string name)
        //{
        //        return  Ok();
        //}

        /// <summary>
        /// Create Hotel
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CreateHotel([FromBody]Hotel hotel)
        {
            if (ModelState.IsValid)
            {
                var createdHotel = await _hotelService.CreateHotel(hotel);
                return CreatedAtAction("Get",new {id= createdHotel.Id },createdHotel); // response code : 201 + data
            }
            return BadRequest(ModelState); // response code : 400 + validation errors"
        }


        /// <summary>
        /// Update Hotel
        /// </summary>
        /// <param name="hotel"></param>
        /// <returns></returns>
        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> UpdateHotel([FromBody]Hotel hotel)
        {
            if (await _hotelService.GetHotelById(hotel.Id)!=null)
            {
                return Ok( await _hotelService.UpdateHotel(hotel));
            }
            return NotFound();
        }

        /// <summary>
        /// Delete Hotel
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete]
        [Route("[action]/{id}")]
        public async Task<IActionResult> DeleteHotel(int id)
        {
            if (await _hotelService.GetHotelById(id) != null)
            {
                await _hotelService.DeleteHotel(id);
                return Ok();
            }
            return NotFound();
        }
    }
}