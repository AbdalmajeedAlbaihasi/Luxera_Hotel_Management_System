using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMS.Shared.DTOs.Client
{
    public class ClientNameAndIDDTO
    {
        public ClientNameAndIDDTO(int clientID, string firstName, string lastName)
        {
            ClientID = clientID;
            FirstName = firstName;
            LastName = lastName;
        }
        public int ClientID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
