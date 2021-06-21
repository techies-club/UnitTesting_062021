using BusinessLibrary.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherWebAPITest.Mock
{
    public class LoginMock : ILogin
    {
        public bool Login(string userID, string pin)
        {
            return (!string.IsNullOrEmpty(userID) && !string.IsNullOrEmpty(pin));
        }
    }
}
