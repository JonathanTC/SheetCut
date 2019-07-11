using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.IO;

namespace SheetCut
{
    //enum Mod { Default, Edit, Move, Rleft, Rright, Rtop, Rbottom };

    public partial class Form1 : Form
    {
        private Pen selectionPen = new Pen(Color.Black);

        private Rectangle selection = new Rectangle(Point.Empty, Size.Empty);
        private Rectangle originSelection = new Rectangle(Point.Empty, Size.Empty);
        private Point originCursor = new Point();
        Rectangle resizeArea = new Rectangle(Point.Empty, Size.Empty);

        private int zoom = 1;

        private Image _spritesheet;
        public Image spritesheet
        {
            get { return _spritesheet; }
        }

        private int irow = -1;

        private struct Rinfo
        {
            public int xy, size;
            public Rinfo(int p1, int p2)
            {
                xy = p1;
                size = p2;
            }
        }

        private Mod mod;

        public Form1()
        {
            InitializeComponent();
            _spritesheet = image.Image;
            selectionPen.DashStyle = DashStyle.Dash;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            resizeArea.X = selection.X - 1;
            resizeArea.Y = selection.Y - 1;
            resizeArea.Width = selection.Width + 2;
            resizeArea.Height = selection.Height + 2;

            UpdateAnimationButton();
            UpdateSpriteButton();
            UpdateImageButton();
            UpdateFrameButton();

            image.Refresh();
            lecteur.Refresh();
        }

        private void UpdatePlayerButton()
        { 
            if(treeAnimation.SelectedNode != null)
            {
                if (Variables.lAnimation[treeAnimation.SelectedNode.Index].frames.Count > 1)
                {
                    playPlayerButton.Enabled = true;
                    repeatPlayerButton.Enabled = true;
                }
                else
                {
                    playPlayerButton.Enabled = false;
                    repeatPlayerButton.Enabled = false;
                }
            }
        }

        private void UpdateImageButton()
        {
            if (zoom > 1) { zoomOutImageButton.Enabled = true; }
            else { zoomOutImageButton.Enabled = false; }
        }

        private void UpdateAnimationButton()
        {
            if (treeAnimation.SelectedNode != null)
            {
                if (renameAnimationButton.CheckState == CheckState.Checked)
                {
                    removeAnimationButton.Enabled = false;
                    addAnimationButton.Enabled = false;
                    upAnimationButton.Enabled = false;
                    downAnimationButton.Enabled = false;
                }
                else
                {
                    removeAnimationButton.Enabled = true;
                    addAnimationButton.Enabled = true;

                    if (treeAnimation.Nodes.Count > 1)
                    {
                        upAnimationButton.Enabled = true;
                        downAnimationButton.Enabled = true;
                    }
                }

                renameAnimationButton.Enabled = true;
            }
            else
            {
                addAnimationButton.Enabled = true;
                removeAnimationButton.Enabled = false;
                renameAnimationButton.Enabled = false;
                upAnimationButton.Enabled = false;
                downAnimationButton.Enabled = false;
            }
        }

        private void UpdateSpriteButton()
        {
            if (treeAnimation.SelectedNode != null)
            {
                cutSpriteButton.Enabled = true;
            }
            else
            {
                cutSpriteButton.Enabled = false;
            }

            if (treeSprite.SelectedNode != null)
            {
                removeSpriteButton.Enabled = true;
                exportSpriteButton.Enabled = true;
                editSpriteButton.Enabled = true;
            }
            else
            {
                removeSpriteButton.Enabled = false;
                exportSpriteButton.Enabled = false;
                editSpriteButton.Enabled = false;
            }
        }

        private void UpdateFrameButton()
        {
            if(timeLine.Rows.Count > 0)
            {
                removeFrameButton.Enabled = true;
            }
            else
            {
                removeFrameButton.Enabled = false;
            }
        }

        private void UpdateListAnimation()
        {
            treeAnimation.Nodes.Clear();

            foreach (Animation animation in Variables.lAnimation)
                treeAnimation.Nodes.Add(animation.name);
        }

        private void addAnimationButton_Click(object sender, EventArgs e)
        {
            Variables.lAnimation.Add(new Animation());
            UpdateListAnimation();
        }

        private void removeAnimationButton_Click(object sender, EventArgs e)
        {
            Variables.lAnimation.RemoveAt(treeAnimation.SelectedNode.Index);
            treeAnimation.SelectedNode.Remove();

            // si plus d'animation ont efface tous les cadres
            if(Variables.lAnimation.Count == 0)
            {
                irow = -1; 
                treeSprite.Nodes.Clear();
                timeLine.Rows.Clear();
            }
        }

        private void renameAnimationButton_Click(object sender, EventArgs e)
        {
            if (treeAnimation.SelectedNode != null && renameAnimationButton.CheckState == CheckState.Unchecked)
            {
                renameAnimationButton.CheckState = CheckState.Checked;
                treeAnimation.LabelEdit = true;
                treeAnimation.SelectedNode.BeginEdit();
            }
        }

        private void treeAnimation_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if (e.Label != null)
                Variables.lAnimation[treeAnimation.SelectedNode.Index].name = e.Label;

            treeAnimation.LabelEdit = false;
            renameAnimationButton.CheckState = CheckState.Unchecked;
        }

        private void cutSpriteButton_Click(object sender, EventArgs e)
        {
            if (treeSprite.SelectedNode != null)
                Variables.lAnimation[treeAnimation.SelectedNode.Index].sprites[treeSprite.SelectedNode.Index].isSelected = false;

            treeSprite.Nodes.Add(""+treeSprite.Nodes.Count);

            treeSprite.SelectedNode = treeSprite.Nodes[treeSprite.Nodes.Count - 1];

            Variables.lAnimation[treeAnimation.SelectedNode.Index].sprites.Add(new Sprite(selection, treeSprite.Nodes.Count - 1));
        }

        private void removeSpriteButton_Click(object sender, EventArgs e)
        {
            // supprime toute les frames de la liste qui contient l'id du sprite supprimer
            Variables.lAnimation[treeAnimation.SelectedNode.Index].frames.RemoveAll(frame => frame.sprite.id == treeSprite.SelectedNode.Index);

            // supprime le sprite de la liste de sprite
            Variables.lAnimation[treeAnimation.SelectedNode.Index].sprites.RemoveAt(treeSprite.SelectedNode.Index);

            // mise a jour de la liste de sprite
            UpdateSpriteList();

            // mise a jour de la liste de frame
            UpdateFrameList();

            irow = -1;
        }

        private void upSpriteButton_Click(object sender, EventArgs e)
        {
            treeSprite.SelectedNode = treeSprite.Nodes[treeSprite.SelectedNode.Index - 1];
        }

        private void downSpriteButton_Click(object sender, EventArgs e)
        {
            treeSprite.SelectedNode = treeSprite.Nodes[treeSprite.SelectedNode.Index + 1];
        }

        private void zoomInImageButton_Click(object sender, EventArgs e)
        {
            zoom += 1;
            image.Refresh();
            image.Size = new Size(_spritesheet.Width * zoom, _spritesheet.Height * zoom);
        }

        private void zoomOutImageButton_Click(object sender, EventArgs e)
        {
            zoom -= 1;
            image.Refresh();
            image.Size = new Size(_spritesheet.Width * zoom, _spritesheet.Height * zoom);
        }

        private void image_Paint(object sender, PaintEventArgs e)
        {
            SolidBrush brush;

            e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
            e.Graphics.ScaleTransform(zoom,zoom);
            e.Graphics.DrawImage(_spritesheet, Point.Empty);

            /* Pour afficher les quad des sprites */
            if(treeAnimation.SelectedNode != null)
            {
                foreach (Sprite sprite in Variables.lAnimation[treeAnimation.SelectedNode.Index].sprites)
                {
                    if (sprite.isSelected)
                    {
                        brush = new SolidBrush(Color.FromArgb(128, 0, 255, 0));
                    }
                    else
                    {
                        brush = new SolidBrush(Color.FromArgb(128, 0, 0, 255));
                    }

                    e.Graphics.FillRectangle(brush, sprite.quad);
                }
            }
  
            selectionPen.DashOffset += 1;

            //e.Graphics.DrawRectangle(Pens.Red, resizeArea);
            e.Graphics.DrawRectangle(Pens.White, selection);
            e.Graphics.DrawRectangle(selectionPen, selection);
        }

        private void upAnimationButton_Click(object sender, EventArgs e)
        {
            var index = treeAnimation.SelectedNode.Index;
            Swap(Variables.lAnimation, index, index - 1);
            UpdateListAnimation();
            treeAnimation.SelectedNode = treeAnimation.Nodes[index - 1];
        }

        private void downAnimationButton_Click(object sender, EventArgs e)
        {
            var index = treeAnimation.SelectedNode.Index;
            Swap(Variables.lAnimation, index, index + 1);
            UpdateListAnimation();
            treeAnimation.SelectedNode = treeAnimation.Nodes[index + 1];
        }

        private Mod getmod(Rectangle mouse)
        {
            if (mouse.IntersectsWith(resizeArea))
            {
                if (mouse.IntersectsWith(selection))
                {
                    return Mod.Move;
                }
                else
                {
                    if (mouse.X == selection.X)
                    {
                        return Mod.Rleft;
                    }
                    if (mouse.X == selection.X + selection.Width)
                    {
                        return Mod.Rright;
                    }
                    if (mouse.Y == selection.Y)
                    {
                        return Mod.Rtop;
                    }
                    if (mouse.Y == selection.Y + selection.Height)
                    {
                        return Mod.Rbottom;
                    }
                }
            }

            int index = 0;
            foreach (Sprite sprite in Variables.lAnimation[treeAnimation.SelectedNode.Index].sprites)
            {
                selectsprite(index);

                if (mouse.IntersectsWith(resizeArea))
                {
                    if (mouse.IntersectsWith(sprite.quad))
                    {
                        return Mod.Move;
                    }
                    else
                    {
                        if (mouse.X == selection.X)
                        {
                            return Mod.Rleft;
                        }
                        if (mouse.X == selection.X + selection.Width)
                        {
                            return Mod.Rright;
                        }
                        if (mouse.Y == selection.Y)
                        {
                            return Mod.Rtop;
                        }
                        if (mouse.Y == selection.Y + selection.Height)
                        {
                            return Mod.Rbottom;
                        }
                    }
                }

                index++;
            }

            selectsprite(-1);

            return Mod.Edit;
        }

        private void selectsprite(int index)
        {
            foreach (Sprite sprite in Variables.lAnimation[treeAnimation.SelectedNode.Index].sprites)
            {
                sprite.isSelected = false;
            }

            if (index != -1)
            {
                treeSprite.SelectedNode = treeSprite.Nodes[index];
                Variables.lAnimation[treeAnimation.SelectedNode.Index].sprites[index].isSelected = true;
                selection = Variables.lAnimation[treeAnimation.SelectedNode.Index].sprites[treeSprite.SelectedNode.Index].quad;

                resizeArea.X = selection.X - 1;
                resizeArea.Y = selection.Y - 1;
                resizeArea.Width = selection.Width + 2;
                resizeArea.Height = selection.Height + 2;
            }
            else
            {
                selection = new Rectangle();
                resizeArea = new Rectangle();
                treeSprite.SelectedNode = null;
            }
        }

        private void image_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle mouse = new Rectangle(Point.Empty, Size.Empty);
            mouse.X = e.X / zoom;
            mouse.Y = e.Y / zoom;

            if(treeAnimation.SelectedNode != null)
            {
                mod = getmod(mouse);
                originCursor = mouse.Location;
                originSelection = selection;
            }
        }

        private void image_MouseMove(object sender, MouseEventArgs e)
        {
            Rectangle mouse = new Rectangle(Point.Empty, Size.Empty);
            mouse.X = e.X / zoom;
            mouse.Y = e.Y / zoom;

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
            }else
            {
                image.Cursor = Cursors.Default;
            }

            Point newOrigin = new Point();
            Size size = new Size();
            Rinfo info;

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
                case Mod.Move:
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
                    break;
            }

            if (treeSprite.SelectedNode != null)
            {
                Variables.lAnimation[treeAnimation.SelectedNode.Index].sprites[treeSprite.SelectedNode.Index].quad = selection;
            }
        }

        private void image_MouseUp(object sender, MouseEventArgs e)
        {
            mod = Mod.Default;
        }

        public static void Swap<T>(IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
                selection.Y--;
            if (e.KeyCode == Keys.Down)
                selection.Y++;
            if (e.KeyCode == Keys.Right)
                selection.X++;
            if (e.KeyCode == Keys.Left)
                selection.X--;
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

        private void treeSprite_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            selectsprite(e.Node.Index);        
        }

        private void treeAnimation_AfterSelect(object sender, TreeViewEventArgs e)
        {
            irow = -1;

            // mise a jour de la liste de sprite
            UpdateSpriteList();

            // mise a jour de la liste de frame
            UpdateFrameList();
        }

        private void exportSpriteButton_Click(object sender, EventArgs e)
        {
            Frame frame = new Frame(Variables.lAnimation[treeAnimation.SelectedNode.Index].sprites[treeSprite.SelectedNode.Index]);
            Variables.lAnimation[treeAnimation.SelectedNode.Index].frames.Add(frame);

            timeLine.Rows.Add(1);
            timeLine.Rows[timeLine.Rows.Count - 1].Cells[0].Value = Variables.lAnimation[treeAnimation.SelectedNode.Index].frames.Count;
            timeLine.Rows[timeLine.Rows.Count - 1].Cells[1].Value = frame.sprite.id;
            timeLine.Rows[timeLine.Rows.Count - 1].Cells[2].Value = frame.time;

            UpdatePlayerButton();
        }

        private void removeFrameButton_Click(object sender, EventArgs e)
        {
            // recherche de la ligne selectioner
            foreach(DataGridViewRow row in timeLine.SelectedRows)
            {
                irow = row.Index;
            }

            // efface la frame selectioner dans la liste de frame
            Variables.lAnimation[treeAnimation.SelectedNode.Index].frames.RemoveAt(irow);

            // mise a jour de la liste de frame
            UpdateFrameList();

            //mise a jour des boutons du lecteur
            UpdatePlayerButton();

            irow = -1;
        }

        private void timeLine_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string sEntier = timeLine.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
            Variables.lAnimation[treeAnimation.SelectedNode.Index].frames[e.RowIndex].time = int.Parse(sEntier);
        }

        private void UpdateFrameList()
        {
            timeLine.Rows.Clear();

            int index = 1;

            foreach (Frame frame in Variables.lAnimation[treeAnimation.SelectedNode.Index].frames)
            {
                timeLine.Rows.Add(1);
                timeLine.Rows[timeLine.Rows.Count - 1].Cells[0].Value = index;
                timeLine.Rows[timeLine.Rows.Count - 1].Cells[1].Value = frame.sprite.id;
                timeLine.Rows[timeLine.Rows.Count - 1].Cells[2].Value = frame.time;
                index++;
            }
        }

        private void UpdateSpriteList()
        {
            int index = 0;

            treeSprite.Nodes.Clear();

            if (Variables.lAnimation[treeAnimation.SelectedNode.Index].sprites.Count > 0)
            {
                foreach (Sprite sprite in Variables.lAnimation[treeAnimation.SelectedNode.Index].sprites)
                {
                    treeSprite.Nodes.Add("" + index);
                    sprite.id = index;
                    index++;
                }
            }

            selectsprite(-1);
        }

        private void lecteur_Paint(object sender, PaintEventArgs e)
        {
            // recherche de la ligne selectioner
            foreach (DataGridViewRow row in timeLine.SelectedRows)
            {
                irow = row.Index;
            }

            if(treeAnimation.SelectedNode != null && irow != -1)
            {
                var quad = Variables.lAnimation[treeAnimation.SelectedNode.Index].frames[irow].sprite.quad;
                e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                e.Graphics.DrawImage(_spritesheet, new Rectangle(Point.Empty,lecteur.Size), quad, GraphicsUnit.Pixel);
            }               
        }

        private void playPlayerButton_Click(object sender, EventArgs e)
        {
            Variables.lAnimation[treeAnimation.SelectedNode.Index].currentFrame = 0;
            var currentFrame = Variables.lAnimation[treeAnimation.SelectedNode.Index].currentFrame;
            timeLine.Rows[currentFrame].Selected = true;
            frameTimer.Interval = int.Parse(timeLine.Rows[currentFrame].Cells[2].Value.ToString());
            frameTimer.Enabled = true;

            if(repeatPlayerButton.Checked)
            {
                playPlayerButton.Enabled = false;
                stopPlayerButton.Enabled = true;
            }
        }

        private void frameTimer_Tick(object sender, EventArgs e)
        {
            if (treeAnimation.SelectedNode != null)
            {
                var currentFrame = Variables.lAnimation[treeAnimation.SelectedNode.Index].currentFrame;
                var maxFrame = Variables.lAnimation[treeAnimation.SelectedNode.Index].frames.Count;

                if (currentFrame < maxFrame)
                {
                    timeLine.ClearSelection();

                    Variables.lAnimation[treeAnimation.SelectedNode.Index].currentFrame += 1;
                    currentFrame++;

                    timeLine.Rows[currentFrame-1].Selected = true;

                    frameTimer.Interval = int.Parse(timeLine.Rows[currentFrame-1].Cells[2].Value.ToString());
                }
                else
                {
                    if(repeatPlayerButton.Checked)
                    {
                        Variables.lAnimation[treeAnimation.SelectedNode.Index].currentFrame = 0;
                    }
                    else
                    {
                        frameTimer.Enabled = false;
                    }   
                }
            }
           
            lecteur.Refresh();
        }

        private void repeatPlayerButton_Click(object sender, EventArgs e)
        {
            if(!repeatPlayerButton.Checked)
            {
                repeatPlayerButton.Checked = true;
            }
            else
            {
                repeatPlayerButton.Checked = false;
            }
        }

        private void stopPlayerButton_Click(object sender, EventArgs e)
        {
            frameTimer.Enabled = false;
            playPlayerButton.Enabled = true;
            stopPlayerButton.Enabled = false;
        }

        private void editSpriteButton_Click(object sender, EventArgs e)
        {
            CollisionEditor collisionEditor = new CollisionEditor(this);
            collisionEditor.Tsprite = Variables.lAnimation[treeAnimation.SelectedNode.Index].sprites[treeSprite.SelectedNode.Index];
            collisionEditor.Show();
            this.Enabled = false;
        }

        private void enregistrerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveDialogue.ShowDialog();
        }

        private void saveDialogue_FileOk(object sender, CancelEventArgs e)
        {
            // creation du sérialiser
            Serializer serializer = new Serializer();

            // je créer un objet qui pointe vers l'ensemble des animations 
            Object obj = new Object(Variables.lAnimation);

            // je convertis l'objet au format Json et l'enregistre à l'emplacement indiquer
            serializer.Serialize(saveDialogue.FileName, obj);
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void nouveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openImage.ShowDialog();
        }

        private void openImage_FileOk(object sender, CancelEventArgs e)
        {
            image.ImageLocation = openImage.FileName;
            image.Load(openImage.FileName);
            _spritesheet = image.Image;
        }
    }
}
