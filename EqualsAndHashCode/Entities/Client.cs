using System;
using System.Collections.Generic;
using System.Text;

namespace EqualsAndHashCode.Entities
{
    class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object obj)
        {
            if (!(obj is Client))
            {
                return false;
            }
            Client other = obj as Client;

            //return obj is Client client &&
            //       Name == client.Name &&
            //       Email == client.Email;
            return Email.Equals(other.Email);
        }

        public override int GetHashCode()
        {
            //return HashCode.Combine(Name, Email);
            return Email.GetHashCode();
        }


    }
}
