using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLibrary.Abstract
{
  public interface ILogin
    {
        bool Login(string userID, string pin);
    }
}
