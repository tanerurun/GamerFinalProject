using System;
using System.Collections.Generic;
using System.Text;

namespace GamerCreateProject
{
    interface IGamerSerivce
    {
        void Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
