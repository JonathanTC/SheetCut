using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SheetCut
{
    [DataContract]
    class Frame
    {
        [DataMember]
        public Sprite sprite;

        [DataMember]
        public int time;

        public Frame(Sprite pSprite)
        {
            sprite = pSprite;
            time = 100;
        }
    }
}
