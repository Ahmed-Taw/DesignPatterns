using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.FlyWieght
{
    public class TileFactory
    {
        private Dictionary<string, ITile> _Availabletiles;

        public ITile GetTile(string tileType)
        {
            switch (tileType)
            {
               case "Ceramic":
            if (!_Availabletiles.Keys.Contains("tileType"))
                _Availabletiles.Add("Ceramic", new CeramicTile());
            return _Availabletiles["Ceramic"];
                default:
                    return null;
            }
            

                
        }
    }
}
