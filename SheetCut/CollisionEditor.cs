using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SheetCut
{
    enum Mod { Default, Edit, Move, Rleft, Rright, Rtop, Rbottom };

    public partial class CollisionEditor : Form
    {
        private Image _spritesheet;
        public Image spritesheet
        {
            get { return _spritesheet; }
            set { _spritesheet = spritesheet; }
        }
        private Form1 form;
        private int zoom = 10;
        private Sprite _tsprite;
        private SolidBrush brush;

        // *** ACCESSEURS ***
        public Sprite Tsprite{ get; set; }

        // pour la selection
        private Pen selectionPen = new Pen(Color.Black);
        private Rectangle selection = new Rectangle(Point.Empty, Size.Empty);
        private Rectangle originSelection = new Rectangle(Point.Empty, Size.Empty);
        private Point originCursor = new Point();
        Rectangle resizeArea = new Rectangle(Point.Empty, Size.Empty);

        private Mod mod;

        private struct Rinfo
        {
            public int xy, size;
            public Rinfo(int p1, int p2)
            {
                xy = p1;
                size = p2;
            }
        }

        public CollisionEditor(Form1 pForm)
        {
            InitializeComponent();
            _spritesheet = pForm.spritesheet;
            selectionPen.DashStyle = DashStyle.Dash;
            form = pForm;
            brush = new SolidBrush(Color.FromArgb(128, 0, 255, 255));
            //colorViewer.BackColor = colorDialog.Color;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            resizeArea.X = selection.X - 1;
            resizeArea.Y = selection.Y - 1;
            resizeArea.Width = selection.Width + 2;
            resizeArea.Height = selection.Height + 2;

            image.Width = Tsprite.quad.Width * zoom; //+ toolStrip1.Width;
            image.Height = Tsprite.quad.Height * zoom;

            image.Refresh();

            // Mise a jour des bouttons
            if(Variables.lCollisionBox.Count > 0)
            {
                cut.Enabled = true;
                remove.Enabled = true;
            }
            else
            {
                cut.Enabled = false;
                remove.Enabled = false;
            }

            // Mise à jour de la couleur du Visualisateur de couleur
            colorViewer.BackColor = colorDialog.Color;
        }

        private void image_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;//PixelOffsetMode.HighQuality;
            e.Graphics.ScaleTransform(zoom, zoom);

            e.Graphics.DrawImage(_spritesheet, 0, 0, Tsprite.quad, GraphicsUnit.Pixel);

            // pour dessiner les boîtes de collision
            foreach(CollisionBox box in Tsprite.GetCollisionBoxes())
            {
                brush.Color = box.Color;
                e.Graphics.FillRectangle(brush, box.Position);
                Console.WriteLine(box.ToString());
            }

            // pour dessiner la selection
            selectionPen.DashOffset += 0.5f;
            selectionPen.Alignment = PenAlignment.Inset;
            e.Graphics.DrawRectangle(selectionPen, selection);
        }

        private void CollisionEditor_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Enabled = true;
        }

        private void image_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle mouse = new Rectangle(Point.Empty, Size.Empty);
            mouse.X = e.X / zoom;
            mouse.Y = e.Y / zoom;

            mod = Mod.Edit; //getmod(mouse);
            originCursor = mouse.Location;
            originSelection = selection;
        }

        private void image_MouseUp(object sender, MouseEventArgs e)
        {
            mod = Mod.Default;
        }

        private void image_MouseMove(object sender, MouseEventArgs e)
        {
            Rectangle mouse = new Rectangle(Point.Empty, Size.Empty);
            mouse.X = e.X / zoom;
            mouse.Y = e.Y / zoom;

            /*
            if (mouse.IntersectsWith(resizeArea))
            {
                if (mouse.Y == selection.Y)
                    image.Cursor = Cursors.SizeNS;
                else if (mouse.Y == selection.Y + selection.Height)
                    image.Cursor = Cursors.SizeNS;
                else if (mouse.X == selection.X)
                    image.Cursor = Cursors.SizeWE;
                else if (mouse.X == selection.X + selection.Width)
                    image.Cursor = Cursors.SizeWE;
                else
                    image.Cursor = Cursors.SizeAll;
            }
            else
            {
                image.Cursor = Cursors.Default;
            }*/

            Point newOrigin = new Point();
            Size size = new Size();
            //Rinfo info;

            switch (mod)
            {
                case Mod.Edit:
                    if (mouse.X > originCursor.X && mouse.Y > originCursor.Y)
                    {
                        size.Width = mouse.X - originCursor.X;
                        size.Height = mouse.Y - originCursor.Y;
                        newOrigin = originCursor;
                    }
                    else if (mouse.X > originCursor.X && mouse.Y < originCursor.Y)
                    {
                        size.Width = mouse.X - originCursor.X;
                        size.Height = originCursor.Y - mouse.Y;
                        newOrigin = mouse.Location;
                        newOrigin.X = mouse.X - size.Width;
                    }
                    else if (mouse.X < originCursor.X && mouse.Y < originCursor.Y)
                    {
                        size.Width = originCursor.X - mouse.X;
                        size.Height = originCursor.Y - mouse.Y;
                        newOrigin = mouse.Location;
                    }
                    else if (mouse.X < originCursor.X && mouse.Y > originCursor.Y)
                    {
                        size.Width = originCursor.X - mouse.X;
                        size.Height = mouse.Y - originCursor.Y;
                        newOrigin = mouse.Location;
                        newOrigin.Y = mouse.Y - size.Height;
                    }

                    selection.Location = newOrigin;
                    selection.Size = size;
                    break;

               /* case Mod.Move:
                    int width = originCursor.X - mouse.X;
                    int height = originCursor.Y - mouse.Y;
                    newOrigin.X = originSelection.X - width;
                    newOrigin.Y = originSelection.Y - height;
                    selection.Location = newOrigin;
                    break;
                case Mod.Rtop:
                    info = resize(mouse.Y, originSelection.Y + originSelection.Height);
                    selection.Y = info.xy;
                    selection.Height = info.size;
                    break;
                case Mod.Rbottom:
                    info = resize(mouse.Y, originSelection.Y);
                    selection.Y = info.xy;
                    selection.Height = info.size;
                    break;
                case Mod.Rleft:
                    info = resize(mouse.X, originSelection.X + originSelection.Width);
                    selection.X = info.xy;
                    selection.Width = info.size;
                    break;
                case Mod.Rright:
                    info = resize(mouse.X, originSelection.X);
                    selection.X = info.xy;
                    selection.Width = info.size;
                    break;*/
            }

            /*if (treeSprite.SelectedNode != null)
            {
                Variables.lAnimation[treeAnimation.SelectedNode.Index].sprites[treeSprite.SelectedNode.Index].quad = selection;
            }*/
        }

        private Rinfo resize(int v, int o)
        {
            Rinfo info = new Rinfo(v, v - o);

            if (info.size < 0)
            {
                info.size = Math.Abs(info.size);
            }
            else
            {
                info.xy = o;
            }

            return info;
        }

        private void reset_Click(object sender, EventArgs e)
        {
            nameText.Text = "";
            valueText.Text = "";
        }

        private void create_Click(object sender, EventArgs e)
        {
            Variables.lCollisionBox.Add(new CollisionBox(nameText.Text, int.Parse(valueText.Text), colorDialog.Color));
            updateListCollisionBox();
            nameText.Text = "";
            valueText.Text = "";
            colorDialog.Reset();
        }

        private void updateListCollisionBox()
        {
            listCollisionBox.Items.Clear();

            foreach(CollisionBox box in Variables.lCollisionBox)
            {
                listCollisionBox.Items.Add(box.Name);
            }
        }

        private void remove_Click(object sender, EventArgs e)
        {
            int index = listCollisionBox.SelectedIndex;
            Variables.lCollisionBox.RemoveAt(index);
            updateListCollisionBox();
        }

        private void CollisionEditor_Load(object sender, EventArgs e)
        {
            updateListCollisionBox();
        }

        private void cut_Click(object sender, EventArgs e)
        {
            int index = listCollisionBox.SelectedIndex;

            CollisionBox box = new CollisionBox(Variables.lCollisionBox[index].Name, Variables.lCollisionBox[index].Value, Variables.lCollisionBox[index].Color);
            box.setPosition(selection.Location, selection.Size);
            box.Color = Variables.lCollisionBox[index].Color;

            Tsprite.addCollisionBox(box);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
        }
    }
}
