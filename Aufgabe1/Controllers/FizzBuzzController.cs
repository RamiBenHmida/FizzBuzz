using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using System;

namespace Aufgabe1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class FizzBuzzController : ControllerBase
    {

        [HttpGet("{id}")]
        public dynamic Get(String id)
        {
            int numeric_id;
            if (id == null || id == "") //check if input is empty.
            {
                return ("id can't be empty");
            }
            else
            {
                if (int.TryParse(id, out numeric_id)) //check if input in numeric. 
                {
                    if (numeric_id > 0) //check if input is positiv.
                    {
                        //this code will only run if input is an Integer bigger than 0.
                        //give back the FizzBuzz Object.
                        List<FizzBuzz> list = new List<FizzBuzz>();

                        for (int i = 1; i <= numeric_id; i++)
                        {
                            FizzBuzz fizzBuzz = new(i);

                            if (fizzBuzz.Result != "")
                            {
                                list.Add(fizzBuzz);
                            }
                        }
                        return list.ToArray();

                    }
                    else
                    {
                        return ("Id value must be bigger than 0");
                    }
                }
                else
                {
                    return ("Id value must be of type int, got non-numeric");
                }
            }
        }
    }
}