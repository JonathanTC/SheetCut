using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheetCut
{
    [DataContract]
    class Variables
    {
        [DataMember]
        public static List<Animation> lAnimation = new List<Animation>();
        public static List<CollisionBox> lCollisionBox = new List<CollisionBox>();
    }
}
