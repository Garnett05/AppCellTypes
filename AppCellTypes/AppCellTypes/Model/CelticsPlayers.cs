using System;
using System.Collections.Generic;
using System.Text;

namespace AppCellTypes.Model
{
    public class CelticsPlayers
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Photo { get; set; }

        public CelticsPlayers(string name, string position, string photo)
        {
            Name = name;
            Position = position;
            Photo = photo;
        }
    }
}
