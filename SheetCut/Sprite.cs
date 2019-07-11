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
    public class Sprite
    {
        [DataMember]
        public Rectangle quad;

        [DataMember]
        public bool isSelected;

        [DataMember]
        public int id;

        private List<CollisionBox> collisionBoxes;

        public Sprite()
        {
            // ctor
        }

        public Sprite(Rectangle selection, int pId)
        {
            quad = new Rectangle();
            quad = selection;
            isSelected = true;
            id = pId;
            collisionBoxes = new List<CollisionBox>();
        }

        public void addCollisionBox(CollisionBox box)
        {
            collisionBoxes.Add(box);
        }

        public List<CollisionBox> GetCollisionBoxes()
        {
            return collisionBoxes;
        }

    }
}
