using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SheetCut
{
    [DataContract]
    class Animation
    {
        [DataMember]
        public string name;

        [DataMember]
        public int currentFrame;

        [DataMember]
        public List<Sprite> sprites;

        [DataMember]
        public List<Frame> frames;

        public Animation()
        {
            name = "Nouvelle animation";
            sprites = new List<Sprite>();
            frames = new List<Frame>();
            currentFrame = 0;
        }
    }
}
