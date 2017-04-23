using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class User
    {
        private string id;
        public string Id { get => id; set => id = value; }

        private string user;
        public string Account { get => user; set => user = value; }

        public User( string id, string user)
        {
            this.user = user;
            this.id = id;
        }
    }
}
