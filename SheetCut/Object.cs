using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SheetCut
{
    [DataContract]
    class Object
    {
        [DataMember]
        public List<Animation> animations;

        public Object(List<Animation> pListe)
        {
            animations = pListe;
        }
    }
}
